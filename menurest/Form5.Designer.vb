<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add
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
        Me.lbl_nombre_rest = New System.Windows.Forms.Label
        Me.txt_nombre_rest = New System.Windows.Forms.TextBox
        Me.lbl_platos = New System.Windows.Forms.Label
        Me.lst_platos = New System.Windows.Forms.ListBox
        Me.lbl_add = New System.Windows.Forms.Label
        Me.lbl_editar = New System.Windows.Forms.Label
        Me.lbl_borrar = New System.Windows.Forms.Label
        Me.lbl_volver = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_nombre_rest
        '
        Me.lbl_nombre_rest.AutoSize = True
        Me.lbl_nombre_rest.Location = New System.Drawing.Point(23, 27)
        Me.lbl_nombre_rest.Name = "lbl_nombre_rest"
        Me.lbl_nombre_rest.Size = New System.Drawing.Size(82, 17)
        Me.lbl_nombre_rest.TabIndex = 0
        Me.lbl_nombre_rest.Text = "Restaurant:"
        '
        'txt_nombre_rest
        '
        Me.txt_nombre_rest.Location = New System.Drawing.Point(122, 27)
        Me.txt_nombre_rest.Name = "txt_nombre_rest"
        Me.txt_nombre_rest.Size = New System.Drawing.Size(120, 22)
        Me.txt_nombre_rest.TabIndex = 1
        '
        'lbl_platos
        '
        Me.lbl_platos.AutoSize = True
        Me.lbl_platos.Location = New System.Drawing.Point(23, 68)
        Me.lbl_platos.Name = "lbl_platos"
        Me.lbl_platos.Size = New System.Drawing.Size(51, 17)
        Me.lbl_platos.TabIndex = 2
        Me.lbl_platos.Text = "Platos:"
        '
        'lst_platos
        '
        Me.lst_platos.FormattingEnabled = True
        Me.lst_platos.ItemHeight = 16
        Me.lst_platos.Location = New System.Drawing.Point(122, 68)
        Me.lst_platos.Name = "lst_platos"
        Me.lst_platos.Size = New System.Drawing.Size(120, 84)
        Me.lst_platos.TabIndex = 3
        '
        'lbl_add
        '
        Me.lbl_add.AutoSize = True
        Me.lbl_add.Location = New System.Drawing.Point(303, 27)
        Me.lbl_add.Name = "lbl_add"
        Me.lbl_add.Size = New System.Drawing.Size(59, 17)
        Me.lbl_add.TabIndex = 4
        Me.lbl_add.Text = "Agregar"
        '
        'lbl_editar
        '
        Me.lbl_editar.AutoSize = True
        Me.lbl_editar.Location = New System.Drawing.Point(303, 58)
        Me.lbl_editar.Name = "lbl_editar"
        Me.lbl_editar.Size = New System.Drawing.Size(45, 17)
        Me.lbl_editar.TabIndex = 5
        Me.lbl_editar.Text = "Editar"
        '
        'lbl_borrar
        '
        Me.lbl_borrar.AutoSize = True
        Me.lbl_borrar.Location = New System.Drawing.Point(303, 88)
        Me.lbl_borrar.Name = "lbl_borrar"
        Me.lbl_borrar.Size = New System.Drawing.Size(48, 17)
        Me.lbl_borrar.TabIndex = 6
        Me.lbl_borrar.Text = "Borrar"
        '
        'lbl_volver
        '
        Me.lbl_volver.AutoSize = True
        Me.lbl_volver.Location = New System.Drawing.Point(303, 149)
        Me.lbl_volver.Name = "lbl_volver"
        Me.lbl_volver.Size = New System.Drawing.Size(48, 17)
        Me.lbl_volver.TabIndex = 7
        Me.lbl_volver.Text = "Volver"
        '
        'frm_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 185)
        Me.Controls.Add(Me.lbl_volver)
        Me.Controls.Add(Me.lbl_borrar)
        Me.Controls.Add(Me.lbl_editar)
        Me.Controls.Add(Me.lbl_add)
        Me.Controls.Add(Me.lst_platos)
        Me.Controls.Add(Me.lbl_platos)
        Me.Controls.Add(Me.txt_nombre_rest)
        Me.Controls.Add(Me.lbl_nombre_rest)
        Me.Name = "frm_add"
        Me.Text = "menurest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre_rest As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_rest As System.Windows.Forms.TextBox
    Friend WithEvents lbl_platos As System.Windows.Forms.Label
    Friend WithEvents lst_platos As System.Windows.Forms.ListBox
    Friend WithEvents lbl_add As System.Windows.Forms.Label
    Friend WithEvents lbl_editar As System.Windows.Forms.Label
    Friend WithEvents lbl_borrar As System.Windows.Forms.Label
    Friend WithEvents lbl_volver As System.Windows.Forms.Label
End Class
