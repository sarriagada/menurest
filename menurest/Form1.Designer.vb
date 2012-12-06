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
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.lbl_registro = New System.Windows.Forms.Label
        Me.lbl_entrar = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(79, 62)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 22)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(79, 109)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(100, 22)
        Me.txt_pass.TabIndex = 1
        '
        'lbl_registro
        '
        Me.lbl_registro.AutoSize = True
        Me.lbl_registro.Location = New System.Drawing.Point(44, 177)
        Me.lbl_registro.Name = "lbl_registro"
        Me.lbl_registro.Size = New System.Drawing.Size(81, 17)
        Me.lbl_registro.TabIndex = 2
        Me.lbl_registro.Text = "Registrarse"
        '
        'lbl_entrar
        '
        Me.lbl_entrar.AutoSize = True
        Me.lbl_entrar.Location = New System.Drawing.Point(168, 177)
        Me.lbl_entrar.Name = "lbl_entrar"
        Me.lbl_entrar.Size = New System.Drawing.Size(47, 17)
        Me.lbl_entrar.TabIndex = 3
        Me.lbl_entrar.Text = "Entrar"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.lbl_entrar)
        Me.Controls.Add(Me.lbl_registro)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_nombre)
        Me.Name = "frm_login"
        Me.Text = "menurest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents lbl_registro As System.Windows.Forms.Label
    Friend WithEvents lbl_entrar As System.Windows.Forms.Label

End Class
