<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registro
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
        Me.lbl_cancelar = New System.Windows.Forms.Label
        Me.lbl_guardar = New System.Windows.Forms.Label
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.txt_pass_confirm = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = True
        Me.lbl_cancelar.Location = New System.Drawing.Point(38, 196)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New System.Drawing.Size(64, 17)
        Me.lbl_cancelar.TabIndex = 0
        Me.lbl_cancelar.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(158, 196)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(61, 17)
        Me.lbl_guardar.TabIndex = 1
        Me.lbl_guardar.Text = "Guardar"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(92, 72)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(100, 22)
        Me.txt_pass.TabIndex = 2
        '
        'txt_pass_confirm
        '
        Me.txt_pass_confirm.Location = New System.Drawing.Point(92, 116)
        Me.txt_pass_confirm.Name = "txt_pass_confirm"
        Me.txt_pass_confirm.Size = New System.Drawing.Size(100, 22)
        Me.txt_pass_confirm.TabIndex = 3
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(92, 34)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 22)
        Me.txt_nombre.TabIndex = 4
        '
        'frm_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_pass_confirm)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.lbl_cancelar)
        Me.Name = "frm_registro"
        Me.Text = "menurest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_cancelar As System.Windows.Forms.Label
    Friend WithEvents lbl_guardar As System.Windows.Forms.Label
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass_confirm As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
End Class
