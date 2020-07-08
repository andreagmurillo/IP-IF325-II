Imports System.Data
Imports System.Data.SqlClient

Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= RK800\SQLEXPRESS;Initial Catalog=Tienda; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable

    Sub llenarDataGridVentas(ByVal dgv As DataGridView)
        Try
            da = New SqlDataAdapter("Select * from Center.empleados", conexion)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se pudo llenar por que: " + ex.ToString)
        End Try
    End Sub


    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Esta Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar a SQL")
        Finally
            conexion.Close()
        End Try
    End Sub

    Sub abrirConexion()
        Try
            conexion = New SqlConnection("Data Source=RK800\SQLEXPRESS;Initial Catalog=Tiendas;Integrated Security=True")
            conexion.Open()
            MessageBox.Show("CONECTADO")
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir" + ex.ToString)
            conexion.Close()
        End Try
    End Sub


    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function clienteValidar(ByVal idCliente As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from factura.cliente where codigo='" + idCliente + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function

End Class