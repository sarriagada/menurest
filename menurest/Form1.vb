Imports System.Data.OleDb
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
    '                LOGIN
    '************************************************
    Private Sub pic_entrar_on_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_entrar_on.Click
        Funciones.LOGIN()    'Se loguea.
    End Sub
    Private Sub frm_login_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Funciones.LOGIN()    'Se loguea.
        End If
    End Sub
    '************************************************
    '                REGISTRARSE
    '************************************************
    'Abre el formulario de registro.
    Private Sub pic_registrarse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_registrarse.Click
        'Al hacer click se abre el form Registro.
        frm_registro.Show()
        Funciones.limpiar_registro()
        Me.Hide()
    End Sub
    '************************************************
    '                SALIR
    '************************************************
    Private Sub pic_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_salir.Click
        Funciones.salir()
    End Sub


End Class
