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
        Me.lbl_volver = New System.Windows.Forms.Label
        Me.lbl_descripcion_plato = New System.Windows.Forms.Label
        Me.lbl_nombre_plato = New System.Windows.Forms.Label
        Me.txt_nombre_plat = New System.Windows.Forms.TextBox
        Me.txt_descripcion_plato = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lbl_volver
        '
        Me.lbl_volver.AutoSize = True
        Me.lbl_volver.Location = New System.Drawing.Point(19, 143)
        Me.lbl_volver.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_volver.Name = "lbl_volver"
        Me.lbl_volver.Size = New System.Drawing.Size(37, 13)
        Me.lbl_volver.TabIndex = 8
        Me.lbl_volver.Text = "Volver"
        '
        'lbl_descripcion_plato
        '
        Me.lbl_descripcion_plato.AutoSize = True
        Me.lbl_descripcion_plato.Location = New System.Drawing.Point(116, 64)
        Me.lbl_descripcion_plato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_descripcion_plato.Name = "lbl_descripcion_plato"
        Me.lbl_descripcion_plato.Size = New System.Drawing.Size(61, 13)
        Me.lbl_descripcion_plato.TabIndex = 6
        Me.lbl_descripcion_plato.Text = "descripcion"
        '
        'lbl_nombre_plato
        '
        Me.lbl_nombre_plato.AutoSize = True
        Me.lbl_nombre_plato.Location = New System.Drawing.Point(109, 27)
        Me.lbl_nombre_plato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre_plato.Name = "lbl_nombre_plato"
        Me.lbl_nombre_plato.Size = New System.Drawing.Size(68, 13)
        Me.lbl_nombre_plato.TabIndex = 5
        Me.lbl_nombre_plato.Text = "nombre plato"
        '
        'txt_nombre_plat
        '
        Me.txt_nombre_plat.Location = New System.Drawing.Point(112, 42)
        Me.txt_nombre_plat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nombre_plat.Name = "txt_nombre_plat"
        Me.txt_nombre_plat.Size = New System.Drawing.Size(76, 20)
        Me.txt_nombre_plat.TabIndex = 10
        '
        'txt_descripcion_plato
        '
        Me.txt_descripcion_plato.Location = New System.Drawing.Point(112, 79)
        Me.txt_descripcion_plato.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_descripcion_plato.Name = "txt_descripcion_plato"
        Me.txt_descripcion_plato.Size = New System.Drawing.Size(76, 20)
        Me.txt_descripcion_plato.TabIndex = 11
        '
        'frm_edicion_platos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 178)
        Me.Controls.Add(Me.txt_descripcion_plato)
        Me.Controls.Add(Me.txt_nombre_plat)
        Me.Controls.Add(Me.lbl_volver)
        Me.Controls.Add(Me.lbl_descripcion_plato)
        Me.Controls.Add(Me.lbl_nombre_plato)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_edicion_platos"
        Me.Text = "menurest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_volver As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion_plato As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_plato As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_plat As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion_plato As System.Windows.Forms.TextBox
End Class
