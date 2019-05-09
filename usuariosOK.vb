Imports System.Data.SqlClient
Imports System.Data
Imports System

Public Class usuariosOK


    Sub mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_usuario", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            Cerrar()
            datalistado.Columns(0).Width = 60
            datalistado.Columns(2).Width = 180
            datalistado.Columns(1).Visible = False
            datalistado.Columns(8).Visible = False

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim cmd As New SqlCommand

        If txtdni.Text <> "" Then
            Try

                abrir()
                cmd = New SqlCommand("insertar_usuario", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Nombre_y_Apellidos", txtnombres.Text)
                cmd.Parameters.AddWithValue("@DNI", txtdni.Text)
                cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@Login", txtlogin.Text)
                cmd.Parameters.AddWithValue("@Password", txtpasword.Text)
                cmd.Parameters.AddWithValue("@Vendedor", LBLVENDEDOR.Text)
                cmd.Parameters.AddWithValue("@Id_cargo", 0)
                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception : MsgBox(ex.Message)

            End Try




            '            @DNI  varchar(50),
            '@Telefono  nchar(9),
            '@Login varchar(50),
            '@Password  varchar(50),
            '@Vendedor  varchar(50),
            '@Id_cargo  int

            mostrar()
            Panelregistro.Visible = False

        Else
            MsgBox("ESCRIBA SU DNI")
        End If
    End Sub

    Private Sub txtdni_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub usuariosOK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Panelregistro.Visible = False

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Panelregistro.Visible = True
        'cmd.Parameters.AddWithValue("@Nombre_y_Apellidos", txtnombres.Text)
        'cmd.Parameters.AddWithValue("@DNI", txtdni.Text)
        'cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text)
        'cmd.Parameters.AddWithValue("@Login", txtlogin.Text)
        'cmd.Parameters.AddWithValue("@Password", txtpasword.Text)
        'cmd.Parameters.AddWithValue("@Vendedor", LBLVENDEDOR.Text)
        'cmd.Parameters.AddWithValue("@idusuario", datalistado.SelectedCells.Item(0).Value)
        txtnombres.Text = ""
        txtdni.Text = ""
        txttelefono.Text = ""
        txtpasword.Text = ""
        txtvendedor.Checked = False
        txtlogin.Text = ""

    End Sub

    Private Sub btnguardarcambios_Click(sender As Object, e As EventArgs) Handles btnguardarcambios.Click
        Dim cmd As New SqlCommand

        If txtdni.Text <> "" Then
            Try

                abrir()
                cmd = New SqlCommand("editar_usuario", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Nombre_y_Apellidos", txtnombres.Text)
                cmd.Parameters.AddWithValue("@DNI", txtdni.Text)
                cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@Login", txtlogin.Text)
                cmd.Parameters.AddWithValue("@Password", txtpasword.Text)
                cmd.Parameters.AddWithValue("@Vendedor", LBLVENDEDOR.Text)
                cmd.Parameters.AddWithValue("@idusuario", datalistado.SelectedCells.Item(1).Value)
                cmd.ExecuteNonQuery()
                Cerrar()
                mostrar()
                Panelregistro.Visible = False

            Catch ex As Exception : MsgBox(ex.Message)

            End Try




            '            @DNI  varchar(50),
            '@Telefono  nchar(9),
            '@Login varchar(50),
            '@Password  varchar(50),
            '@Vendedor  varchar(50),
            '@Id_cargo  int

            mostrar()
            Panelregistro.Visible = False

        Else
            MsgBox("ESCRIBA SU DNI")
        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkell.value = Not chkell.value
        End If
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try

            txtnombres.Text = datalistado.SelectedCells.Item(2).Value
            txtdni.Text = datalistado.SelectedCells.Item(3).Value
            txttelefono.Text = datalistado.SelectedCells.Item(4).Value
            txtlogin.Text = datalistado.SelectedCells.Item(5).Value
            txtpasword.Text = datalistado.SelectedCells.Item(6).Value
            LBLVENDEDOR.Text = datalistado.SelectedCells.Item(7).Value
            If LBLVENDEDOR.Text = "SI" Then
                txtvendedor.Checked = True
            ElseIf LBLVENDEDOR.Text = "NO" Then
                txtvendedor.Checked = False
            End If
            Panelregistro.Visible = True

        Catch ex As Exception : MsgBox(ex.Message)

        End Try



        'cmd.Parameters.AddWithValue("@Nombre_y_Apellidos", txtnombres.Text)
        'cmd.Parameters.AddWithValue("@DNI", txtdni.Text)
        'cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text)
        'cmd.Parameters.AddWithValue("@Login", txtlogin.Text)
        'cmd.Parameters.AddWithValue("@Password", txtpasword.Text)
        'cmd.Parameters.AddWithValue("@Vendedor", txtvendedor.Text)
    End Sub

    Private Sub txtvendedor_CheckedChanged(sender As Object, e As EventArgs) Handles txtvendedor.CheckedChanged
        If txtvendedor.Checked = True Then
            LBLVENDEDOR.Text = "SI"

        ElseIf txtvendedor.Checked = False Then
            LBLVENDEDOR.Text = "NO"
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Panelregistro.Visible = False

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("¿Realmente desea eliminar los resgistros seleccionados?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.OK Then

            For Each row As DataGridViewRow In datalistado.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                If marcado Then


                    Dim onekey As Integer = Convert.ToInt32(row.Cells("idusuario").Value)

                    abrir()
                    cmd = New SqlCommand("eliminar_usuario", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idusuario", onekey)

                    cmd.ExecuteNonQuery()
                    Cerrar()
                End If



            Next

            mostrar()

        Else
            MessageBox.Show("Cancelando la eliminacion de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class
