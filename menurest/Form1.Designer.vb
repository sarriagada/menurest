<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_pass = New System.Windows.Forms.Label
        Me.lbl_registro = New System.Windows.Forms.Label
        Me.lbl_entrar = New System.Windows.Forms.Label
        Me.pic_logo = New System.Windows.Forms.PictureBox
        Me.lbl_menurest = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(441, 138)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(217, 49)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(441, 208)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(217, 49)
        Me.txt_pass.TabIndex = 1
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Broadway", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_nombre.Location = New System.Drawing.Point(172, 138)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(194, 42)
        Me.lbl_nombre.TabIndex = 2
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Broadway", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_pass.Location = New System.Drawing.Point(172, 208)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(264, 42)
        Me.lbl_pass.TabIndex = 3
        Me.lbl_pass.Text = "Contraseña:"
        '
        'lbl_registro
        '
        Me.lbl_registro.AutoSize = True
        Me.lbl_registro.Font = New System.Drawing.Font("Broadway", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_registro.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_registro.Location = New System.Drawing.Point(172, 309)
        Me.lbl_registro.Name = "lbl_registro"
        Me.lbl_registro.Size = New System.Drawing.Size(243, 42)
        Me.lbl_registro.TabIndex = 3
        Me.lbl_registro.Text = "Registrarse"
        '
        'lbl_entrar
        '
        Me.lbl_entrar.AutoSize = True
        Me.lbl_entrar.Font = New System.Drawing.Font("Broadway", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_entrar.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_entrar.Location = New System.Drawing.Point(505, 309)
        Me.lbl_entrar.Name = "lbl_entrar"
        Me.lbl_entrar.Size = New System.Drawing.Size(153, 42)
        Me.lbl_entrar.TabIndex = 2
        Me.lbl_entrar.Text = "Entrar"
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(24, 23)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(142, 98)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 6
        Me.pic_logo.TabStop = False
        '
        'lbl_menurest
        '
        Me.lbl_menurest.AutoSize = True
        Me.lbl_menurest.Font = New System.Drawing.Font("Broadway", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menurest.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbl_menurest.Location = New System.Drawing.Point(170, 33)
        Me.lbl_menurest.Name = "lbl_menurest"
        Me.lbl_menurest.Size = New System.Drawing.Size(166, 31)
        Me.lbl_menurest.TabIndex = 7
        Me.lbl_menurest.Text = "MenuRest"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(172, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(490, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "________________________________________________"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(688, 381)
        Me.Controls.Add(Me.lbl_menurest)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.lbl_entrar)
        Me.Controls.Add(Me.lbl_registro)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menurest"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents lbl_registro As System.Windows.Forms.Label
    Friend WithEvents lbl_entrar As System.Windows.Forms.Label
    Friend WithEvents pic_logo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_menurest As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
