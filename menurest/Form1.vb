Public Class frm_login
    '************************************************
    'Efecto al pasar el mouse por el botón ENTRAR.
    'Se oculta una imagen y se muestra otra para simularlo.
    
    '************************************************

    Private Sub pic_registrarse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Al hacer click se abre el form Registro.
        frm_registro.Show()
        Me.Hide()
    End Sub

    Private Sub Label_hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_entrar.MouseHover, lbl_registro.MouseHover
        sender.ForeColor = Color.Black
    End Sub
    Private Sub Label_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_entrar.MouseLeave, lbl_registro.MouseLeave
        sender.ForeColor = Color.DarkGray
    End Sub
End Class
