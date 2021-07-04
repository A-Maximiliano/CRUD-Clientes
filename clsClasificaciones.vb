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

    Public Function ObtenerInfoClasificacion() As String
        'Return "El id de clasificacion:  " & propIdClasificacion & "   corresponde al tipo: " & propNombreClasificaion

        Dim clasificacionNombre As String

        Select Case clasificacionNombre
            Case NombreClasificaion = "Platino"
                IdClasificacion = 1

            Case NombreClasificaion = "Oro"
                IdClasificacion = 2

            Case NombreClasificaion = "Plata"
                IdClasificacion = 3

            Case NombreClasificaion = "Bronce"
                IdClasificacion = 4

            Case Else

        End Select

    End Function
    'Public Sub Retirar(pRetiro As Double)
    '    If pRetiro > Me.saldo Then
    '        Me.saldo = 0
    '    Else
    '        Me.saldo -= pRetiro
    '    End If
    'End Sub

End Class
