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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_app))
        Me.lst_rest = New System.Windows.Forms.ListBox
        Me.lst_platos = New System.Windows.Forms.ListBox
        Me.pic_ver = New System.Windows.Forms.PictureBox
        Me.pic_agregar = New System.Windows.Forms.PictureBox
        Me.lbl_usuario = New System.Windows.Forms.Label
        Me.pic_cerrar_sesion = New System.Windows.Forms.PictureBox
        Me.pic_borrar_rest = New System.Windows.Forms.PictureBox
        Me.pic_borrar_plato = New System.Windows.Forms.PictureBox
        CType(Me.pic_ver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_agregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_cerrar_sesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_borrar_rest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_borrar_plato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_rest
        '
        Me.lst_rest.FormattingEnabled = True
        Me.lst_rest.Location = New System.Drawing.Point(182, 100)
        Me.lst_rest.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_rest.Name = "lst_rest"
        Me.lst_rest.Size = New System.Drawing.Size(91, 134)
        Me.lst_rest.TabIndex = 2
        '
        'lst_platos
        '
        Me.lst_platos.FormattingEnabled = True
        Me.lst_platos.Location = New System.Drawing.Point(317, 100)
        Me.lst_platos.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_platos.Name = "lst_platos"
        Me.lst_platos.Size = New System.Drawing.Size(91, 134)
        Me.lst_platos.TabIndex = 3
        '
        'pic_ver
        '
        Me.pic_ver.Image = CType(resources.GetObject("pic_ver.Image"), System.Drawing.Image)
        Me.pic_ver.Location = New System.Drawing.Point(34, 118)
        Me.pic_ver.Name = "pic_ver"
        Me.pic_ver.Size = New System.Drawing.Size(79, 42)
        Me.pic_ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_ver.TabIndex = 6
        Me.pic_ver.TabStop = False
        '
        'pic_agregar
        '
        Me.pic_agregar.Image = CType(resources.GetObject("pic_agregar.Image"), System.Drawing.Image)
        Me.pic_agregar.Location = New System.Drawing.Point(26, 166)
        Me.pic_agregar.Name = "pic_agregar"
        Me.pic_agregar.Size = New System.Drawing.Size(88, 35)
        Me.pic_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_agregar.TabIndex = 7
        Me.pic_agregar.TabStop = False
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usuario.Font = New System.Drawing.Font("Mouse Deco", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_usuario.Location = New System.Drawing.Point(314, 49)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(0, 21)
        Me.lbl_usuario.TabIndex = 8
        '
        'pic_cerrar_sesion
        '
        Me.pic_cerrar_sesion.Image = CType(resources.GetObject("pic_cerrar_sesion.Image"), System.Drawing.Image)
        Me.pic_cerrar_sesion.Location = New System.Drawing.Point(351, 252)
        Me.pic_cerrar_sesion.Name = "pic_cerrar_sesion"
        Me.pic_cerrar_sesion.Size = New System.Drawing.Size(103, 30)
        Me.pic_cerrar_sesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_cerrar_sesion.TabIndex = 9
        Me.pic_cerrar_sesion.TabStop = False
        '
        'pic_borrar_rest
        '
        Me.pic_borrar_rest.Image = CType(resources.GetObject("pic_borrar_rest.Image"), System.Drawing.Image)
        Me.pic_borrar_rest.Location = New System.Drawing.Point(27, 212)
        Me.pic_borrar_rest.Name = "pic_borrar_rest"
        Me.pic_borrar_rest.Size = New System.Drawing.Size(95, 29)
        Me.pic_borrar_rest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_borrar_rest.TabIndex = 10
        Me.pic_borrar_rest.TabStop = False
        '
        'pic_borrar_plato
        '
        Me.pic_borrar_plato.Image = CType(resources.GetObject("pic_borrar_plato.Image"), System.Drawing.Image)
        Me.pic_borrar_plato.Location = New System.Drawing.Point(23, 246)
        Me.pic_borrar_plato.Name = "pic_borrar_plato"
        Me.pic_borrar_plato.Size = New System.Drawing.Size(103, 23)
        Me.pic_borrar_plato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_borrar_plato.TabIndex = 11
        Me.pic_borrar_plato.TabStop = False
        '
        'frm_app
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(460, 282)
        Me.Controls.Add(Me.pic_borrar_plato)
        Me.Controls.Add(Me.pic_borrar_rest)
        Me.Controls.Add(Me.pic_cerrar_sesion)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.pic_agregar)
        Me.Controls.Add(Me.pic_ver)
        Me.Controls.Add(Me.lst_platos)
        Me.Controls.Add(Me.lst_rest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_app"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menurest"
        CType(Me.pic_ver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_agregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_cerrar_sesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_borrar_rest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_borrar_plato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_rest As System.Windows.Forms.ListBox
    Friend WithEvents lst_platos As System.Windows.Forms.ListBox
    Friend WithEvents pic_ver As System.Windows.Forms.PictureBox
    Friend WithEvents pic_agregar As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents pic_cerrar_sesion As System.Windows.Forms.PictureBox
    Friend WithEvents pic_borrar_rest As System.Windows.Forms.PictureBox
    Friend WithEvents pic_borrar_plato As System.Windows.Forms.PictureBox
End Class
