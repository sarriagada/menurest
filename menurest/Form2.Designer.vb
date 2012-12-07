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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registro))
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.txt_pass_confirm = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.pic_guardar = New System.Windows.Forms.PictureBox
        Me.pic_cancelar = New System.Windows.Forms.PictureBox
        CType(Me.pic_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_cancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(82, 113)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(151, 20)
        Me.txt_pass.TabIndex = 2
        '
        'txt_pass_confirm
        '
        Me.txt_pass_confirm.Location = New System.Drawing.Point(82, 149)
        Me.txt_pass_confirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_pass_confirm.Name = "txt_pass_confirm"
        Me.txt_pass_confirm.Size = New System.Drawing.Size(151, 20)
        Me.txt_pass_confirm.TabIndex = 3
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(82, 79)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(151, 20)
        Me.txt_nombre.TabIndex = 4
        '
        'pic_guardar
        '
        Me.pic_guardar.Image = CType(resources.GetObject("pic_guardar.Image"), System.Drawing.Image)
        Me.pic_guardar.Location = New System.Drawing.Point(82, 192)
        Me.pic_guardar.Name = "pic_guardar"
        Me.pic_guardar.Size = New System.Drawing.Size(145, 30)
        Me.pic_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_guardar.TabIndex = 5
        Me.pic_guardar.TabStop = False
        '
        'pic_cancelar
        '
        Me.pic_cancelar.Image = CType(resources.GetObject("pic_cancelar.Image"), System.Drawing.Image)
        Me.pic_cancelar.Location = New System.Drawing.Point(114, 230)
        Me.pic_cancelar.Name = "pic_cancelar"
        Me.pic_cancelar.Size = New System.Drawing.Size(83, 25)
        Me.pic_cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_cancelar.TabIndex = 6
        Me.pic_cancelar.TabStop = False
        '
        'frm_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(301, 278)
        Me.Controls.Add(Me.pic_cancelar)
        Me.Controls.Add(Me.pic_guardar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_pass_confirm)
        Me.Controls.Add(Me.txt_pass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menurest"
        CType(Me.pic_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_cancelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass_confirm As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents pic_guardar As System.Windows.Forms.PictureBox
    Friend WithEvents pic_cancelar As System.Windows.Forms.PictureBox
End Class
