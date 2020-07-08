Public Class frmVentas

    Dim conexion As ConexionCrud = New ConexionCrud
    Dim dt As New DataTable
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        frmCliente.Show()
    End Sub

    Private Sub mostrarDatos()
        Try
            dt = conexion.consulta
            If dt.Rows.Count <> 0 Then
                dtgVentas.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgVentas.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Borrar()
        txtidCliente.Enabled = True
        txtCantidad.Clear()
        txtFechaVenta.Clear()
        txtidProducto.Clear()
        txtidVenta.Clear()
        txtPrecio.Clear()
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        conexion.conexion.Close()
    End Sub
    Private Sub DataGridVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentas.CellContentClick
        Try
            Dim DGVentas As DataGridViewRow = Me.dtgVentas.Rows(e.RowIndex)
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            txtidCliente.Enabled = False
            llenarCampos(e)
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (conexion.clienteValidar(txtidCliente.Text) = False) Then
            MsgBox(conexion.GuardarE(txtidCliente.Text, txtFechaVenta.Text, txtPrecio.Text, txtCantidad.Text, txtidVenta.Text, txtidProducto.Text))
            conexion.conexion.Close()
            mostrarDatos()
        Else
            MsgBox("Cliente ya existe", MessageBoxIcon.Error)
            conexion.conexion.Close()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminar("factura.cliente", "codigo=" + txtidCliente.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarDatos()
                Borrar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim modificar As String =
            "Fecha de Venta='" + txtFechaVenta.Text + "', Precio='" + txtPrecio.Text + "', Cantidad='" + txtCantidad.Text + "', IDVenta='" + txtidVenta.Text + "', IDProducto='" + txtidProducto.Text + "'"
            If (conexion.modificar("factura.cliente", modificar, " idCliente=" + txtidCliente.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Borrar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar la tabla")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        'Rellena los campos en los textbox, asignando de acuerdo a la posicion que se encuentra en el datagrid
        Try
            Dim dtg As DataGridViewRow = dtgVentas.Rows(e.RowIndex)
            txtidCliente.Text = dtg.Cells(0).Value.ToString()
            txtFechaVenta.Text = dtg.Cells(1).Value.ToString()
            txtPrecio.Text = dtg.Cells(2).Value.ToString()
            txtCantidad.Text = dtg.Cells(3).Value.ToString()
            txtidVenta.Text = dtg.Cells(4).Value.ToString()
            txtPrecio.Text = dtg.Cells(6).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Borrar()
    End Sub
End Class


