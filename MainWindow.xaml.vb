Class MainWindow

#Region "Declaraciones globales"
    Dim vListaClientes As New List(Of clsClientes)
    Dim vAsignarClasificacion As clsClasificaciones = New clsClasificaciones()
    Dim vRegistrarClientes As clsClientes
#End Region

    'Evento al seleccionar un cliente del DataGrid
    Private Sub dtgClientes_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)

        Try

            If dtgClientes.SelectedItem IsNot Nothing Then
                btnGuardar.Content = "MODIFICAR"
                Dim vEstudianteSelect As clsClientes = TryCast(dtgClientes.SelectedItem, clsClientes)
                txtNombre.Text = vEstudianteSelect.propNombre
                txtApellido1.Text = vEstudianteSelect.propApellido1
                txtApellido2.Text = vEstudianteSelect.propApellido2
                txtCedula.Text = vEstudianteSelect.propCedula
                txtTelefono.Text = vEstudianteSelect.propTelefono
                txtEmail.Text = vEstudianteSelect.propEmail
                txtDireccion.Text = vEstudianteSelect.propDireccion
                txtbID.Text = vEstudianteSelect.propId.ToString()

            End If

        Catch ex As Exception
            MessageBox.Show("Error al seleccionar el cliente. Error: " & ex.Message)
        End Try

    End Sub

    'Metodo para guardar los clientes con los valores asignados por parametro
    Public Sub GuardarClientes(pNombre As String, pApellido1 As String, pApellido2 As String, pCedula As String, pTelefono As String, pEmail As String, pDireccion As String)

        Try
            ' Atributos dependiendo de los construcotres creados en mi clase clsClientes
            If txtApellido2.Text = Nothing Then

                vRegistrarClientes = New clsClientes(vListaClientes.Count + 1, txtNombre.Text, txtApellido1.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text)
            Else

                vRegistrarClientes = New clsClientes(vListaClientes.Count + 1, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text)
            End If

            'Agrego atributos al objeto con los valores recibidos por parametro
            vRegistrarClientes.PropNombre = pNombre
            vRegistrarClientes.propApellido1 = pApellido1
            vRegistrarClientes.propApellido2 = pApellido2
            vRegistrarClientes.propCedula = pCedula
            vRegistrarClientes.propTelefono = pTelefono
            vRegistrarClientes.propEmail = pEmail
            vRegistrarClientes.propDireccion = pDireccion
            vRegistrarClientes.propId = vListaClientes.Count + 1
            vAsignarClasificacion.propNombreClasificaion = cmbClasificacion.Text

            'Agrego los clientes a la lista
            vListaClientes.Add(vRegistrarClientes)
            'Agrego los clientes al datagrid
            dtgClientes.Items.Add(vRegistrarClientes)

            MessageBox.Show("Cliente registrado exitosamente, clasificacion: " & vAsignarClasificacion.propNombreClasificaion)
        Catch ex As Exception
            MessageBox.Show("Error al registrar el cliente. Error: " & ex.Message)
        End Try
    End Sub

    'Evento del boton al hacer click
    Private Sub btnGuardar_Click(sender As Object, e As RoutedEventArgs) Handles btnGuardar.Click

        'Validacion para guardar o modificar al cliente dependiendo de si selecciono un registro del datagrid
        If dtgClientes.SelectedItem Is Nothing Then
            GuardarClientes(txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text)
            Limpiar()
        Else
            ModificarClientes(Convert.ToInt32(txtbID.Text), txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text)
            Limpiar()
        End If

    End Sub

    'Metodo para modificar los clientes con los valores asignados por parametro
    Private Sub ModificarClientes(pId As Integer, pNombre As String, pApellido1 As String, pApellido2 As String, pCedula As String, pTelefono As String, pEmail As String, pDireccion As String)

        'Limpia los registros
        dtgClientes.Items.Clear()
        'Cambia el texto del boton
        btnGuardar.Content = "GUARDAR"
        Try
            For Each itemLista In vListaClientes

                If itemLista.propId = pId Then
                    itemLista.PropNombre = pNombre
                    itemLista.propApellido1 = pApellido1
                    itemLista.propApellido2 = pApellido2
                    itemLista.propCedula = pCedula
                    itemLista.propTelefono = pTelefono
                    itemLista.propEmail = pEmail
                    itemLista.propDireccion = pDireccion
                End If
                dtgClientes.Items.Add(itemLista)
                'Asigna el valor de la calsificacion segun la seleccion en el comboBox
                vAsignarClasificacion.propNombreClasificaion = cmbClasificacion.Text
            Next
            MessageBox.Show("El cliente fue modificado correctamente, clasificacion: " & vAsignarClasificacion.propNombreClasificaion)
            ' MessageBox.Show("El cliente fue modificado correctamente, clasificacion: " & vAsignarClasificacion.ObtenerInfoClasificacion)

        Catch ex As Exception
            MessageBox.Show("Error al modificar el cliente. Error: " & ex.Message)
        End Try

    End Sub

    'Evento del boton eliminar contenido en el datagrid
    Private Sub btnEliminarCliente_Click(sender As Object, e As RoutedEventArgs)

        Try

            Dim vEliminarSeleccion As clsClientes = TryCast(dtgClientes.SelectedItem, clsClientes)
            'Remueve el item del data grid
            dtgClientes.Items.Remove(vEliminarSeleccion)
            'Remueve el item de la lista
            vListaClientes.Remove(vEliminarSeleccion)
            'Cambia el texto del boton
            btnGuardar.Content = "GUARDAR"
            'Metodo para limpiar los textBox
            Limpiar()

            MessageBox.Show("El cliente fue eliminado correctamente")
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el cliente. Detalle: " + ex.Message)
        End Try

    End Sub

    'Metodo para limpiar los campos textBox
    Private Sub Limpiar()

        txtNombre.Text = ""
        txtApellido1.Text = ""
        txtApellido2.Text = ""
        txtCedula.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtDireccion.Text = ""

    End Sub

    'Evento del boton nuevo para limpiar los campos textbox
    Private Sub btnNuevo_Click(sender As Object, e As RoutedEventArgs) Handles btnNuevo.Click
        Limpiar()
        btnGuardar.Content = "GUARDAR"
    End Sub

End Class
