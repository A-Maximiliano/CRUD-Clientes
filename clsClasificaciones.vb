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

    ''' <summary>
    ''' Metodo para obtener la informacion de los atributos de la clsClasificaciones
    ''' </summary>
    ''' <returns> Retorna el IdClasificacion y NombreClasificaion </returns>
    Public Function ObtenerInfoClasificacion() As String

        Return "El id de clasificacion:  " & propIdClasificacion & "   corresponde al tipo: " & propNombreClasificaion

    End Function

End Class
