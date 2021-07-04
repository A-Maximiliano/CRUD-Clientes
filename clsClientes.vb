Public Class clsClientes

#Region "Atributos"

    Private Id As Integer
    Private Nombre As String
    Private Apellido1 As String
    Private Apellido2 As String
    Private Cedula As String
    Private Telefono As String
    Private Email As String
    Private Direccion As String

#End Region

#Region "Constructores"
    ''' <summary>
    ''' Constructor para instanciar o inicializar todos los atributos de la clsClientes
    ''' </summary>
    ''' <param name="pid"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="papellido1"></param>
    ''' <param name="papellido2"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pemail"></param>
    ''' <param name="pdireccion"></param>
    Public Sub New(pid As Integer, pnombre As String, papellido1 As String, papellido2 As String, pcedula As String, ptelefono As String, pemail As String, pdireccion As String)
        Me.Id = pid
        Me.Nombre = pnombre
        Me.Apellido1 = papellido1
        Me.Apellido2 = papellido2
        Me.Cedula = pcedula
        Me.Telefono = ptelefono
        Me.Email = pemail
        Me.Direccion = pdireccion
    End Sub

    ''' <summary>
    ''' Constructor para instanciar o inicializar atributos de la clsClientes y Apellido2 = ""
    ''' </summary>
    ''' <param name="pid"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="papellido1"></param>
    ''' <param name="pcedula"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pemail"></param>
    ''' <param name="pdireccion"></param>
    Public Sub New(pid As Integer, pnombre As String, papellido1 As String, pcedula As String, ptelefono As String, pemail As String, pdireccion As String)
        Me.Id = pid
        Me.Nombre = pnombre
        Me.Apellido1 = papellido1
        Me.Apellido2 = ""
        Me.Cedula = pcedula
        Me.Telefono = ptelefono
        Me.Email = pemail
        Me.Direccion = pdireccion
    End Sub

#End Region

#Region "Propiedades"
    Public Property propId As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

    Public Property PropNombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property propApellido1 As String
        Get
            Return Apellido1
        End Get
        Set(value As String)
            Apellido1 = value
        End Set
    End Property

    Public Property propApellido2 As String
        Get
            Return Apellido2
        End Get
        Set(value As String)
            Apellido2 = value
        End Set
    End Property

    Public Property propCedula As String
        Get
            Return Cedula
        End Get
        Set(value As String)
            Cedula = value
        End Set
    End Property

    Public Property propTelefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property

    Public Property propEmail As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property

    Public Property propDireccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

#End Region

End Class
