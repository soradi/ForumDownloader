Imports System.Data.SqlClient
Imports System.Configuration

Public Class ShowProject

    Private Sub ShowProject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectsDS.Project' table. You can move, or remove it, as needed.
        Me.ProjectTableAdapter.Fill(Me.ProjectsDS.Project)

    End Sub
    Private Sub LoadFast(TreeItems As IEnumerable(Of TreeItem))
        Dim getId As Func(Of TreeItem, Integer) = (Function(x) x.Id)
        Dim getParentId As Func(Of TreeItem, System.Nullable(Of Integer)) = (Function(x) x.ParentId)
        Dim getDisplayName As Func(Of TreeItem, String) = (Function(x) x.DisplayString)
        TreeViewFast1.LoadItems(TreeItems, getId, getParentId, getDisplayName)
        Application.DoEvents()
    End Sub
    Dim ht As New Hashtable
    Dim con As String = ConfigurationManager.ConnectionStrings("FD.My.MySettings.FDConnectionString").ConnectionString
    Private Sub cmbProjects_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProjects.SelectedIndexChanged
        Dim r As SqlDataReader = SqlHelper.ExecuteReader(con, CommandType.Text, "select * from (SELECT AttributeOrder,case when rtrim(ltrim(b1.Expr3))='' then'TEST' else rtrim(ltrim(b1.Expr3)) end as DisplayedData,convert(int, b1.ID) as ID, convert(int,isnull( v1.ChangTo,b1.ParentID) ) as ParentID FROM (SELECT s1.AttributeOrder, s1.PageID, s1.AttributeOrder AS Expr1, s1.AttributeValue AS Expr3, s1.id AS ID, ISNULL(s2.id, 0) AS ParentID FROM (SELECT AttributeValue.id, ProjectAttribute.AttributeOrder, AttributeValue.PageID, AttributeValue.AttributeValue FROM ProjectAttribute INNER JOIN AttributeValue ON ProjectAttribute.id = AttributeValue.PageAttributeID WHERE (ProjectAttribute.ProjectID = @ProjectID)) AS s1 LEFT OUTER JOIN (SELECT AttributeValue_1.id, ProjectAttribute_1.AttributeOrder, AttributeValue_1.PageID, AttributeValue_1.AttributeValue FROM ProjectAttribute AS ProjectAttribute_1 INNER JOIN AttributeValue AS AttributeValue_1 ON ProjectAttribute_1.id = AttributeValue_1.PageAttributeID WHERE (ProjectAttribute_1.ProjectID = @ProjectID)) AS s2 ON s1.PageID = s2.PageID AND s1.AttributeOrder = s2.AttributeOrder + 1) AS b1 LEFT OUTER JOIN (SELECT n1.ID AS ChangTo, n2.id AS ChangeFrom FROM (SELECT MIN(AttributeValue_2.id) AS ID, AttributeValue_2.AttributeValue FROM AttributeValue AS AttributeValue_2 INNER JOIN ProjectAttribute AS ProjectAttribute_4 ON AttributeValue_2.PageAttributeID = ProjectAttribute_4.id WHERE (ProjectAttribute_4.ProjectID = @ProjectID) AND (ProjectAttribute_4.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_3 WHERE (ProjectID = @ProjectID))) GROUP BY AttributeValue_2.AttributeValue) AS n1 INNER JOIN (SELECT AttributeValue_1.id, AttributeValue_1.AttributeValue FROM AttributeValue AS AttributeValue_1 INNER JOIN ProjectAttribute AS ProjectAttribute_2 ON AttributeValue_1.PageAttributeID = ProjectAttribute_2.id WHERE (ProjectAttribute_2.ProjectID = @ProjectID) AND (ProjectAttribute_2.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_1 WHERE (ProjectID = @ProjectID)))) AS n2 ON n1.AttributeValue = n2.AttributeValue) AS v1 ON b1.ParentID = v1.ChangeFrom) as dd where id in (select parentid from (SELECT AttributeOrder,case when rtrim(ltrim(b1.Expr3))='' then'TEST' else rtrim(ltrim(b1.Expr3)) end as DisplayedData,convert(int, b1.ID) as ID, convert(int,isnull( v1.ChangTo,b1.ParentID) ) as ParentID FROM (SELECT s1.AttributeOrder, s1.PageID, s1.AttributeOrder AS Expr1, s1.AttributeValue AS Expr3, s1.id AS ID, ISNULL(s2.id, 0) AS ParentID FROM (SELECT AttributeValue.id, ProjectAttribute.AttributeOrder, AttributeValue.PageID, AttributeValue.AttributeValue FROM ProjectAttribute INNER JOIN AttributeValue ON ProjectAttribute.id = AttributeValue.PageAttributeID WHERE (ProjectAttribute.ProjectID = @ProjectID)) AS s1 LEFT OUTER JOIN (SELECT AttributeValue_1.id, ProjectAttribute_1.AttributeOrder, AttributeValue_1.PageID, AttributeValue_1.AttributeValue FROM ProjectAttribute AS ProjectAttribute_1 INNER JOIN AttributeValue AS AttributeValue_1 ON ProjectAttribute_1.id = AttributeValue_1.PageAttributeID WHERE (ProjectAttribute_1.ProjectID = @ProjectID)) AS s2 ON s1.PageID = s2.PageID AND s1.AttributeOrder = s2.AttributeOrder + 1) AS b1 LEFT OUTER JOIN (SELECT n1.ID AS ChangTo, n2.id AS ChangeFrom FROM (SELECT MIN(AttributeValue_2.id) AS ID, AttributeValue_2.AttributeValue FROM AttributeValue AS AttributeValue_2 INNER JOIN ProjectAttribute AS ProjectAttribute_4 ON AttributeValue_2.PageAttributeID = ProjectAttribute_4.id WHERE (ProjectAttribute_4.ProjectID = @ProjectID) AND (ProjectAttribute_4.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_3 WHERE (ProjectID = @ProjectID))) GROUP BY AttributeValue_2.AttributeValue) AS n1 INNER JOIN (SELECT AttributeValue_1.id, AttributeValue_1.AttributeValue FROM AttributeValue AS AttributeValue_1 INNER JOIN ProjectAttribute AS ProjectAttribute_2 ON AttributeValue_1.PageAttributeID = ProjectAttribute_2.id WHERE (ProjectAttribute_2.ProjectID = @ProjectID) AND (ProjectAttribute_2.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_1 WHERE (ProjectID = @ProjectID)))) AS n2 ON n1.AttributeValue = n2.AttributeValue) AS v1 ON b1.ParentID = v1.ChangeFrom) as dd)", {New SqlParameter("@ProjectID", cmbProjects.SelectedValue)})
        Dim AllData As New List(Of TreeItem)
        Dim MaxOrder As Integer = Integer.Parse(SqlHelper.ExecuteScalar(con, CommandType.Text, "SELECT max([AttributeOrder]) FROM [ProjectAttribute] where projectid =@ProjectID", {New SqlParameter("@ProjectID", cmbProjects.SelectedValue)}))
        While r.Read
            If r("AttributeOrder") < MaxOrder Then
                If r("id") <> r("ParentID") And r("ParentID") <> 0 Then
                    AllData.Add(New TreeItem(r("id"), r("ParentID"), ClearHTML(r("DisplayedData"))))
                Else
                    AllData.Add(New TreeItem(r("id"), Nothing, r("DisplayedData")))
                End If
            End If

        End While
        r.Close()
        Dim r2 As SqlDataReader = SqlHelper.ExecuteReader(con, CommandType.Text, "select * from (SELECT AttributeOrder,case when rtrim(ltrim(b1.Expr3))='' then'TEST' else rtrim(ltrim(b1.Expr3)) end as DisplayedData,convert(int, b1.ID) as ID, convert(int,isnull( v1.ChangTo,b1.ParentID) ) as ParentID FROM (SELECT s1.AttributeOrder, s1.PageID, s1.AttributeOrder AS Expr1, s1.AttributeValue AS Expr3, s1.id AS ID, ISNULL(s2.id, 0) AS ParentID FROM (SELECT AttributeValue.id, ProjectAttribute.AttributeOrder, AttributeValue.PageID, AttributeValue.AttributeValue FROM ProjectAttribute INNER JOIN AttributeValue ON ProjectAttribute.id = AttributeValue.PageAttributeID WHERE (ProjectAttribute.ProjectID = @ProjectID)) AS s1 LEFT OUTER JOIN (SELECT AttributeValue_1.id, ProjectAttribute_1.AttributeOrder, AttributeValue_1.PageID, AttributeValue_1.AttributeValue FROM ProjectAttribute AS ProjectAttribute_1 INNER JOIN AttributeValue AS AttributeValue_1 ON ProjectAttribute_1.id = AttributeValue_1.PageAttributeID WHERE (ProjectAttribute_1.ProjectID = @ProjectID)) AS s2 ON s1.PageID = s2.PageID AND s1.AttributeOrder = s2.AttributeOrder + 1) AS b1 LEFT OUTER JOIN (SELECT n1.ID AS ChangTo, n2.id AS ChangeFrom FROM (SELECT MIN(AttributeValue_2.id) AS ID, AttributeValue_2.AttributeValue FROM AttributeValue AS AttributeValue_2 INNER JOIN ProjectAttribute AS ProjectAttribute_4 ON AttributeValue_2.PageAttributeID = ProjectAttribute_4.id WHERE (ProjectAttribute_4.ProjectID = @ProjectID) AND (ProjectAttribute_4.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_3 WHERE (ProjectID = @ProjectID))) GROUP BY AttributeValue_2.AttributeValue) AS n1 INNER JOIN (SELECT AttributeValue_1.id, AttributeValue_1.AttributeValue FROM AttributeValue AS AttributeValue_1 INNER JOIN ProjectAttribute AS ProjectAttribute_2 ON AttributeValue_1.PageAttributeID = ProjectAttribute_2.id WHERE (ProjectAttribute_2.ProjectID = @ProjectID) AND (ProjectAttribute_2.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_1 WHERE (ProjectID = @ProjectID)))) AS n2 ON n1.AttributeValue = n2.AttributeValue) AS v1 ON b1.ParentID = v1.ChangeFrom) as dd where AttributeOrder=" & MaxOrder.ToString, {New SqlParameter("@ProjectID", cmbProjects.SelectedValue)})
        While r2.Read
            ht.Add(r2("ParentID"), r2("DisplayedData"))
        End While
        r2.Close()
        LoadFast(AllData)
    End Sub
    Public Shared Function stripTags(ByVal html As String) As String
        Dim htmldoc As New HtmlAgilityPack.HtmlDocument
        htmldoc.LoadHtml(html) '.Replace("</p>", "</p>" & New String(Environment.NewLine, 2)).Replace("<br/>", Environment.NewLine))
        If htmldoc.DocumentNode.InnerText.Trim <> "" Then
            Return htmldoc.DocumentNode.InnerText
        Else
            Return html
        End If
    End Function

    Private Function ClearHTML(ByVal a As String) As String
        If a.Contains("<") Then
            Return stripTags(a)
        End If
        Return a
    End Function
    Private Function CorrectFilesPath(ByVal s As String) As String
        Dim t As String = s.Replace("files/", Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\files\")
        Dim ar As String = ""
        If chkArab.Checked Then ar = "dir='rtl'"
        Return "<div " & ar & ">" & t.Replace("imgs/", Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\imgs\") & "</div>"
    End Function

    Private Sub TreeViewFast1_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewFast1.AfterSelect
        Try
            If ht.ContainsKey(Integer.Parse(e.Node.Name)) Then
                WebBrowser1.DocumentText = CorrectFilesPath(ht(Integer.Parse(e.Node.Name)))
            End If
        Catch ex As Exception

        End Try
    End Sub
  
    Private Sub ButSearch_Click(sender As System.Object, e As System.EventArgs) Handles ButSearch.Click
        Dim r As SqlDataReader = SqlHelper.ExecuteReader(con, CommandType.Text, "SELECT AttributeOrder, DisplayedData, ID, ParentID FROM (SELECT b1.AttributeOrder, CASE WHEN rtrim(ltrim(b1.Expr3)) = '' THEN 'TEST' ELSE rtrim(ltrim(b1.Expr3)) END AS DisplayedData, CONVERT(int, b1.ID) AS ID, CONVERT(int, ISNULL(v1.ChangTo, b1.ParentID)) AS ParentID FROM (SELECT s1.AttributeOrder, s1.PageID, s1.AttributeOrder AS Expr1, s1.AttributeValue AS Expr3, s1.id AS ID, ISNULL(s2.id, 0) AS ParentID FROM ( 												SELECT AttributeValue.id, ProjectAttribute.AttributeOrder, AttributeValue.PageID, AttributeValue.AttributeValue FROM ProjectAttribute INNER JOIN AttributeValue ON ProjectAttribute.id = AttributeValue.PageAttributeID WHERE (ProjectAttribute.ProjectID = @ProjectID) and AttributeValue.pageid in (select pageid from AttributeValue where AttributeValue like '%'+@SearchTerm+'%') 																		 																		) AS s1 LEFT OUTER JOIN ( 																		 SELECT AttributeValue_1.id, ProjectAttribute_1.AttributeOrder, AttributeValue_1.PageID, AttributeValue_1.AttributeValue FROM ProjectAttribute AS ProjectAttribute_1 INNER JOIN AttributeValue AS AttributeValue_1 ON ProjectAttribute_1.id = AttributeValue_1.PageAttributeID WHERE (ProjectAttribute_1.ProjectID = @ProjectID)and AttributeValue_1.pageid in (select pageid from AttributeValue where AttributeValue like '%'+@SearchTerm+'%') 																			 ) AS s2 ON s1.PageID = s2.PageID AND s1.AttributeOrder = s2.AttributeOrder + 1) AS b1 LEFT OUTER JOIN (SELECT n1.ID AS ChangTo, n2.id AS ChangeFrom FROM (SELECT MIN(AttributeValue_2.id) AS ID, AttributeValue_2.AttributeValue FROM AttributeValue AS AttributeValue_2 INNER JOIN ProjectAttribute AS ProjectAttribute_4 ON AttributeValue_2.PageAttributeID = ProjectAttribute_4.id WHERE (ProjectAttribute_4.ProjectID = @ProjectID) and AttributeValue_2.pageid in (select pageid from AttributeValue where AttributeValue like '%'+@SearchTerm+'%') AND (ProjectAttribute_4.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_3 WHERE (ProjectID = @ProjectID))) GROUP BY AttributeValue_2.AttributeValue) AS n1 INNER JOIN (SELECT AttributeValue_1.id, AttributeValue_1.AttributeValue FROM AttributeValue AS AttributeValue_1 INNER JOIN ProjectAttribute AS ProjectAttribute_2 ON AttributeValue_1.PageAttributeID = ProjectAttribute_2.id WHERE (ProjectAttribute_2.ProjectID = @ProjectID) and AttributeValue_1.pageid in (select pageid from AttributeValue where AttributeValue like '%'+@SearchTerm+'%') AND (ProjectAttribute_2.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_1 WHERE (ProjectID = @ProjectID) ))) AS n2 ON n1.AttributeValue = n2.AttributeValue) AS v1 ON b1.ParentID = v1.ChangeFrom) AS dd WHERE (ID IN (SELECT ParentID FROM (SELECT b1.AttributeOrder, CASE WHEN rtrim(ltrim(b1.Expr3)) = '' THEN 'TEST' ELSE rtrim(ltrim(b1.Expr3)) END AS DisplayedData, CONVERT(int, b1.ID) AS ID, CONVERT(int, ISNULL(v1.ChangTo, b1.ParentID)) AS ParentID FROM (SELECT s1.AttributeOrder, s1.PageID, s1.AttributeOrder AS Expr1, s1.AttributeValue AS Expr3, s1.id AS ID, ISNULL(s2.id, 0) AS ParentID FROM (SELECT AttributeValue.id, ProjectAttribute.AttributeOrder, AttributeValue.PageID, AttributeValue.AttributeValue FROM ProjectAttribute INNER JOIN AttributeValue ON ProjectAttribute.id = AttributeValue.PageAttributeID WHERE (ProjectAttribute.ProjectID = @ProjectID) and AttributeValue.pageid in (select pageid from AttributeValue where AttributeValue like '%'+@SearchTerm+'%')) AS s1 LEFT OUTER JOIN (SELECT AttributeValue_1.id, ProjectAttribute_1.AttributeOrder, AttributeValue_1.PageID, AttributeValue_1.AttributeValue FROM ProjectAttribute AS ProjectAttribute_1 INNER JOIN AttributeValue AS AttributeValue_1 ON ProjectAttribute_1.id = AttributeValue_1.PageAttributeID WHERE (ProjectAttribute_1.ProjectID = @ProjectID) and AttributeValue_1.pageid in (select pageid from AttributeValue where AttributeValue like '%'+@SearchTerm+'%')) AS s2 ON s1.PageID = s2.PageID AND s1.AttributeOrder = s2.AttributeOrder + 1) AS b1 LEFT OUTER JOIN (SELECT n1.ID AS ChangTo, n2.id AS ChangeFrom FROM (SELECT MIN(AttributeValue_2.id) AS ID, AttributeValue_2.AttributeValue FROM AttributeValue AS AttributeValue_2 INNER JOIN ProjectAttribute AS ProjectAttribute_4 ON AttributeValue_2.PageAttributeID = ProjectAttribute_4.id WHERE (ProjectAttribute_4.ProjectID = @ProjectID) and AttributeValue_2.pageid in (select pageid from AttributeValue where AttributeValue like '%'+@SearchTerm+'%') AND (ProjectAttribute_4.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_3 WHERE (ProjectID = @ProjectID))) GROUP BY AttributeValue_2.AttributeValue) AS n1 INNER JOIN (SELECT AttributeValue_1.id, AttributeValue_1.AttributeValue FROM AttributeValue AS AttributeValue_1 INNER JOIN ProjectAttribute AS ProjectAttribute_2 ON AttributeValue_1.PageAttributeID = ProjectAttribute_2.id WHERE (ProjectAttribute_2.ProjectID = @ProjectID) and AttributeValue_1.pageid in (select pageid from AttributeValue where AttributeValue like '%'+@SearchTerm+'%') AND (ProjectAttribute_2.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_1 WHERE (ProjectID = @ProjectID)))) AS n2 ON n1.AttributeValue = n2.AttributeValue) AS v1 ON b1.ParentID = v1.ChangeFrom) AS dd))", {New SqlParameter("@ProjectID", cmbProjects.SelectedValue), New SqlParameter("@SearchTerm", txtSearch.Text)})
        Dim AllData As New List(Of TreeItem)
        ht.Clear()
        Dim MaxOrder As Integer = Integer.Parse(SqlHelper.ExecuteScalar(con, CommandType.Text, "SELECT max([AttributeOrder]) FROM [ProjectAttribute] where projectid =@ProjectID", {New SqlParameter("@ProjectID", cmbProjects.SelectedValue)}))
        While r.Read
            If r("AttributeOrder") < MaxOrder Then
                If r("id") <> r("ParentID") And r("ParentID") <> 0 Then
                    AllData.Add(New TreeItem(r("id"), r("ParentID"), ClearHTML(r("DisplayedData"))))
                Else
                    AllData.Add(New TreeItem(r("id"), Nothing, r("DisplayedData")))
                End If
            End If

        End While
        r.Close()
        Dim r2 As SqlDataReader = SqlHelper.ExecuteReader(con, CommandType.Text, "select * from (SELECT AttributeOrder,case when rtrim(ltrim(b1.Expr3))='' then'TEST' else rtrim(ltrim(b1.Expr3)) end as DisplayedData,convert(int, b1.ID) as ID, convert(int,isnull( v1.ChangTo,b1.ParentID) ) as ParentID FROM (SELECT s1.AttributeOrder, s1.PageID, s1.AttributeOrder AS Expr1, s1.AttributeValue AS Expr3, s1.id AS ID, ISNULL(s2.id, 0) AS ParentID FROM (SELECT AttributeValue.id, ProjectAttribute.AttributeOrder, AttributeValue.PageID, AttributeValue.AttributeValue FROM ProjectAttribute INNER JOIN AttributeValue ON ProjectAttribute.id = AttributeValue.PageAttributeID WHERE (ProjectAttribute.ProjectID = @ProjectID)) AS s1 LEFT OUTER JOIN (SELECT AttributeValue_1.id, ProjectAttribute_1.AttributeOrder, AttributeValue_1.PageID, AttributeValue_1.AttributeValue FROM ProjectAttribute AS ProjectAttribute_1 INNER JOIN AttributeValue AS AttributeValue_1 ON ProjectAttribute_1.id = AttributeValue_1.PageAttributeID WHERE (ProjectAttribute_1.ProjectID = @ProjectID)) AS s2 ON s1.PageID = s2.PageID AND s1.AttributeOrder = s2.AttributeOrder + 1) AS b1 LEFT OUTER JOIN (SELECT n1.ID AS ChangTo, n2.id AS ChangeFrom FROM (SELECT MIN(AttributeValue_2.id) AS ID, AttributeValue_2.AttributeValue FROM AttributeValue AS AttributeValue_2 INNER JOIN ProjectAttribute AS ProjectAttribute_4 ON AttributeValue_2.PageAttributeID = ProjectAttribute_4.id WHERE (ProjectAttribute_4.ProjectID = @ProjectID) AND (ProjectAttribute_4.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_3 WHERE (ProjectID = @ProjectID))) GROUP BY AttributeValue_2.AttributeValue) AS n1 INNER JOIN (SELECT AttributeValue_1.id, AttributeValue_1.AttributeValue FROM AttributeValue AS AttributeValue_1 INNER JOIN ProjectAttribute AS ProjectAttribute_2 ON AttributeValue_1.PageAttributeID = ProjectAttribute_2.id WHERE (ProjectAttribute_2.ProjectID = @ProjectID) AND (ProjectAttribute_2.AttributeOrder < (SELECT MAX(AttributeOrder) - 1 AS Expr1 FROM ProjectAttribute AS ProjectAttribute_1 WHERE (ProjectID = @ProjectID)))) AS n2 ON n1.AttributeValue = n2.AttributeValue) AS v1 ON b1.ParentID = v1.ChangeFrom) as dd where AttributeOrder=" & MaxOrder.ToString, {New SqlParameter("@ProjectID", cmbProjects.SelectedValue)})
        While r2.Read
            ht.Add(r2("ParentID"), r2("DisplayedData"))
        End While
        r2.Close()
        LoadFast(AllData)
    End Sub
End Class