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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_add))
        Me.pic_nuevo_rest = New System.Windows.Forms.PictureBox
        Me.pic_nuevo_plato = New System.Windows.Forms.PictureBox
        Me.pic_editar_rest = New System.Windows.Forms.PictureBox
        Me.pic_editar_plato = New System.Windows.Forms.PictureBox
        Me.pic_volver = New System.Windows.Forms.PictureBox
        CType(Me.pic_nuevo_rest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_nuevo_plato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_editar_rest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_editar_plato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_volver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_nuevo_rest
        '
        Me.pic_nuevo_rest.BackgroundImage = CType(resources.GetObject("pic_nuevo_rest.BackgroundImage"), System.Drawing.Image)
        Me.pic_nuevo_rest.Image = CType(resources.GetObject("pic_nuevo_rest.Image"), System.Drawing.Image)
        Me.pic_nuevo_rest.Location = New System.Drawing.Point(60, 100)
        Me.pic_nuevo_rest.Name = "pic_nuevo_rest"
        Me.pic_nuevo_rest.Size = New System.Drawing.Size(158, 51)
        Me.pic_nuevo_rest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_nuevo_rest.TabIndex = 10
        Me.pic_nuevo_rest.TabStop = False
        '
        'pic_nuevo_plato
        '
        Me.pic_nuevo_plato.BackgroundImage = CType(resources.GetObject("pic_nuevo_plato.BackgroundImage"), System.Drawing.Image)
        Me.pic_nuevo_plato.Image = CType(resources.GetObject("pic_nuevo_plato.Image"), System.Drawing.Image)
        Me.pic_nuevo_plato.Location = New System.Drawing.Point(226, 100)
        Me.pic_nuevo_plato.Name = "pic_nuevo_plato"
        Me.pic_nuevo_plato.Size = New System.Drawing.Size(158, 51)
        Me.pic_nuevo_plato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_nuevo_plato.TabIndex = 11
        Me.pic_nuevo_plato.TabStop = False
        '
        'pic_editar_rest
        '
        Me.pic_editar_rest.BackgroundImage = CType(resources.GetObject("pic_editar_rest.BackgroundImage"), System.Drawing.Image)
        Me.pic_editar_rest.Image = CType(resources.GetObject("pic_editar_rest.Image"), System.Drawing.Image)
        Me.pic_editar_rest.Location = New System.Drawing.Point(61, 154)
        Me.pic_editar_rest.Name = "pic_editar_rest"
        Me.pic_editar_rest.Size = New System.Drawing.Size(142, 49)
        Me.pic_editar_rest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_editar_rest.TabIndex = 12
        Me.pic_editar_rest.TabStop = False
        '
        'pic_editar_plato
        '
        Me.pic_editar_plato.BackgroundImage = CType(resources.GetObject("pic_editar_plato.BackgroundImage"), System.Drawing.Image)
        Me.pic_editar_plato.Image = CType(resources.GetObject("pic_editar_plato.Image"), System.Drawing.Image)
        Me.pic_editar_plato.Location = New System.Drawing.Point(227, 154)
        Me.pic_editar_plato.Name = "pic_editar_plato"
        Me.pic_editar_plato.Size = New System.Drawing.Size(142, 49)
        Me.pic_editar_plato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_editar_plato.TabIndex = 13
        Me.pic_editar_plato.TabStop = False
        '
        'pic_volver
        '
        Me.pic_volver.Image = CType(resources.GetObject("pic_volver.Image"), System.Drawing.Image)
        Me.pic_volver.Location = New System.Drawing.Point(170, 219)
        Me.pic_volver.Name = "pic_volver"
        Me.pic_volver.Size = New System.Drawing.Size(106, 39)
        Me.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_volver.TabIndex = 14
        Me.pic_volver.TabStop = False
        '
        'frm_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(452, 272)
        Me.Controls.Add(Me.pic_volver)
        Me.Controls.Add(Me.pic_editar_plato)
        Me.Controls.Add(Me.pic_editar_rest)
        Me.Controls.Add(Me.pic_nuevo_plato)
        Me.Controls.Add(Me.pic_nuevo_rest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menurest"
        CType(Me.pic_nuevo_rest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_nuevo_plato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_editar_rest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_editar_plato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_volver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_nuevo_rest As System.Windows.Forms.PictureBox
    Friend WithEvents pic_nuevo_plato As System.Windows.Forms.PictureBox
    Friend WithEvents pic_editar_rest As System.Windows.Forms.PictureBox
    Friend WithEvents pic_editar_plato As System.Windows.Forms.PictureBox
    Friend WithEvents pic_volver As System.Windows.Forms.PictureBox
End Class
