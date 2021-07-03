Class MainWindow

    Dim vListaClientes As New List(Of clsClientes)
    Dim vAsignarClasificacion As clsClasificaciones = New clsClasificaciones()
    Dim vRegistrarClientes As clsClientes
    'Dim vRegistrarClientes As clsClientes = New clsClientes()

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

    Public Sub GuardarClientes(pNombre As String, pApellido1 As String, pApellido2 As String, pCedula As String, pTelefono As String, pEmail As String, pDireccion As String)
        'Public Sub GuardarClientes()
        Try
            vAsignarClasificacion = New clsClasificaciones()
            ' vRegistrarClientes = New clsClientes()
            If txtApellido2.Text = Nothing Then
                vRegistrarClientes = New clsClientes(Convert.ToInt32(txtbID.Text), txtNombre.Text, txtApellido1.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text)
            Else
                vRegistrarClientes = New clsClientes(Convert.ToInt32(txtbID.Text), txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text)
            End If


            vRegistrarClientes.PropNombre = pNombre
            vRegistrarClientes.propApellido1 = pApellido1
            vRegistrarClientes.propApellido2 = pApellido2
            vRegistrarClientes.propCedula = pCedula
            vRegistrarClientes.propTelefono = pTelefono
            vRegistrarClientes.propEmail = pEmail
            vRegistrarClientes.propDireccion = pDireccion
            vRegistrarClientes.propId = vListaClientes.Count + 1

            ' vAsignarClasificacion.propIdClasificacion = cmbClasificacion.SelectedIndex
            vAsignarClasificacion.propNombreClasificaion = cmbClasificacion.Text

            vListaClientes.Add(vRegistrarClientes)

            dtgClientes.Items.Add(vRegistrarClientes)

            MessageBox.Show("Cliente registrado exitosamente, clasificacion: " & vAsignarClasificacion.propNombreClasificaion) ' debo solucionar el metodo modificar no jala la seleccion del combo box
        Catch ex As Exception
            MessageBox.Show("Error al registrar el cliente. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As RoutedEventArgs) Handles btnGuardar.Click

        If dtgClientes.SelectedItem Is Nothing Then
            GuardarClientes(txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text)
            Limpiar()
        Else
            'agrgar bandera para cambiar leyenda del boton guardar a modificar

            ModificarClientes(Convert.ToInt32(txtbID.Text), txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text)
            Limpiar()
        End If

    End Sub

    Private Sub ModificarClientes(pId As Integer, pNombre As String, pApellido1 As String, pApellido2 As String, pCedula As String, pTelefono As String, pEmail As String, pDireccion As String)

        dtgClientes.Items.Clear()
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
            Next
            MessageBox.Show("El cliente fue modificado correctamente, clasificacion: " & vAsignarClasificacion.propNombreClasificaion)

        Catch ex As Exception
            MessageBox.Show("Error al modificar el cliente. Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As RoutedEventArgs)

        Try
            Dim vEliminarSeleccion As clsClientes = TryCast(dtgClientes.SelectedItem, clsClientes)

            dtgClientes.Items.Remove(vEliminarSeleccion)

            vListaClientes.Remove(vEliminarSeleccion)

            btnGuardar.Content = "GUARDAR"
            Limpiar()

            MessageBox.Show("El cliente fue eliminado correctamente")
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el cliente. Detalle: " + ex.Message)
        End Try

    End Sub

    Private Sub Limpiar()

        'txtbID.Text = ""
        txtNombre.Text = ""
        txtApellido1.Text = ""
        txtApellido2.Text = ""
        txtCedula.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtDireccion.Text = ""

    End Sub

End Class
