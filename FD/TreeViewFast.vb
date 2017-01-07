
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Public Class TreeViewFast
    Inherits TreeView
    Private ReadOnly _treeNodes As New Dictionary(Of Integer, TreeNode)()

    ''' <summary>
    ''' Load the TreeView with items.
    ''' </summary>
    ''' <typeparam name="T">Item type</typeparam>
    ''' <param name="items">Collection of items</param>
    ''' <param name="getId">Function to parse Id value from item object</param>
    ''' <param name="getParentId">Function to parse parentId value from item object</param>
    ''' <param name="getDisplayName">Function to parse display name value from item object. This is used as node text.</param>
    Public Sub LoadItems(Of T)(items As IEnumerable(Of T), getId As Func(Of T, Integer), getParentId As Func(Of T, System.Nullable(Of Integer)), getDisplayName As Func(Of T, String))
        ' Clear view and internal dictionary
        Nodes.Clear()
        _treeNodes.Clear()

        ' Load internal dictionary with nodes
        For Each item In items
            Dim id = getId(item)
            Dim displayName = getDisplayName(item)
            Dim node = New TreeNode() With { _
             .Name = id.ToString(), _
             .Text = displayName, _
             .Tag = item _
            }
            _treeNodes.Add(getId(item), node)
        Next

        ' Create hierarchy and load into view
        For Each id In _treeNodes.Keys
            Dim node = GetNode(id)
            Dim obj = DirectCast(node.Tag, T)
            Dim parentId = getParentId(obj)

            If parentId.HasValue Then
                Dim parentNode = GetNode(parentId.Value)
                parentNode.Nodes.Add(node)
            Else
                Nodes.Add(node)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Get a handle to the object collection.
    ''' This is convenient if you want to search the object collection.
    ''' </summary>
    Public Function GetItems(Of T)() As IQueryable(Of T)
        Return _treeNodes.Values.[Select](Function(x) DirectCast(x.Tag, T)).AsQueryable()
    End Function

    ''' <summary>
    ''' Retrieve TreeNode by Id.
    ''' Useful when you want to select a specific node.
    ''' </summary>
    ''' <param name="id">Item id</param>
    Public Function GetNode(id As Integer) As TreeNode
        Return _treeNodes(id)
    End Function

    ''' <summary>
    ''' Retrieve item object by Id.
    ''' Useful when you want to get hold of object for reading or further manipulating.
    ''' </summary>
    ''' <typeparam name="T">Item type</typeparam>
    ''' <param name="id">Item id</param>
    ''' <returns>Item object</returns>
    Public Function GetItem(Of T)(id As Integer) As T
        Return DirectCast(GetNode(id).Tag, T)
    End Function


    ''' <summary>
    ''' Get parent item.
    ''' Will return NULL if item is at top level.
    ''' </summary>
    ''' <typeparam name="T">Item type</typeparam>
    ''' <param name="id">Item id</param>
    ''' <returns>Item object</returns>
    Public Function GetParent(Of T As Class)(id As Integer) As T
        Dim parentNode = GetNode(id).Parent
        Return If(parentNode Is Nothing, Nothing, DirectCast(Parent.Tag, T))
    End Function

    ''' <summary>
    ''' Retrieve descendants to specified item.
    ''' </summary>
    ''' <typeparam name="T">Item type</typeparam>
    ''' <param name="id">Item id</param>
    ''' <param name="deepLimit">Number of generations to traverse down. 1 means only direct children. Null means no limit.</param>
    ''' <returns>List of item objects</returns>
    Public Function GetDescendants(Of T)(id As Integer, Optional deepLimit As System.Nullable(Of Integer) = Nothing) As List(Of T)
        Dim node = GetNode(id)
        Dim enumerator = node.Nodes.GetEnumerator()
        Dim items = New List(Of T)()

        If deepLimit.HasValue AndAlso deepLimit.Value <= 0 Then
            Return items
        End If

        While enumerator.MoveNext()
            ' Add child
            Dim childNode = DirectCast(enumerator.Current, TreeNode)
            Dim childItem = DirectCast(childNode.Tag, T)
            items.Add(childItem)

            ' If requested add grandchildren recursively
            Dim childDeepLimit = If(deepLimit.HasValue, deepLimit.Value - 1, DirectCast(Nothing, System.Nullable(Of Integer)))
            If Not deepLimit.HasValue OrElse childDeepLimit > 0 Then
                Dim childId = Integer.Parse(childNode.Name)
                Dim descendants = GetDescendants(Of T)(childId, childDeepLimit)
                items.AddRange(descendants)
            End If
        End While
        Return items
    End Function
End Class
