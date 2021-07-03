Public Class clsClasificaciones

#Region "Atributos"

    Private IdClasificacion As Integer
    Private NombreClasificaion As String
#End Region

#Region "Propiedades"
    Public Property propIdClasificacion As Integer
        Get
            Return IdClasificacion
        End Get
        Set(value As Integer)
            IdClasificacion = value
        End Set
    End Property

    Public Property propNombreClasificaion As String
        Get
            Return NombreClasificaion
        End Get
        Set(value As String)
            NombreClasificaion = value
        End Set
    End Property
#End Region

End Class
