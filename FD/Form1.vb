Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(txtURL.Text)
        WebBrowser2.Navigate(txtURLCHECK.Text)
        WebBrowser1.AllowNavigation = False
        WebBrowser2.ScriptErrorsSuppressed = True
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        AddHandler WebBrowser1.Document.Click, AddressOf getClickedElement '// Add .Click Event.
    End Sub
    Private Function GetTextAtPathFromURL(ByVal path As String, ByVal URL As String) As String
        Dim wb As New HtmlAgilityPack.HtmlWeb
        Dim doc = wb.Load(URL)
        Try
            Return doc.DocumentNode.SelectSingleNode(path).InnerHtml '.OuterHtml.Trim
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Private Sub getClickedElement(ByVal sender As Object, ByVal e As HtmlElementEventArgs)
        Dim element As HtmlElement = Me.WebBrowser1.Document.GetElementFromPoint(e.ClientMousePosition)

        Dim savedId = element.Id
        Dim uniqueId = Guid.NewGuid().ToString()
        element.Id = uniqueId

        Dim doc = New HtmlAgilityPack.HtmlDocument()
        doc.LoadHtml(element.Document.GetElementsByTagName("html")(0).OuterHtml)
        element.Id = savedId
        Dim node = doc.GetElementbyId(uniqueId)
        Dim f = node.XPath
        WebBrowser3.DocumentText = (GetTextAtPathFromURL(f, txtURLCHECK.Text))
        If txtFourmName.BackColor = Color.Red Then
            txtFourmName.Text = f
        ElseIf txtArticleTitle.BackColor = Color.Red Then
            txtArticleTitle.Text = f
        ElseIf txtArticleContent.BackColor = Color.Red Then
            txtArticleContent.Text = f
        End If
    End Sub

    Private Sub txtFourmName_GotFocus(sender As Object, e As System.EventArgs) Handles txtFourmName.GotFocus
        txtFourmName.BackColor = Color.Red
        txtArticleTitle.BackColor = Color.White
        txtArticleContent.BackColor = Color.White
    End Sub

    Private Sub txtArticleTitle_GotFocus(sender As Object, e As System.EventArgs) Handles txtArticleTitle.GotFocus
        txtFourmName.BackColor = Color.White
        txtArticleTitle.BackColor = Color.Red
        txtArticleContent.BackColor = Color.White
    End Sub

    Private Sub txtArticleContent_GotFocus(sender As Object, e As System.EventArgs) Handles txtArticleContent.GotFocus
        txtFourmName.BackColor = Color.White
        txtArticleTitle.BackColor = Color.White
        txtArticleContent.BackColor = Color.Red
    End Sub
    Private Sub BuildList()
        Dim bJ, bStart, bEnd As ULong
        Dim Res As String = ""
        bStart = ULong.Parse(txtFrom.Text)
        bEnd = ULong.Parse(txtTo.Text)
        For bJ = bStart To bEnd
            ExtractData(txtPattern.Text.Replace("*", bJ.ToString), bJ)
        Next
    End Sub
    Private Sub ExtractData(ByVal url As String, ByVal id As ULong)
        SaveData(GetTextAtPathFromURL(txtFourmName.Text, url).Trim, GetTextAtPathFromURL(txtArticleTitle.Text, url).Trim, GetTextAtPathFromURL(txtArticleContent.Text, url).Trim, id)
    End Sub
    Private Sub SaveData(ByVal FourmName As String, ByVal ArticleTitle As String, ByVal ArticleContent As String, ByVal id As ULong)

    End Sub
    Private Sub ButSave_Click(sender As System.Object, e As System.EventArgs) Handles ButSave.Click
        BuildList()
    End Sub
End Class
