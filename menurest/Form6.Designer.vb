<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit
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
        Me.pic_plato = New System.Windows.Forms.PictureBox
        Me.lbl_volver = New System.Windows.Forms.Label
        Me.lbl_descripcion_plato = New System.Windows.Forms.Label
        Me.lbl_nombre_plato = New System.Windows.Forms.Label
        Me.txt_nombre_plat = New System.Windows.Forms.TextBox
        Me.txt_descripcion_plato = New System.Windows.Forms.TextBox
        CType(Me.pic_plato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_plato
        '
        Me.pic_plato.Location = New System.Drawing.Point(147, 33)
        Me.pic_plato.Name = "pic_plato"
        Me.pic_plato.Size = New System.Drawing.Size(99, 61)
        Me.pic_plato.TabIndex = 9
        Me.pic_plato.TabStop = False
        '
        'lbl_volver
        '
        Me.lbl_volver.AutoSize = True
        Me.lbl_volver.Location = New System.Drawing.Point(25, 176)
        Me.lbl_volver.Name = "lbl_volver"
        Me.lbl_volver.Size = New System.Drawing.Size(48, 17)
        Me.lbl_volver.TabIndex = 8
        Me.lbl_volver.Text = "Volver"
        '
        'lbl_descripcion_plato
        '
        Me.lbl_descripcion_plato.AutoSize = True
        Me.lbl_descripcion_plato.Location = New System.Drawing.Point(25, 77)
        Me.lbl_descripcion_plato.Name = "lbl_descripcion_plato"
        Me.lbl_descripcion_plato.Size = New System.Drawing.Size(80, 17)
        Me.lbl_descripcion_plato.TabIndex = 6
        Me.lbl_descripcion_plato.Text = "descripcion"
        '
        'lbl_nombre_plato
        '
        Me.lbl_nombre_plato.AutoSize = True
        Me.lbl_nombre_plato.Location = New System.Drawing.Point(25, 33)
        Me.lbl_nombre_plato.Name = "lbl_nombre_plato"
        Me.lbl_nombre_plato.Size = New System.Drawing.Size(91, 17)
        Me.lbl_nombre_plato.TabIndex = 5
        Me.lbl_nombre_plato.Text = "nombre plato"
        '
        'txt_nombre_plat
        '
        Me.txt_nombre_plat.Location = New System.Drawing.Point(28, 52)
        Me.txt_nombre_plat.Name = "txt_nombre_plat"
        Me.txt_nombre_plat.Size = New System.Drawing.Size(100, 22)
        Me.txt_nombre_plat.TabIndex = 10
        '
        'txt_descripcion_plato
        '
        Me.txt_descripcion_plato.Location = New System.Drawing.Point(28, 97)
        Me.txt_descripcion_plato.Name = "txt_descripcion_plato"
        Me.txt_descripcion_plato.Size = New System.Drawing.Size(100, 22)
        Me.txt_descripcion_plato.TabIndex = 11
        '
        'frm_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 219)
        Me.Controls.Add(Me.txt_descripcion_plato)
        Me.Controls.Add(Me.txt_nombre_plat)
        Me.Controls.Add(Me.pic_plato)
        Me.Controls.Add(Me.lbl_volver)
        Me.Controls.Add(Me.lbl_descripcion_plato)
        Me.Controls.Add(Me.lbl_nombre_plato)
        Me.Name = "frm_edit"
        Me.Text = "menurest"
        CType(Me.pic_plato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_plato As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_volver As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion_plato As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_plato As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_plat As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion_plato As System.Windows.Forms.TextBox
End Class
