Public Class Task

    ' Fields
    Private _Id As Integer
    Private _Titulo As String
    Private _Completado As Boolean

    ' Propiedades

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return _Titulo
        End Get
        Set(ByVal value As String)
            _Titulo = value
        End Set
    End Property

    Public Property Completado() As Boolean
        Get
            Return _Completado
        End Get
        Set(ByVal value As Boolean)
            _Completado = value
        End Set
    End Property

End Class
