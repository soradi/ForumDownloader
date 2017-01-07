Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text

Public Class NewProject


    Private Sub ButAdd_Click(sender As System.Object, e As System.EventArgs) Handles ButAdd.Click
        SqlHelper.ExecuteNonQuery(con, CommandType.Text, "INSERT INTO ProjectAttribute (ProjectID, AttributeID, XPath) VALUES(@ProjectID,@AttributeID,@XPath)", {New SqlParameter("@ProjectID", id), New SqlParameter("@AttributeID", cmbAttribute.SelectedValue), New SqlParameter("@XPath", txtXpath.Text)})
        Me.GetProjectAttributesTableAdapter.Fill(Me.FDDataSet.GetProjectAttributes, id)
        Try
            cmbAttribute.SelectedIndex = cmbAttribute.SelectedIndex + 1
        Catch ex As Exception
            cmbAttribute.SelectedIndex = 0
        End Try

    End Sub
    Dim con As String = ConfigurationManager.ConnectionStrings("FD.My.MySettings.FDConnectionString").ConnectionString
    Dim id As Integer
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        AddHandler WebBrowser1.Document.Click, AddressOf getClickedElement '// Add .Click Event.
        AddHandler WebBrowser1.Document.MouseMove, AddressOf getMovedElement '// Add .Click Event.
    End Sub
    Private Sub getMovedElement(ByVal sender As Object, ByVal e As HtmlElementEventArgs)
        Dim element As HtmlElement = Me.WebBrowser1.Document.GetElementFromPoint(e.ClientMousePosition)
        If Not tmpElement Is Nothing Then
            tmpElement.Style = tmpStyle
        End If
        tmpElement = element
        tmpStyle = element.Style
        element.Style = "outline-style: dotted;outline-color: #ff0000"

    End Sub
    Private Function GetTextAtPathFromURL(ByVal path As String, ByVal URL As String) As String
        Dim wb As New HtmlAgilityPack.HtmlWeb
        If chk1256.Checked Then
            wb.AutoDetectEncoding = False
            wb.OverrideEncoding = Encoding.GetEncoding(1256) ' "windows-1256"
        End If

        Dim doc = wb.Load(URL)
        Try
            Return doc.DocumentNode.SelectSingleNode(path).InnerHtml '.OuterHtml.Trim
        Catch ex As Exception
            Try
                txtXpath.Text = path.Replace("/tbody[1]", "")
                Return doc.DocumentNode.SelectSingleNode(path.Replace("/tbody[1]", "")).InnerHtml '.OuterHtml.Trim
            Catch ex2 As Exception
                Return ""
            End Try

        End Try
    End Function
    Dim tmpElement As HtmlElement
    Dim tmpStyle As String
    Private Sub getClickedElement(ByVal sender As Object, ByVal e As HtmlElementEventArgs)
        Dim element As HtmlElement = Me.WebBrowser1.Document.GetElementFromPoint(e.ClientMousePosition)
        'If Not tmpElement Is Nothing Then
        '    tmpElement.Style = tmpStyle
        'End If
        'tmpElement = element
        'tmpStyle = element.Style
        element.Style = "outline-style: solid;outline-color: #0000ff"

        Dim savedId = element.Id
        Dim uniqueId = Guid.NewGuid().ToString()
        element.Id = uniqueId
        Dim doc = New HtmlAgilityPack.HtmlDocument()
        doc.LoadHtml(element.Document.GetElementsByTagName("html")(0).OuterHtml)
        element.Id = savedId
        Dim node = doc.GetElementbyId(uniqueId)
        Dim f = node.XPath
        txtXpath.Text = f
        If chkUseCheck.Checked Then
            WebBrowser3.DocumentText = (GetTextAtPathFromURL(f, ActCheckURL))
        End If

    End Sub
    Dim ActURL, ActCheckURL As String
    Private Sub ButSave_Click(sender As System.Object, e As System.EventArgs) Handles ButSave.Click
        SqlHelper.ExecuteNonQuery(con, CommandType.Text, "INSERT INTO Project(ProjectName, URLPattern, PFrom, PTo,Tencod) VALUES (@ProjectName,@URLPattern,@PFrom,@PTo,@Tencod);", {New SqlParameter("@ProjectName", txtName.Text), New SqlParameter("@URLPattern", txtPattern.Text), New SqlParameter("@PFrom", txtFrom.Text), New SqlParameter("@PTo", txtTo.Text), New SqlParameter("@Tencod", chk1256.Checked)})
        id = Integer.Parse(SqlHelper.ExecuteScalar(con, CommandType.Text, "select max(id) from project"))
        Panel1.Visible = True
        ActURL = txtPattern.Text.Replace("*", txtURL.Text)
        WebBrowser1.Navigate(ActURL)
        If chkUseCheck.Checked Then
            ActCheckURL = txtPattern.Text.Replace("*", txtURLCHECK.Text)
            WebBrowser2.Navigate(ActCheckURL)
            WebBrowser2.ScriptErrorsSuppressed = True
        Else
            SplitContainer2.Panel2Collapsed = True
        End If
        WebBrowser1.AllowNavigation = False
        SplitContainer1.Panel2Collapsed = False
        SplitContainer3.Panel2Collapsed = False
        SplitContainer1.SplitterDistance = ButAddAttribute.Width + DGProjectAttributes.Width
    End Sub

    Private Sub NewProject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.AttributTableAdapter.Fill(Me.AttribDS.Attribut)
    End Sub

    Private Sub ButAddAttribute_Click(sender As System.Object, e As System.EventArgs) Handles ButAddAttribute.Click
        Dim s As String = InputBox("ادخل اسم الخاصية", "اسم الخاصية")
        SqlHelper.ExecuteNonQuery(con, CommandType.Text, "insert into [dbo].[Attribut](AttributName ) values (@AttributName )", {New SqlParameter("@AttributName", s)})
        Me.AttributTableAdapter.Fill(Me.AttribDS.Attribut)
    End Sub

    Private Sub chkUseCheck_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUseCheck.CheckedChanged
        lblchk.Visible = chkUseCheck.Checked
        txtURLCHECK.Visible = chkUseCheck.Checked
        chkHideChk.Visible = chkUseCheck.Checked
    End Sub

    Private Sub chkHideChk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHideChk.CheckedChanged
        SplitContainer2.Panel2Collapsed = chkHideChk.Checked
    End Sub
End Class