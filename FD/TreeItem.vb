Public Class TreeItem
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set(value As Integer)
            m_Id = value
        End Set
    End Property
    Private m_Id As Integer
    Public Property ParentId() As System.Nullable(Of Integer)
        Get
            Return m_ParentId
        End Get
        Set(value As System.Nullable(Of Integer))
            m_ParentId = value
        End Set
    End Property
    Private m_ParentId As System.Nullable(Of Integer)
    Public Property DisplayString() As String
        Get
            Return m_DisplayString
        End Get
        Set(value As String)
            m_DisplayString = value
        End Set
    End Property
    Private m_DisplayString As String

    Sub New(ByVal id As Integer, ParentID As System.Nullable(Of Integer), DisplayString As String)
        m_Id = id
        m_ParentId = ParentID
        m_DisplayString = DisplayString

    End Sub
End Class
