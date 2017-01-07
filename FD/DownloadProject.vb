Imports System.Configuration
Imports System.Data.SqlClient
Imports HtmlAgilityPack
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Threading.Tasks

Public Class DownloadProject

    Private Sub DownloadProject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectsDS.Project' table. You can move, or remove it, as needed.
        Me.ProjectTableAdapter.Fill(Me.ProjectsDS.Project)
        If Not Directory.Exists("imgs") Then
            Directory.CreateDirectory("imgs")
        End If
        If Not Directory.Exists("files") Then
            Directory.CreateDirectory("files")
        End If
    End Sub
    Dim URLPattern, FullXPath As String
    Dim PFrom, PTo As Long
    Dim ProjectID As Integer
    Dim Tencod As Boolean
    Dim downloadStarted As Boolean = False

    Dim AllXPath() As String
    Dim ht As New Hashtable

    Dim con As String = ConfigurationManager.ConnectionStrings("FD.My.MySettings.FDConnectionString").ConnectionString
    Private Sub ButDownload_Click(sender As System.Object, e As System.EventArgs) Handles ButDownload.Click
        StartDownload()
    End Sub
    Public Sub StartDownload()
        ProjectID = cmbProject.SelectedValue
        ProjectPID = SqlHelper.ExecuteScalar(con, CommandType.Text, "select stuff((select ','+convert(nvarchar(50),id) as  [text()] from ProjectAttribute   WHERE (ProjectAttribute.ProjectID = " & ProjectID.ToString & ")for xml path('') ), 1, 1, '' ) as n").ToString
        Dim r As SqlDataReader = SqlHelper.ExecuteReader(con, CommandType.Text, "SELECT URLPattern, PTo,Tencod,PFrom,ff.XPath as XPath FROM Project cross join(SELECT MAX(convert(int,AttributeValue.PageID)) AS MaxID FROM AttributeValue INNER JOIN ProjectAttribute ON AttributeValue.PageAttributeID = ProjectAttribute.id WHERE (ProjectAttribute.ProjectID = @ProjectID)) as d cross join (	select STUFF((select ','+id AS [text()] from ( SELECT [XPath] +':'+convert(nvarchar(50),[id]) as id FROM [dbo].[ProjectAttribute] where projectid=@ProjectID ) as n FOR XML PATH('')), 1, 1, '' ) as XPath) as ff WHERE (id = @ProjectID)", {New SqlParameter("@ProjectID", ProjectID)})
        If r.Read Then
            URLPattern = r("URLPattern").ToString
            PFrom = Long.Parse(r("PFrom").ToString)
            PTo = Long.Parse(r("PTo").ToString)
            FullXPath = r("XPath").ToString
            Tencod = Boolean.Parse(r("Tencod").ToString)
        End If
        r.Close()
        AllXPath = FullXPath.Split(",")
        Dim p() As String
        For Each s As String In AllXPath
            p = s.Split(":")
            ht.Add(p(1), p(0))
        Next
        Dim t As New Threading.Thread(AddressOf BuildList)
        t.IsBackground = True
        t.Start()
        downloadStarted = True
        Timer1.Enabled = chkUpdate.Checked
    End Sub
    Dim bJ, bStart, bEnd As Long
    Private Function GetCurrentThreadCount() As Integer
        Return DirectCast(Process.GetCurrentProcess().Threads, IEnumerable).OfType(Of ProcessThread)().Where(Function(b) b.ThreadState = ThreadState.Running).Count()
    End Function
    Private Function GetRemainingPages() As List(Of Long)
        Dim rm As SqlDataReader = SqlHelper.ExecuteReader(con, CommandType.Text, "SELECT     distinct AttributeValue.PageID FROM ProjectAttribute WITH (NOLOCK) INNER JOIN AttributeValue WITH (NOLOCK) ON ProjectAttribute.id = AttributeValue.PageAttributeID WHERE     (ProjectAttribute.ProjectID = " & ProjectID.ToString & ")")
        Dim tmpLst As New List(Of Long)
        While rm.Read
            tmpLst.Add(rm("PageID"))
        End While
        rm.Close()

        Dim pf2 As Long
        Dim RetLst As New List(Of Long)
        For pf2 = PFrom To PTo
            If Not tmpLst.Contains(pf2) Then
                RetLst.Add(pf2)
            End If
        Next
        Return RetLst
    End Function
    Private Sub BuildList()
        Dim Res As String = ""
        bStart = PFrom
        bEnd = PTo

        Dim MaxThreads As Integer = Integer.Parse(txtThreadsCount.Text)
        Timer2.Enabled = True
        'While 1
        Dim RList As List(Of Long) = GetRemainingPages()
        If MaxThreads > 0 Then
            Parallel.ForEach(RList, New ParallelOptions() With {.MaxDegreeOfParallelism = MaxThreads},
                   Sub(index As Long)
                       ExtractDataOneP(index.ToString)
                   End Sub)

            'For Me.bJ = bStart To bEnd
            '    While GetCurrentThreadCount() > MaxThreads
            '        Threading.Thread.Sleep(1000)
            '    End While
            '    Dim t As New Threading.Thread(AddressOf ExtractDataOneP)
            '    't.IsBackground = True
            '    t.Start(bJ.ToString)
            'Next
        Else
            For Me.bJ = bStart To bEnd
                ExtractDataOneP(bJ.ToString)
            Next
        End If
        'Threading.Thread.Sleep(60000)
        'End While
    End Sub
    Private Function GetHtmlFromURL(ByVal URL As String) As HtmlNode
        Dim wb As New HtmlAgilityPack.HtmlWeb
        If Tencod Then
            wb.AutoDetectEncoding = False
            wb.OverrideEncoding = Encoding.GetEncoding(1256) ' "windows-1256"
        End If
        Dim doc = wb.Load(URL)
        Return doc.DocumentNode
    End Function

    Private Function GetFileExt(ByVal URL As String) As String
        Dim fileType As String
        Dim wb As New WebClient
        Dim st As Stream = wb.OpenRead(URL)
        fileType = wb.ResponseHeaders("Content-Type")
        st.Close()
        st.Dispose()
        wb.Dispose()
        fileType = fileType.Substring(fileType.LastIndexOf("/") + 1)
        If fileType.Contains(";") Then
            fileType = fileType.Substring(0, fileType.IndexOf(";"))
        End If
        Return fileType
    End Function
    Private Function FixURL(ByVal url As String) As String
        If url.Length > 4 Then
            If url.Substring(0, 4).ToLower = "http" Then
                Return url
            End If
        End If
        Dim host As String = URLPattern.Replace("*", "1")
        Return host.Substring(0, host.LastIndexOf("/") + 1) & url
    End Function
    Private Function DownloadUrlsAndImages(ByVal html As String, ByVal imgs As List(Of String), ByVal hrefs As List(Of String), ByVal FilesPrefix As String) As String
        Dim retHtml As String = html
        Dim wb As New WebClient
        Dim CurFile As Integer
        If imgs.Count > 0 Then
            CurFile = 0
            For Each imgURL As String In imgs
                Try
                    CurFile = CurFile + 1
                    Dim FixedImgURL As String = FixURL(imgURL)
                    Dim fileName As String = "img" & FilesPrefix & "-" & CurFile.ToString & "." & GetFileExt(FixedImgURL)
                    wb.DownloadFileAsync(New System.Uri(FixedImgURL), "imgs\" & fileName)
                    retHtml = retHtml.Replace(imgURL, "imgs/" & fileName)
                Catch ex As Exception

                End Try
            Next
        End If

        If hrefs.Count > 0 Then
            CurFile = 0
            For Each FURL As String In hrefs
                Try
                    CurFile = CurFile + 1
                    Dim FixedFURL As String = FixURL(FURL)
                    Dim ext As String = GetFileExt(FixedFURL).ToLower
                    If ((ext <> "html" And ext <> "htm") And chkNoHTML.Checked) Or Not chkNoHTML.Checked Then
                        Dim fileName As String = "href" & FilesPrefix & "-" & CurFile.ToString & "." & ext
                        wb.DownloadFileAsync(New System.Uri(FixedFURL), "files\" & fileName)
                        retHtml = retHtml.Replace(FURL, "files/" & fileName)
                    End If
                Catch ex As Exception

                End Try

            Next
        End If
        wb.Dispose()
        Return retHtml
    End Function
    Private Function GetTextAtPathFromHTML(ByVal path As String, ByVal HTML As HtmlNode, ByVal FilesPrefix As String) As String
        Try
            Dim hrefs As New List(Of String)
            Dim imgs As New List(Of String)

            If chkDownloadHref.Checked Then
                Dim div = HTML.SelectSingleNode(path)
                If div IsNot Nothing Then
                    hrefs = div.Descendants("a").[Select](Function(a) a.GetAttributeValue("href", "")).ToList()
                End If
            End If
            If chkDownloadPics.Checked Then
                Dim div = HTML.SelectSingleNode(path)
                If div IsNot Nothing Then
                    imgs = div.Descendants("img").[Select](Function(img) img.GetAttributeValue("src", "")).ToList()
                End If
            End If
            Return DownloadUrlsAndImages(HTML.SelectSingleNode(path).InnerHtml, imgs, hrefs, FilesPrefix)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    'Private Sub ExtractData(ByVal url As String, ByVal id As String)

    '    Dim HTML As HtmlNode
    '    HTML = GetHtmlFromURL(url)
    '    For Each k In ht.Keys
    '        SaveData(k, GetTextAtPathFromHTML(ht(k), HTML), id)
    '    Next
    'End Sub
    Private Sub ExtractDataOneP(ByVal id As String)
        'System.Threading.Thread.Sleep(2000)
        Try
            Dim url As String = URLPattern.Replace("*", id)
            Dim HTML As HtmlNode
            HTML = GetHtmlFromURL(url)
            For Each k In ht.Keys

                SaveData(k, GetTextAtPathFromHTML(ht(k), HTML, id & "-" & k.ToString), id)
            Next
        Catch ex As Exception

        End Try

    End Sub
    'Private Function GetNewUniqueID(ByVal s As String) As String
    '    'SqlHelper.ExecuteNonQuery(con, CommandType.Text, "update ProgramSettings set SettingValue=SettingValue+1 where SettingName='" & s & "'")
    '    Dim r As New Random
    '    'Return SqlHelper.ExecuteScalar(con, CommandType.Text, "select SettingValue from ProgramSettings WITH (NOLOCK) where SettingName='" & s & "'") & "-" & r.Next(111111, 999999).ToString()
    '    Return r.Next(111111111, 999999999).ToString() & "-" & r.Next(111111111, 999999999).ToString() & "-" & r.Next(111111111, 999999999).ToString() & "-" & r.Next(111111111, 999999999).ToString()
    'End Function
    Private Sub SaveData(ByVal AttributeID As Integer, ByVal AttributeValue As String, ByVal PageID As String)
        Try
            SqlHelper.ExecuteNonQuery(con, CommandType.Text, "insert into [dbo].[AttributeValue](PageAttributeID,PageID,AttributeValue) values(@PageAttributeID,@PageID,@AttributeValue)", {New SqlParameter("@PageAttributeID", AttributeID), New SqlParameter("@PageID", PageID), New SqlParameter("@AttributeValue", AttributeValue)})
            'GetProjectPagesTableAdapter.Fill(ProjectPagesDS.GetProjectPages, ProjectID)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmbProject_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProject.SelectedIndexChanged
        GetProjectPagesTableAdapter.Fill(ProjectPagesDS.GetProjectPages, cmbProject.SelectedValue)
        'DGProjectPages.DataSource = GetProjectPagesBindingSource
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        'GetProjectPagesTableAdapter.Fill(ProjectPagesDS.GetProjectPages, ProjectID)
    End Sub
    Private Sub DGProjectPages_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGProjectPages.DataError
        Me.Text = e.Exception.Message
    End Sub
    Private Sub chkDownloadHref_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDownloadHref.CheckedChanged
        chkNoHTML.Visible = chkDownloadHref.Checked
    End Sub
    Private Sub chkUpdate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUpdate.CheckedChanged
        If chkUpdate.Checked Then
            DGProjectPages.DataSource = GetProjectPagesBindingSource
            DGProjectPages.Visible = True
        End If

        Timer1.Enabled = chkUpdate.Checked And downloadStarted
    End Sub
    Dim CurrentDownloaded As String = ""
    Dim CurRet As Integer = 0
    Dim ProjectPID As String
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Try
            Dim ND As String = SqlHelper.ExecuteScalar(con, CommandType.Text, "SELECT rows FROM sysindexes WHERE name='PK_AttributeValue'").ToString

            If CurrentDownloaded = ND Or CurRet > 3 Then
                Dim startInfo As New ProcessStartInfo
                startInfo.FileName = Application.ExecutablePath
                startInfo.Arguments = ProjectID.ToString
                System.Diagnostics.Process.Start(startInfo)
                Application.Exit()
            Else
                CurRet = 0
                Timer2.Interval = 600000
                CurrentDownloaded = ND
            End If
            Me.Text = CurrentDownloaded
        Catch ex As Exception
            CurRet = CurRet + 1
            Timer2.Interval = 60000
            Me.Text = ex.Message
        End Try
    End Sub
End Class