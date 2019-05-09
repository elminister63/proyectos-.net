<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuariosOK
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.txtpasword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtvendedor = New System.Windows.Forms.CheckBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panelregistro = New System.Windows.Forms.Panel()
        Me.txtdni = New System.Windows.Forms.MaskedTextBox()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnguardarcambios = New System.Windows.Forms.Button()
        Me.LBLVENDEDOR = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panelregistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres y apellidos"
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(182, 13)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(457, 26)
        Me.txtnombres.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DNI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Telefono"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(182, 77)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(213, 26)
        Me.txttelefono.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Login"
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(182, 109)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(213, 26)
        Me.txtlogin.TabIndex = 1
        '
        'txtpasword
        '
        Me.txtpasword.Location = New System.Drawing.Point(182, 141)
        Me.txtpasword.Name = "txtpasword"
        Me.txtpasword.Size = New System.Drawing.Size(213, 26)
        Me.txtpasword.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Password"
        '
        'txtvendedor
        '
        Me.txtvendedor.AutoSize = True
        Me.txtvendedor.Location = New System.Drawing.Point(182, 183)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(121, 24)
        Me.txtvendedor.TabIndex = 2
        Me.txtvendedor.Text = "Es Vendedor"
        Me.txtvendedor.UseVisualStyleBackColor = True
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToResizeRows = False
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistado.Location = New System.Drawing.Point(0, 74)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistado.RowTemplate.Height = 40
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(850, 493)
        Me.datalistado.TabIndex = 3
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(21, 221)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(139, 38)
        Me.btnguardar.TabIndex = 4
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(850, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 24)
        Me.ToolStripMenuItem1.Text = "Registrar Nuevo Usuario"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Red
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(75, 24)
        Me.ToolStripMenuItem2.Text = "Eliminar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 43)
        Me.Panel1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Panelregistro
        '
        Me.Panelregistro.BackColor = System.Drawing.Color.White
        Me.Panelregistro.Controls.Add(Me.txtdni)
        Me.Panelregistro.Controls.Add(Me.btnvolver)
        Me.Panelregistro.Controls.Add(Me.btnguardarcambios)
        Me.Panelregistro.Controls.Add(Me.txtvendedor)
        Me.Panelregistro.Controls.Add(Me.txtlogin)
        Me.Panelregistro.Controls.Add(Me.btnguardar)
        Me.Panelregistro.Controls.Add(Me.Label6)
        Me.Panelregistro.Controls.Add(Me.Label4)
        Me.Panelregistro.Controls.Add(Me.LBLVENDEDOR)
        Me.Panelregistro.Controls.Add(Me.Label2)
        Me.Panelregistro.Controls.Add(Me.txtpasword)
        Me.Panelregistro.Controls.Add(Me.txttelefono)
        Me.Panelregistro.Controls.Add(Me.Label3)
        Me.Panelregistro.Controls.Add(Me.txtnombres)
        Me.Panelregistro.Controls.Add(Me.Label1)
        Me.Panelregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Panelregistro.Location = New System.Drawing.Point(179, 95)
        Me.Panelregistro.Name = "Panelregistro"
        Me.Panelregistro.Size = New System.Drawing.Size(671, 472)
        Me.Panelregistro.TabIndex = 7
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(182, 45)
        Me.txtdni.Mask = "99999999"
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(213, 26)
        Me.txtdni.TabIndex = 7
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(362, 222)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(133, 36)
        Me.btnvolver.TabIndex = 6
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btnguardarcambios
        '
        Me.btnguardarcambios.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnguardarcambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardarcambios.ForeColor = System.Drawing.Color.White
        Me.btnguardarcambios.Location = New System.Drawing.Point(166, 221)
        Me.btnguardarcambios.Name = "btnguardarcambios"
        Me.btnguardarcambios.Size = New System.Drawing.Size(190, 37)
        Me.btnguardarcambios.TabIndex = 5
        Me.btnguardarcambios.Text = "Guardar cambios"
        Me.btnguardarcambios.UseVisualStyleBackColor = False
        '
        'LBLVENDEDOR
        '
        Me.LBLVENDEDOR.AutoSize = True
        Me.LBLVENDEDOR.ForeColor = System.Drawing.Color.White
        Me.LBLVENDEDOR.Location = New System.Drawing.Point(189, 230)
        Me.LBLVENDEDOR.Name = "LBLVENDEDOR"
        Me.LBLVENDEDOR.Size = New System.Drawing.Size(37, 20)
        Me.LBLVENDEDOR.TabIndex = 0
        Me.LBLVENDEDOR.Text = "DNI"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(815, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(850, 3)
        Me.Panel2.TabIndex = 2
        '
        'usuariosOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 567)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panelregistro)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "usuariosOK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panelregistro.ResumeLayout(False)
        Me.Panelregistro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombres As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents txtpasword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtvendedor As System.Windows.Forms.CheckBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panelregistro As System.Windows.Forms.Panel
    Friend WithEvents btnguardarcambios As System.Windows.Forms.Button
    Friend WithEvents LBLVENDEDOR As System.Windows.Forms.Label
    Friend WithEvents btnvolver As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtdni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
