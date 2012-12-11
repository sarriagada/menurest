<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edicion_platos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_edicion_platos))
        Me.txt_nombre_plato = New System.Windows.Forms.TextBox
        Me.txt_descripcion_plato = New System.Windows.Forms.TextBox
        Me.txt_precio = New System.Windows.Forms.TextBox
        Me.lst_restaurantes = New System.Windows.Forms.ListBox
        Me.pic_guardar = New System.Windows.Forms.PictureBox
        Me.pic_volver = New System.Windows.Forms.PictureBox
        CType(Me.pic_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_volver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nombre_plato
        '
        Me.txt_nombre_plato.Location = New System.Drawing.Point(128, 53)
        Me.txt_nombre_plato.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre_plato.Name = "txt_nombre_plato"
        Me.txt_nombre_plato.Size = New System.Drawing.Size(76, 20)
        Me.txt_nombre_plato.TabIndex = 10
        '
        'txt_descripcion_plato
        '
        Me.txt_descripcion_plato.Location = New System.Drawing.Point(128, 111)
        Me.txt_descripcion_plato.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descripcion_plato.Name = "txt_descripcion_plato"
        Me.txt_descripcion_plato.Size = New System.Drawing.Size(76, 20)
        Me.txt_descripcion_plato.TabIndex = 11
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(128, 167)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(76, 20)
        Me.txt_precio.TabIndex = 13
        '
        'lst_restaurantes
        '
        Me.lst_restaurantes.FormattingEnabled = True
        Me.lst_restaurantes.Location = New System.Drawing.Point(12, 53)
        Me.lst_restaurantes.Name = "lst_restaurantes"
        Me.lst_restaurantes.Size = New System.Drawing.Size(95, 134)
        Me.lst_restaurantes.TabIndex = 14
        '
        'pic_guardar
        '
        Me.pic_guardar.Image = CType(resources.GetObject("pic_guardar.Image"), System.Drawing.Image)
        Me.pic_guardar.Location = New System.Drawing.Point(44, 210)
        Me.pic_guardar.Name = "pic_guardar"
        Me.pic_guardar.Size = New System.Drawing.Size(145, 30)
        Me.pic_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_guardar.TabIndex = 16
        Me.pic_guardar.TabStop = False
        '
        'pic_volver
        '
        Me.pic_volver.Image = CType(resources.GetObject("pic_volver.Image"), System.Drawing.Image)
        Me.pic_volver.Location = New System.Drawing.Point(63, 246)
        Me.pic_volver.Name = "pic_volver"
        Me.pic_volver.Size = New System.Drawing.Size(106, 39)
        Me.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_volver.TabIndex = 17
        Me.pic_volver.TabStop = False
        '
        'frm_edicion_platos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(239, 291)
        Me.Controls.Add(Me.pic_volver)
        Me.Controls.Add(Me.pic_guardar)
        Me.Controls.Add(Me.lst_restaurantes)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_descripcion_plato)
        Me.Controls.Add(Me.txt_nombre_plato)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_edicion_platos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menurest"
        CType(Me.pic_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_volver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre_plato As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion_plato As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents lst_restaurantes As System.Windows.Forms.ListBox
    Friend WithEvents pic_guardar As System.Windows.Forms.PictureBox
    Friend WithEvents pic_volver As System.Windows.Forms.PictureBox
End Class
