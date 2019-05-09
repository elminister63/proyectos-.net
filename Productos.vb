Imports System.Data.SqlClient
Imports System.Data
Imports System
Public Class Productos

    Private Sub TGUARDAR_Click(sender As Object, e As EventArgs) Handles TGUARDAR.Click
        Dim CMD As SqlCommand
        Try
            abrir()

            CMD = New SqlCommand("insertar_Producto", conexion)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)

            CMD.Parameters.AddWithValue("@Precio_de_compra", txtcosto.Text)
            CMD.Parameters.AddWithValue("@Precio_de_venta", TXTPRECIODEVENTA2.Text)
            CMD.Parameters.AddWithValue("@Codigo", txtcodigodebarras.Text)

            If txtigv.Checked = True Then
                CMD.Parameters.AddWithValue("@Impuesto", txtnumeroigv.Text)
            End If
            If txtigv.Checked = False Then
                CMD.Parameters.AddWithValue("@Impuesto", 0)
            End If



            CMD.Parameters.AddWithValue("@Precio_mayoreo", txtpreciomayoreo.Text)



            If porunidad.Checked = True Then txtse_vende_a.Text = "Unidad"
            If agranel.Checked = True Then txtse_vende_a.Text = "Granel"

            CMD.Parameters.AddWithValue("@Se_vende_a", txtse_vende_a.Text)
            CMD.Parameters.AddWithValue("@Linea", txtlinea.Text)
            If si_utiliza_inventario.Checked = True Then
                CMD.Parameters.AddWithValue("@Usa_inventarios", "SI")
                CMD.Parameters.AddWithValue("@Stock_minimo", txtstockminimo.Text)
                CMD.Parameters.AddWithValue("@Stock", txtstock2.Text)

                If No_aplica_fecha.Checked = True Then
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")
                End If

                If No_aplica_fecha.Checked = False Then
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", txtfechaoka.Text)
                End If
            End If
            If si_utiliza_inventario.Checked = False Then
                CMD.Parameters.AddWithValue("@Usa_inventarios", "NO")
                CMD.Parameters.AddWithValue("@Stock_minimo", 0)
                CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")
                CMD.Parameters.AddWithValue("@Stock", "Ilimitado")

            End If

            CMD.ExecuteNonQuery()
            Listar()
            PANELDEPARTAMENTO.Visible = False
            Try
                'REGISTRADO.ShowDialog()
            Catch ex As Exception

            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Producto1", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt

            'contar()

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()

        datalistado.Columns(1).Visible = False
        datalistado.Columns(0).Width = 80
        datalistado.Columns(2).Width = 100
        datalistado.Columns(3).Width = 100
        datalistado.Columns(4).Width = 250
        datalistado.Columns(5).Width = 75
        datalistado.Columns(6).Visible = False
        datalistado.Columns(7).Width = 90
        datalistado.Columns(8).Width = 90
        datalistado.Columns(9).Visible = False
        datalistado.Columns(10).Width = 90
        datalistado.Columns(11).Width = 90
        datalistado.Columns(12).Width = 70
        datalistado.Columns(13).Width = 75


        Me.datalistado.EnableHeadersVisualStyles = False

        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
        FontStyle.Bold)

        ' asignar estilo al grid
        Me.datalistado.ColumnHeadersDefaultCellStyle = styCabeceras


    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PANELDEPARTAMENTO.Visible = False
        Listar()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PANELDEPARTAMENTO.Visible = True

    End Sub
End Class