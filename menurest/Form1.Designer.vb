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
        Me.pic_entrar = New System.Windows.Forms.PictureBox
        Me.pic_registrarse = New System.Windows.Forms.PictureBox
        Me.pic_entrar_on = New System.Windows.Forms.PictureBox
        CType(Me.pic_entrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_registrarse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_entrar_on, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(74, 100)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(169, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(74, 139)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(169, 20)
        Me.txt_pass.TabIndex = 1
        '
        'pic_entrar
        '
        Me.pic_entrar.Image = CType(resources.GetObject("pic_entrar.Image"), System.Drawing.Image)
        Me.pic_entrar.Location = New System.Drawing.Point(83, 164)
        Me.pic_entrar.Name = "pic_entrar"
        Me.pic_entrar.Size = New System.Drawing.Size(138, 66)
        Me.pic_entrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_entrar.TabIndex = 3
        Me.pic_entrar.TabStop = False
        '
        'pic_registrarse
        '
        Me.pic_registrarse.Image = CType(resources.GetObject("pic_registrarse.Image"), System.Drawing.Image)
        Me.pic_registrarse.Location = New System.Drawing.Point(176, 240)
        Me.pic_registrarse.Name = "pic_registrarse"
        Me.pic_registrarse.Size = New System.Drawing.Size(109, 14)
        Me.pic_registrarse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_registrarse.TabIndex = 4
        Me.pic_registrarse.TabStop = False
        '
        'pic_entrar_on
        '
        Me.pic_entrar_on.Image = CType(resources.GetObject("pic_entrar_on.Image"), System.Drawing.Image)
        Me.pic_entrar_on.Location = New System.Drawing.Point(83, 164)
        Me.pic_entrar_on.Name = "pic_entrar_on"
        Me.pic_entrar_on.Size = New System.Drawing.Size(138, 66)
        Me.pic_entrar_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_entrar_on.TabIndex = 5
        Me.pic_entrar_on.TabStop = False
        Me.pic_entrar_on.Visible = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(297, 266)
        Me.Controls.Add(Me.pic_entrar_on)
        Me.Controls.Add(Me.pic_registrarse)
        Me.Controls.Add(Me.pic_entrar)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menurest"
        CType(Me.pic_entrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_registrarse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_entrar_on, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents pic_entrar As System.Windows.Forms.PictureBox
    Friend WithEvents pic_registrarse As System.Windows.Forms.PictureBox
    Friend WithEvents pic_entrar_on As System.Windows.Forms.PictureBox

End Class
