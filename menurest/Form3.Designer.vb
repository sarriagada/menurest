<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_app
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
        Me.lbl_rest = New System.Windows.Forms.Label
        Me.lbl_platos = New System.Windows.Forms.Label
        Me.lst_rest = New System.Windows.Forms.ListBox
        Me.lst_platos = New System.Windows.Forms.ListBox
        Me.lbl_agregar = New System.Windows.Forms.Label
        Me.lbl_ver = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_rest
        '
        Me.lbl_rest.AutoSize = True
        Me.lbl_rest.Location = New System.Drawing.Point(20, 15)
        Me.lbl_rest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_rest.Name = "lbl_rest"
        Me.lbl_rest.Size = New System.Drawing.Size(73, 13)
        Me.lbl_rest.TabIndex = 0
        Me.lbl_rest.Text = "Restaurantes:"
        '
        'lbl_platos
        '
        Me.lbl_platos.AutoSize = True
        Me.lbl_platos.Location = New System.Drawing.Point(140, 15)
        Me.lbl_platos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_platos.Name = "lbl_platos"
        Me.lbl_platos.Size = New System.Drawing.Size(39, 13)
        Me.lbl_platos.TabIndex = 1
        Me.lbl_platos.Text = "Platos:"
        '
        'lst_rest
        '
        Me.lst_rest.FormattingEnabled = True
        Me.lst_rest.Location = New System.Drawing.Point(9, 46)
        Me.lst_rest.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_rest.Name = "lst_rest"
        Me.lst_rest.Size = New System.Drawing.Size(91, 69)
        Me.lst_rest.TabIndex = 2
        '
        'lst_platos
        '
        Me.lst_platos.FormattingEnabled = True
        Me.lst_platos.Location = New System.Drawing.Point(143, 46)
        Me.lst_platos.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_platos.Name = "lst_platos"
        Me.lst_platos.Size = New System.Drawing.Size(91, 69)
        Me.lst_platos.TabIndex = 3
        '
        'lbl_agregar
        '
        Me.lbl_agregar.AutoSize = True
        Me.lbl_agregar.Location = New System.Drawing.Point(9, 160)
        Me.lbl_agregar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_agregar.Name = "lbl_agregar"
        Me.lbl_agregar.Size = New System.Drawing.Size(53, 13)
        Me.lbl_agregar.TabIndex = 4
        Me.lbl_agregar.Text = "Agregar +"
        '
        'lbl_ver
        '
        Me.lbl_ver.AutoSize = True
        Me.lbl_ver.Location = New System.Drawing.Point(101, 160)
        Me.lbl_ver.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ver.Name = "lbl_ver"
        Me.lbl_ver.Size = New System.Drawing.Size(23, 13)
        Me.lbl_ver.TabIndex = 5
        Me.lbl_ver.Text = "Ver"
        '
        'frm_app
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 207)
        Me.Controls.Add(Me.lbl_ver)
        Me.Controls.Add(Me.lbl_agregar)
        Me.Controls.Add(Me.lst_platos)
        Me.Controls.Add(Me.lst_rest)
        Me.Controls.Add(Me.lbl_platos)
        Me.Controls.Add(Me.lbl_rest)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_app"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menurest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_rest As System.Windows.Forms.Label
    Friend WithEvents lbl_platos As System.Windows.Forms.Label
    Friend WithEvents lst_rest As System.Windows.Forms.ListBox
    Friend WithEvents lst_platos As System.Windows.Forms.ListBox
    Friend WithEvents lbl_agregar As System.Windows.Forms.Label
    Friend WithEvents lbl_ver As System.Windows.Forms.Label
End Class
