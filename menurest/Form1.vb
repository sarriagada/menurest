Public Class frm_login
    '************************************************
    'Efecto al pasar el mouse por el botón ENTRAR.
    'Se oculta una imagen y se muestra otra para simularlo.
    Private Sub pic_entrar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_entrar.MouseEnter
        pic_entrar.Visible = False
        pic_entrar_on.Visible = True
    End Sub
    Private Sub pic_entrar_on_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_entrar_on.MouseLeave
        pic_entrar_on.Visible = False
        pic_entrar.Visible = True
    End Sub
    '************************************************
End Class
