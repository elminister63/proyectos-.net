Imports System.Data.SqlClient
Imports System.Data
Imports System
Public Class CONTROL_TOTAL
    Sub cargarusuarios()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("validar_usuario", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@login", txtlogin.Text)
            da.SelectCommand.Parameters.AddWithValue("@password", txtpaswor.Text)
            da.Fill(dt)
            datalistado.DataSource = dt
            Cerrar()
          

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub contar()
        Dim x As Integer
        x = datalistado.Rows.Count
        txtcontador.Text = CStr(x)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cargarusuarios()
            contar()
            If txtcontador.Text > 0 Then
                Me.Hide()
                usuariosOK.ShowDialog()
                Me.Hide()
            Else
                MsgBox("Datos incorrectos")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click



    End Sub

    Private Sub txtlogin_Click(sender As Object, e As EventArgs) Handles txtlogin.Click
        txtlogin.Text = ""
        txtlogin.Focus()

    End Sub

    Private Sub txtlogin_TextChanged(sender As Object, e As EventArgs) Handles txtlogin.TextChanged

    End Sub

    Private Sub txtpaswor_Click(sender As Object, e As EventArgs) Handles txtpaswor.Click
        txtpaswor.Text = ""
        txtpaswor.Focus()

    End Sub

    Private Sub txtpaswor_TextChanged(sender As Object, e As EventArgs) Handles txtpaswor.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End

    End Sub
End Class