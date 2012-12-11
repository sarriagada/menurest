<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edicion_rest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_edicion_rest))
        Me.txt_descripcion_rest = New System.Windows.Forms.TextBox
        Me.txt_tel_rest = New System.Windows.Forms.TextBox
        Me.txt_dir_rest = New System.Windows.Forms.TextBox
        Me.txt_nombre_rest = New System.Windows.Forms.TextBox
        Me.pic_guardar = New System.Windows.Forms.PictureBox
        Me.pic_cancelar = New System.Windows.Forms.PictureBox
        CType(Me.pic_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_cancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_descripcion_rest
        '
        Me.txt_descripcion_rest.Location = New System.Drawing.Point(142, 73)
        Me.txt_descripcion_rest.Name = "txt_descripcion_rest"
        Me.txt_descripcion_rest.Size = New System.Drawing.Size(100, 20)
        Me.txt_descripcion_rest.TabIndex = 5
        '
        'txt_tel_rest
        '
        Me.txt_tel_rest.Location = New System.Drawing.Point(142, 114)
        Me.txt_tel_rest.Name = "txt_tel_rest"
        Me.txt_tel_rest.Size = New System.Drawing.Size(100, 20)
        Me.txt_tel_rest.TabIndex = 6
        '
        'txt_dir_rest
        '
        Me.txt_dir_rest.Location = New System.Drawing.Point(142, 155)
        Me.txt_dir_rest.Name = "txt_dir_rest"
        Me.txt_dir_rest.Size = New System.Drawing.Size(100, 20)
        Me.txt_dir_rest.TabIndex = 7
        '
        'txt_nombre_rest
        '
        Me.txt_nombre_rest.Location = New System.Drawing.Point(142, 29)
        Me.txt_nombre_rest.Name = "txt_nombre_rest"
        Me.txt_nombre_rest.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre_rest.TabIndex = 13
        '
        'pic_guardar
        '
        Me.pic_guardar.Image = CType(resources.GetObject("pic_guardar.Image"), System.Drawing.Image)
        Me.pic_guardar.Location = New System.Drawing.Point(58, 194)
        Me.pic_guardar.Name = "pic_guardar"
        Me.pic_guardar.Size = New System.Drawing.Size(145, 30)
        Me.pic_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_guardar.TabIndex = 14
        Me.pic_guardar.TabStop = False
        '
        'pic_cancelar
        '
        Me.pic_cancelar.Image = CType(resources.GetObject("pic_cancelar.Image"), System.Drawing.Image)
        Me.pic_cancelar.Location = New System.Drawing.Point(89, 230)
        Me.pic_cancelar.Name = "pic_cancelar"
        Me.pic_cancelar.Size = New System.Drawing.Size(83, 25)
        Me.pic_cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_cancelar.TabIndex = 15
        Me.pic_cancelar.TabStop = False
        '
        'frm_edicion_rest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(268, 267)
        Me.Controls.Add(Me.pic_cancelar)
        Me.Controls.Add(Me.pic_guardar)
        Me.Controls.Add(Me.txt_nombre_rest)
        Me.Controls.Add(Me.txt_dir_rest)
        Me.Controls.Add(Me.txt_tel_rest)
        Me.Controls.Add(Me.txt_descripcion_rest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_edicion_rest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar restaurant"
        CType(Me.pic_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_cancelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_descripcion_rest As System.Windows.Forms.TextBox
    Friend WithEvents txt_tel_rest As System.Windows.Forms.TextBox
    Friend WithEvents txt_dir_rest As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_rest As System.Windows.Forms.TextBox
    Friend WithEvents pic_guardar As System.Windows.Forms.PictureBox
    Friend WithEvents pic_cancelar As System.Windows.Forms.PictureBox
End Class
