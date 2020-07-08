Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class ConexionCrud

    Public conexion As SqlConnection = New SqlConnection("Data Source=RK800\SQLEXPRESS;Initial Catalog=Ventas;Integrated Security=True")
    Public txt As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function consulta() As DataTable
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultaEstudiante", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarE As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function


    Function buscarIDCliente(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from factura.cliente " + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function GuardarE(ByVal idCliente As String, ByVal FechadeVenta As String, ByVal Precio As String, ByVal Cantidad As String, ByVal idVenta As Integer, ByVal idProducto As String) As String
        Dim mensaje As String = "Cliente Existe"
        Try
            comando = New SqlCommand("Insert into factura.cliente(idCliente,FechaVenta,Precio,Cantidad,idVenta,idProducto) values ('" & idCliente & "','" & FechadeVenta & "','" & Precio & "','" & Cantidad & "','" & idVenta & "','" & idProducto & " ')", conexion)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            mensaje = "No se inserto por: " + ex.ToString
        End Try
        Return mensaje
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

End Class