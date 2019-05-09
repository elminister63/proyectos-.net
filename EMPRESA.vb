


Imports System.Data.SqlClient
Imports System.Data
Imports System

Public Class EMPRESA
    Dim DTc As New DataTable
    Dim DTe As New DataTable
    Dim DTt As New DataTable

    Sub cargarcontratista()
        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    DA = New SqlDataAdapter("SELECT * FROM Contratista", conexion)
        '    DA.Fill(DTc)
        '    txtcontratista.DisplayMember = "Contratista"
        '    txtcontratista.ValueMember = "Id_contratista"
        '    txtcontratista.DataSource = DTc
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub

    Sub cargarpresentaciones()
        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    Dim PROCECIMIENTO As String
        '    PROCECIMIENTO = "SET NOCOUNT ON SELECT DISTINCT Presentacion FROM Producto1"


        '    DA = New SqlDataAdapter(PROCECIMIENTO, conexion)
        '    DA.Fill(DTe)
        '    ''txtpresentacion.DisplayMember = "Presentacion"
        '    'txtpresentacion.ValueMember = "Presentacion"
        '    txtpresentacion.DataSource = DTe
        '    '            	
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Sub cargartipo()
        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    Dim PROCECIMIENTO As String
        '    PROCECIMIENTO = "SET NOCOUNT ON SELECT DISTINCT TIPO_DE_CARTA_FIANZA FROM TABLACARTAFIANZAS"


        '    DA = New SqlDataAdapter(PROCECIMIENTO, conexion)
        '    DA.Fill(DTt)
        '    TXTTIPOCARTA.DisplayMember = "TIPO_DE_CARTA_FIANZA"
        '    TXTTIPOCARTA.ValueMember = "TIPO_DE_CARTA_FIANZA"
        '    TXTTIPOCARTA.DataSource = DTt
        '    '            	
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Sub cargaremitida()
        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    Dim PROCECIMIENTO As String
        '    PROCECIMIENTO = "SET NOCOUNT ON SELECT DISTINCT EMITIDA FROM TABLACARTAFIANZAS"


        '    DA = New SqlDataAdapter(PROCECIMIENTO, conexion)
        '    DA.Fill(DTe)
        '    txtemitida.DisplayMember = "EMITIDA"
        '    'txtemitida.ValueMember = "EMITIDA"
        '    txtemitida.DataSource = DTe
        '    '            	
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Private Sub contar()
        Dim x As Integer
        x = datalistado.Rows.Count
        txtcontador.Text = CStr(x)
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Sub mostrar_cajas_por_empresa()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_cajas_por_empresa_sin_ip", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@empresa", datalistado.SelectedCells.Item(2).Value)

            da.Fill(dt)
            datalistadocajas.DataSource = dt
            Cerrar()
            datalistadocajas.Columns(0).Visible = False
            datalistadocajas.Columns(1).Visible = False
            datalistadocajas.Columns(2).Width = 300
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Empresa", conexion)
            da.Fill(dt)

            datalistado.DataSource = dt
            contar()
            'datalistado.Columns(1).Visible = False
            datalistado.Columns(2).Width = 170
            datalistado.Columns(5).Width = 75
            datalistado.Columns(3).Width = 75
            datalistado.Columns(4).Width = 70
            datalistado.Columns(9).Visible = False
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()

        CType(datalistado.Columns("Logo"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom

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
    'Private Sub ZoomToImage(ByVal sender As Object ByVal e As EventArgs) Handles Button4.Click


    '    For Each column As DataGridViewImageColumn _
    '        In datalistado.Columns
    '        column.ImageLayout = DataGridViewImageCellLayout.Zoom
    '        column.Description = "Zoomed image layout"
    '    Next
    'End Sub
    Sub Listargiros()
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("MOSTRAR_TABLAGIRO", conexion)
        '    da.Fill(dt)
        '    datalistadogiros.DataSource = dt
        '    contar()
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Sub LIMPIAR()

        txtempresa.Text = ""
        txtidpresentacion.Text = ""


    End Sub

    'Private Sub txtEspecialidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEspecialidad.TextChanged
    '    Dim dt As New DataTable
    '    Dim da As New SqlDataAdapter("BuscarEspec", conexion)
    '    Try
    '        abrir()
    '        da.SelectCommand.CommandType = 4
    '        da.SelectCommand.Parameters.AddWithValue("@letra", txtEspecialidad.Text)
    '        da.Fill(dt)
    '        datalistado.DataSource = dt

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Sub REGISTRAR_HISTORIAL()
        'Dim cmd As New SqlCommand
        'If txtcontador.Text <> "" Then
        '    Try

        '        abrir()
        '        cmd = New SqlCommand("insertar_Historial", conexion)
        '        cmd.CommandType = 4
        '        '               
        '        cmd.Parameters.AddWithValue("@idcontratista", txtidcontratista.Text)
        '        cmd.Parameters.AddWithValue("@idcarta", datalistado.SelectedCells.Item(1).Value)
        '        cmd.Parameters.AddWithValue("@estado", "INICIAL")
        '        cmd.Parameters.AddWithValue("@situacion ", txtsituacion.Text)
        '        cmd.Parameters.AddWithValue("@observaciones", txtobservaciones.Text)
        '        cmd.Parameters.AddWithValue("@fechaobservacion", txtfechadeobservacion.Text)
        '        cmd.Parameters.AddWithValue("@Nro_de_Renovacion", "NINGUNO")

        '        cmd.Parameters.Add("@MENSAJE", SqlDbType.VarChar, 100).Direction = 2
        '        cmd.ExecuteNonQuery()
        '        Dim MENSAJE As String = cmd.Parameters("@MENSAJE").Value.ToString
        '        MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



        '        Listar()

        '        LIMPIAR()
        '    Catch ex As Exception : MsgBox(ex.Message)
        '    End Try
        '    Cerrar()
        'Else
        '    MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar/ El aula ya fue designada un docente", "Colegio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub







    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
       
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        Try
            If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
                chkcell.Value = Not chkcell.Value
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        txtmsbox.Text = "Se ha activado la eliminacion de registros"
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_unidad_de_medida").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_unidades", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@id_unidad", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next
                Call LIMPIAR()
                Call Listar()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Panel2.Visible = False

        MenuStrip2.Visible = True
        datalistado.Enabled = True


        GUARDARCAMBIOS.Visible = False



    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Listar()

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click

        Listar()


        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = True
        Next
        txtmsbox.Text = "Se ha activado seleccionar todas las filas"
        datalistado.Columns.Item("Eliminar").Visible = True

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Listar()


        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = False
        Next
        txtmsbox.Text = "Se ha habilitado la deseleccion de filas"

        datalistado.Columns.Item("Eliminar").Visible = False

    End Sub

    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Panel2.Visible = True
        GUARDARCAMBIOS.Visible = True
        datalistado.Enabled = False


        MenuStrip2.Visible = False

        datalistado.Enabled = False
    End Sub
    Sub cargar_cajas_assignadas_a_pc()
        'Dim DA As SqlDataAdapter
        'Dim dtcaja As New DataTable
        'Try
        '    abrir()
        '    DA = New SqlDataAdapter("mostrar_cajas_por_empresa", conexion)
        '    DA.SelectCommand.CommandType = 4
        '    DA.SelectCommand.Parameters.AddWithValue("@empresa", MENUPRINCIPAL.cbxempresa.Text)
        '    DA.SelectCommand.Parameters.AddWithValue("@ip", CONTROL_TOTAL.TXTIP2.Text)
        '    DA.Fill(dtcaja)
        '    txtcaja.DisplayMember = "Descripcion"
        '    txtcaja.ValueMember = "Id_Caja"
        '    txtcaja.DataSource = dtcaja



        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Private Sub EMPRESA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        Panel2.Visible = False

        MenuStrip2.Visible = True
        datalistado.Enabled = True
        cargarcontratista()
        cargarpresentaciones()
        cargartipo()
        LIMPIAR()
        Listar()
        Listargiros()
        GUARDARCAMBIOS.Visible = False


    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub txtEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs)







    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    'Private Sub txtdocente_SelectedIndexChanged(sender As Object, e As EventArgs)


    '    With txtiddocentesss
    '        .DataSource = DTd
    '        .DisplayMember = "Id_docente"
    '        .ValueMember = "Id_docente"

    '    End With

    'End Sub









    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcontratista_SelectedIndexChanged(sender As Object, e As EventArgs)
        'With txtidcontratista
        '    .DataSource = DTc
        '    .DisplayMember = "Id_contratista"
        '    .ValueMember = "Id_contratista"

        'End With
    End Sub



    Private Sub btnactualizar_Click(sender As Object, e As EventArgs)
        cargarcontratista()

    End Sub

    Private Sub MarcacionManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcacionManualToolStripMenuItem.Click
        datalistado.Columns.Item("Eliminar").Visible = True

    End Sub





  



    Private Sub GuardarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevoRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub GuardarCambiosToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function LVENDER() As Object
        Throw New NotImplementedException
    End Function

    Private Sub datalistado_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles datalistado.CellContextMenuStripNeeded

    End Sub
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        'If CONTROL_TOTAL.txtadmin.Text = "SI" Then

        txtidempresa.Text = datalistado.SelectedCells.Item(6).Value
        If datalistado.SelectedCells.Item(9).Value = "LECTORA" Then
            TXTCON_LECTORA.Checked = True
        End If
        If datalistado.SelectedCells.Item(9).Value = "TECLADO" Then
            txtteclado.Checked = True
        End If
        mostrar_cajas_por_empresa()
        MenuStrip9.Visible = True

        GUARDAR.Visible = False


        Try
            Imagenproducto.BackgroundImage = Nothing
            Dim b() As Byte = datalistado.SelectedCells.Item(1).Value
            Dim ms As New IO.MemoryStream(b)
            Imagenproducto.Image = Image.FromStream(ms)
            Imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage
            txtempresa.Text = datalistado.SelectedCells.Item(2).Value

            TXTTRABAJASCONIMPUESTOS.Text = datalistado.SelectedCells.Item(9).Value
            If TXTTRABAJASCONIMPUESTOS.Text = "SI" Then
                si.Checked = True

            End If
            If TXTTRABAJASCONIMPUESTOS.Text = "NO" Then
                no.Checked = True

            End If
            txtporcentaje.Text = datalistado.SelectedCells.Item(7).Value
            txtimpuesto.Text = datalistado.SelectedCells.Item(8).Value
            txtmoneda.Text = datalistado.SelectedCells.Item(4).Value
           

        Catch ex As Exception
        End Try
        Panel2.Visible = True
        'ElseIf CONTROL_TOTAL.txtadmin.Text = "NO" Then
        'MsgBox("NO TIENES PERMISOS de Admin,Contacta al Administrador")

        'End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand
        If txtempresa.Text <> "" Then
            Try

                abrir()
                cmd = New SqlCommand("insertar_Empresa", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@Nombre_Empresa", txtempresa.Text)

                Dim ms As New IO.MemoryStream()
                If Not Imagenproducto.Image Is Nothing Then
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                Else
                    Imagenproducto.Image = Nothing
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                End If
                cmd.Parameters.AddWithValue("@logo", ms.GetBuffer)


                cmd.ExecuteNonQuery()





                Panel2.Visible = False

                MenuStrip2.Visible = True
                datalistado.Enabled = True

                GUARDARCAMBIOS.Visible = False


                Listar()

            Catch ex As Exception : MsgBox(ex.Message)
            End Try

            Cerrar()

            Panel2.Visible = False




        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Panel2.Visible = False

        MenuStrip2.Visible = True
        datalistado.Enabled = True


        GUARDARCAMBIOS.Visible = False

    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)
        If dlg.ShowDialog() = DialogResult.OK Then
            Imagenproducto.BackgroundImage = Nothing
            Imagenproducto.Image = New Bitmap(dlg.FileName)
            Imagenproducto.SizeMode = PictureBoxSizeMode.Zoom

        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs)
        Imagenproducto.Image = Nothing
        Imagenproducto.BackgroundImage = Nothing
        Imagenproducto.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
   
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        'If CONTROL_TOTAL.txtadmin.Text = "SI" Then

        si.Checked = True
        Panelimpuestos.Visible = True

        txtidempresa.Text = ""

        MenuStrip9.Visible = False

        txtcaja.Text = "NOMBRE DE CAJA"
        GUARDAR.Visible = True
        GUARDARCAMBIOS.Visible = False
        Panel2.Visible = True
        txtempresa.Text = "Nombre de TU Empresa"
        txtcantidadporunidadmedida.Text = ""
        'ElseIf CONTROL_TOTAL.txtadmin.Text = "NO" Then
        'MsgBox("NO TIENES PERMISOS de Admin,Contacta al Administrador")

        'End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)

    End Sub

  

    Private Sub si_CheckedChanged(sender As Object, e As EventArgs) Handles si.CheckedChanged
        If si.Checked = True Then
            Panelimpuestos.Visible = True
        ElseIf no.Checked = True Then
            Panelimpuestos.Visible = False
        End If
    End Sub

    Private Sub no_CheckedChanged(sender As Object, e As EventArgs) Handles no.CheckedChanged
      
    End Sub
    Sub ingresar_empresa()
        Dim cmd As New SqlCommand
        If txtempresa.Text <> "" Then
            Try
                If no.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "NO"

                End If
                If si.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "SI"

                End If
                abrir()
                cmd = New SqlCommand("insertar_Empresa", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@Nombre_Empresa", txtempresa.Text)
                cmd.Parameters.AddWithValue("@Impuesto", txtimpuesto.Text)
                cmd.Parameters.AddWithValue("@Porcentaje_impuesto", txtporcentaje.Text)
                cmd.Parameters.AddWithValue("@Moneda", txtmoneda.Text)
                cmd.Parameters.AddWithValue("@Saldo", 0)
                cmd.Parameters.AddWithValue("@Trabajas_con_impuestos", TXTTRABAJASCONIMPUESTOS.Text)
              
                Dim ms As New IO.MemoryStream()
                If Not Imagenproducto.Image Is Nothing Then
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                Else
                    Imagenproducto.Image = Nothing
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                End If

                cmd.Parameters.AddWithValue("@logo", ms.GetBuffer)
                If TXTCON_LECTORA.Checked = True Then
                    cmd.Parameters.AddWithValue("@Modo_de_busqueda", "LECTORA")
                End If
                If txtteclado.Checked = True Then
                    cmd.Parameters.AddWithValue("@Modo_de_busqueda", "TECLADO")
                End If


                cmd.ExecuteNonQuery()

                Cerrar()





            Catch ex As Exception : MsgBox(ex.Message)

            End Try





        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub mostrar_empresas_nuevas()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("select * from Empresa  order by Id_empresa Desc", conexion)
            da.Fill(dt)
            datalistado_empresas_nuevas.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub






























    Private Sub ToolStripMenuItem4_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If dlg.ShowDialog() = DialogResult.OK Then

            Imagenproducto.BackgroundImage = Nothing
            Imagenproducto.Image = New Bitmap(dlg.FileName)
            Imagenproducto.SizeMode = PictureBoxSizeMode.Zoom

        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click_2(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Imagenproducto.Image = Nothing
        Imagenproducto.BackgroundImage = Nothing
        Imagenproducto.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtmsbox.Text = "Se ha activado la eliminacion de registros"
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.SelectedRows                  
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_empresa").Value)
                    Try
                        abrir()
                        cmd = New SqlCommand("eliminar_Empresa", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@id_Empresa", onekey)
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception : MsgBox(ex.Message)
                    End Try
                    Cerrar()
                Next
                LIMPIAR()
                Listar()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        'ElseIf CONTROL_TOTAL.txtadmin.Text = "NO" Then
        'MsgBox("NO TIENES PERMISOS de Admin,Contacta al Administrador")

        'End If
    End Sub

    Private Sub MenuStrip9_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        Panel3.Visible = True

        GUARDARCAMBIOS.Visible = False

    End Sub

    Private Sub ToolStripMenuItem2_Click_2(sender As Object, e As EventArgs) Handles VOLVEROK.Click
        Panel3.Visible = False

    End Sub

    Private Sub txtporcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtporcentaje.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtporcentaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtporcentaje.SelectedIndexChanged

    End Sub

    Private Sub txtempresa_Click(sender As Object, e As EventArgs) Handles txtempresa.Click
        txtempresa.Text = ""
        txtempresa.Focus()
    End Sub

    Private Sub txtempresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtempresa.KeyPress

    End Sub

    Private Sub txtempresa_TextChanged(sender As Object, e As EventArgs) Handles txtempresa.TextChanged
        'If txtempresa.Text = "" Then
        '    txtempresa.Text = "NOMBRE DE TU EMPRESA"
        'End If




    End Sub

  

    Private Sub datalistado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datalistado.KeyPress

    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GUARDARCAMBIOS.Click
        Dim cmd As New SqlCommand
        If txtcaja.Text <> "" Then
            Try
                
             
                abrir()
                cmd = New SqlCommand("editar_caja", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text)
                cmd.Parameters.AddWithValue("@idcaja", datalistadocajas.SelectedCells.Item(1).Value)
                


                cmd.ExecuteNonQuery()

                Cerrar()
              
                Panel3.Visible = False
                mostrar_cajas_por_empresa()

            Catch ex As Exception
                ': MsgBox(ex.Message)
            End Try



        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Seguir_agregando_cajas_Click(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand
        If txtcaja.Text <> "" Then
            Try
                If no.Checked = True Then
                    txtimpuesto.Text = "NINGUNO"
                    txtporcentaje.Text = 0
                End If


                abrir()
                cmd = New SqlCommand("Insertar_caja", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text)
                cmd.Parameters.AddWithValue("@saldo", 0)
                cmd.Parameters.AddWithValue("@Id_empresa", txtidempresa.Text)
                cmd.Parameters.AddWithValue("@PC_Asignada", "NINGUNA")
                cmd.Parameters.AddWithValue("@IP", "NINGUNA")


                cmd.ExecuteNonQuery()

                Cerrar()

                mostrar_cajas_por_empresa()


                Panel3.Visible = False

            Catch ex As Exception
                ': MsgBox(ex.Message)
            End Try



        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub datalistadocajas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadocajas.CellContentClick

    End Sub

    Private Sub datalistadocajas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadocajas.CellDoubleClick
        Try
            txtcaja.Text = datalistadocajas.SelectedCells.Item(2).Value
            TXTPC2.Text = datalistadocajas.SelectedCells.Item(4).Value
            TXTIP2.Text = datalistadocajas.SelectedCells.Item(4).Value
            GUARDAR.Visible = False
            GUARDARCAMBIOS.Visible = True
            Panel3.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles MenuStrip9.Click
        Dim cmd As New SqlCommand
        If txtempresa.Text <> "" Then
            Try
                If no.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "NO"

                End If
                If si.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "SI"

                End If
                abrir()
                cmd = New SqlCommand("editar_Empresa", conexion)
                cmd.CommandType = 4

                cmd.Parameters.AddWithValue("@Id_empresa", datalistado.SelectedCells.Item(6).Value)
                cmd.Parameters.AddWithValue("@Nombre_Empresa", txtempresa.Text)
                cmd.Parameters.AddWithValue("@Impuesto", txtimpuesto.Text)
                cmd.Parameters.AddWithValue("@Porcentaje_impuesto", txtporcentaje.Text)
                cmd.Parameters.AddWithValue("@Moneda", txtmoneda.Text)
                cmd.Parameters.AddWithValue("@Trabajas_con_impuestos", TXTTRABAJASCONIMPUESTOS.Text)
                '                @logo as image,
                '@Impuesto varchar(50),
                '@Porcentaje_impuesto numeric(18,2),
                '@Moneda varchar(50),
                '@Saldo numeric(18,2)
                Dim ms As New IO.MemoryStream()
                If Not Imagenproducto.Image Is Nothing Then
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                Else
                    Imagenproducto.Image = Nothing
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                End If
                cmd.Parameters.AddWithValue("@logo", ms.GetBuffer)

                If TXTCON_LECTORA.Checked = True Then
                    cmd.Parameters.AddWithValue("@Modo_de_busqueda", "LECTORA")
                End If
                If txtteclado.Checked = True Then
                    cmd.Parameters.AddWithValue("@Modo_de_busqueda", "TECLADO")
                End If

                cmd.ExecuteNonQuery()

                Cerrar()
                Listar()
                Panel2.Visible = False






            Catch ex As Exception : MsgBox(ex.Message)
            End Try





        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Panel2.Visible = False
        Listar()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        txtmsbox.Text = "Se ha activado la eliminacion de registros"
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistadocajas.SelectedRows
                    'Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    'datalistado.Rows.Remove(datalistado.CurrentRow)


                    'If datalistado.SelectedCells.Item(6).Value Then
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_Caja").Value)

                    Try

                        abrir()
                        cmd = New SqlCommand("eliminar_caja", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@id", onekey)

                        cmd.ExecuteNonQuery()


                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    Cerrar()
                    'End If

                Next

                Call mostrar_cajas_por_empresa()




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand
        If txtcaja.Text <> "" Then
            Try


                abrir()
                cmd = New SqlCommand("editar_caja_asignada_a_pc", conexion)
                cmd.CommandType = 4



                cmd.Parameters.AddWithValue("@idcaja", datalistadocajas.SelectedCells.Item(1).Value)
                cmd.Parameters.AddWithValue("@PC_Asignada", TXTPC2.Text)
                cmd.Parameters.AddWithValue("@IP", TXTIP2.Text)


                cmd.ExecuteNonQuery()

                Cerrar()

                Panel3.Visible = False
                mostrar_cajas_por_empresa()

            Catch ex As Exception
                ': MsgBox(ex.Message)
            End Try



        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub contarcajas()
        Dim x As Integer
        x = datalistadocajas.Rows.Count
        txtcontadorcajas.Text = CStr(x)
    End Sub
    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        Dim cmd As New SqlCommand
        If txtcaja.Text <> "" Then
            Try
                If no.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "NO"
                End If
                If si.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "SI"
                End If
                ingresar_empresa()
                mostrar_empresas_nuevas()
                abrir()
                cmd = New SqlCommand("Insertar_caja", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text)
                cmd.Parameters.AddWithValue("@saldo", 0)
                cmd.Parameters.AddWithValue("@Id_empresa", datalistado_empresas_nuevas.SelectedCells.Item(1).Value)
                cmd.Parameters.AddWithValue("@PC_Asignada", TXTPC2.Text)
                cmd.Parameters.AddWithValue("@IP", TXTIP2.Text)
                cmd.ExecuteNonQuery()
                Cerrar()
                mostrar_empresas_nuevas()
                txtidempresa.Text = datalistado_empresas_nuevas.SelectedCells.Item(1).Value
                mostrar_cajas_por_empresa()



                GUARDAR.Visible = False
                GUARDARCAMBIOS.Visible = False

                Panel3.Visible = False
                Listar()


            Catch ex As Exception
                ': MsgBox(ex.Message)
            End Try



        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub TXTCON_LECTORA_CheckedChanged(sender As Object, e As EventArgs) Handles TXTCON_LECTORA.CheckedChanged
        If TXTCON_LECTORA.Checked = True Then
            txtteclado.Checked = False

        End If
    End Sub

    Private Sub txtteclado_CheckedChanged(sender As Object, e As EventArgs) Handles txtteclado.CheckedChanged
        If txtteclado.Checked = True Then
            TXTCON_LECTORA.Checked = False

        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Close()

    End Sub
End Class