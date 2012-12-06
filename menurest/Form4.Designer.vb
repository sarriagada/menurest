<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_show
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
        Me.lbl_nombre_plato = New System.Windows.Forms.Label
        Me.lbl_descripcion_plato = New System.Windows.Forms.Label
        Me.lbl_nombre_rest = New System.Windows.Forms.Label
        Me.lbl_volver = New System.Windows.Forms.Label
        Me.pic_plato = New System.Windows.Forms.PictureBox
        CType(Me.pic_plato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre_plato
        '
        Me.lbl_nombre_plato.AutoSize = True
        Me.lbl_nombre_plato.Location = New System.Drawing.Point(31, 29)
        Me.lbl_nombre_plato.Name = "lbl_nombre_plato"
        Me.lbl_nombre_plato.Size = New System.Drawing.Size(91, 17)
        Me.lbl_nombre_plato.TabIndex = 0
        Me.lbl_nombre_plato.Text = "nombre plato"
        '
        'lbl_descripcion_plato
        '
        Me.lbl_descripcion_plato.AutoSize = True
        Me.lbl_descripcion_plato.Location = New System.Drawing.Point(31, 73)
        Me.lbl_descripcion_plato.Name = "lbl_descripcion_plato"
        Me.lbl_descripcion_plato.Size = New System.Drawing.Size(80, 17)
        Me.lbl_descripcion_plato.TabIndex = 1
        Me.lbl_descripcion_plato.Text = "descripcion"
        '
        'lbl_nombre_rest
        '
        Me.lbl_nombre_rest.AutoSize = True
        Me.lbl_nombre_rest.Location = New System.Drawing.Point(31, 109)
        Me.lbl_nombre_rest.Name = "lbl_nombre_rest"
        Me.lbl_nombre_rest.Size = New System.Drawing.Size(32, 17)
        Me.lbl_nombre_rest.TabIndex = 2
        Me.lbl_nombre_rest.Text = "rest"
        '
        'lbl_volver
        '
        Me.lbl_volver.AutoSize = True
        Me.lbl_volver.Location = New System.Drawing.Point(31, 201)
        Me.lbl_volver.Name = "lbl_volver"
        Me.lbl_volver.Size = New System.Drawing.Size(48, 17)
        Me.lbl_volver.TabIndex = 3
        Me.lbl_volver.Text = "Volver"
        '
        'pic_plato
        '
        Me.pic_plato.Location = New System.Drawing.Point(141, 29)
        Me.pic_plato.Name = "pic_plato"
        Me.pic_plato.Size = New System.Drawing.Size(99, 61)
        Me.pic_plato.TabIndex = 4
        Me.pic_plato.TabStop = False
        '
        'frm_show
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.pic_plato)
        Me.Controls.Add(Me.lbl_volver)
        Me.Controls.Add(Me.lbl_nombre_rest)
        Me.Controls.Add(Me.lbl_descripcion_plato)
        Me.Controls.Add(Me.lbl_nombre_plato)
        Me.Name = "frm_show"
        Me.Text = "menurest"
        CType(Me.pic_plato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre_plato As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion_plato As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_rest As System.Windows.Forms.Label
    Friend WithEvents lbl_volver As System.Windows.Forms.Label
    Friend WithEvents pic_plato As System.Windows.Forms.PictureBox
End Class
