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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_show))
        Me.lbl_nombre_plato = New System.Windows.Forms.Label
        Me.lbl_descripcion_plato = New System.Windows.Forms.Label
        Me.lbl_nombre_rest = New System.Windows.Forms.Label
        Me.lbl_precio = New System.Windows.Forms.Label
        Me.pic_volver = New System.Windows.Forms.PictureBox
        CType(Me.pic_volver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre_plato
        '
        Me.lbl_nombre_plato.AutoSize = True
        Me.lbl_nombre_plato.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre_plato.Font = New System.Drawing.Font("Mouse Deco", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_plato.ForeColor = System.Drawing.Color.White
        Me.lbl_nombre_plato.Location = New System.Drawing.Point(111, 23)
        Me.lbl_nombre_plato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre_plato.Name = "lbl_nombre_plato"
        Me.lbl_nombre_plato.Size = New System.Drawing.Size(171, 21)
        Me.lbl_nombre_plato.TabIndex = 0
        Me.lbl_nombre_plato.Text = "nombre plato"
        '
        'lbl_descripcion_plato
        '
        Me.lbl_descripcion_plato.AutoSize = True
        Me.lbl_descripcion_plato.BackColor = System.Drawing.Color.Transparent
        Me.lbl_descripcion_plato.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion_plato.ForeColor = System.Drawing.Color.White
        Me.lbl_descripcion_plato.Location = New System.Drawing.Point(13, 58)
        Me.lbl_descripcion_plato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_descripcion_plato.Name = "lbl_descripcion_plato"
        Me.lbl_descripcion_plato.Size = New System.Drawing.Size(99, 18)
        Me.lbl_descripcion_plato.TabIndex = 1
        Me.lbl_descripcion_plato.Text = "descripcion"
        '
        'lbl_nombre_rest
        '
        Me.lbl_nombre_rest.AutoSize = True
        Me.lbl_nombre_rest.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre_rest.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_rest.ForeColor = System.Drawing.Color.White
        Me.lbl_nombre_rest.Location = New System.Drawing.Point(124, 153)
        Me.lbl_nombre_rest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre_rest.Name = "lbl_nombre_rest"
        Me.lbl_nombre_rest.Size = New System.Drawing.Size(40, 18)
        Me.lbl_nombre_rest.TabIndex = 2
        Me.lbl_nombre_rest.Text = "rest"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_precio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.ForeColor = System.Drawing.Color.White
        Me.lbl_precio.Location = New System.Drawing.Point(78, 201)
        Me.lbl_precio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(57, 18)
        Me.lbl_precio.TabIndex = 5
        Me.lbl_precio.Text = "precio"
        '
        'pic_volver
        '
        Me.pic_volver.BackColor = System.Drawing.Color.Transparent
        Me.pic_volver.Location = New System.Drawing.Point(203, 264)
        Me.pic_volver.Name = "pic_volver"
        Me.pic_volver.Size = New System.Drawing.Size(100, 24)
        Me.pic_volver.TabIndex = 6
        Me.pic_volver.TabStop = False
        '
        'frm_show
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(310, 300)
        Me.Controls.Add(Me.pic_volver)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.lbl_nombre_rest)
        Me.Controls.Add(Me.lbl_descripcion_plato)
        Me.Controls.Add(Me.lbl_nombre_plato)
        Me.Font = New System.Drawing.Font("Neuropol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimizeBox = False
        Me.Name = "frm_show"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menurest"
        CType(Me.pic_volver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre_plato As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion_plato As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_rest As System.Windows.Forms.Label
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents pic_volver As System.Windows.Forms.PictureBox
End Class
