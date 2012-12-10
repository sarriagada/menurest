Imports System.Data.OleDb
Public Class frm_app
    '*************************************************************
    '               MOSTRAR RESTAURANTES DEL USUARIO
    '*************************************************************
    Private Sub frm_app_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_usuario.Text = Funciones.user
        Funciones.MOSTRAR_REST() 'Muestra los restaurantes del usuario actual.
    End Sub
    '*************************************************************
    ' MOSTRAR PLATOS DE LOS RESTAURANTES DEL USUARIO SELECCIONADOS
    '*************************************************************
    Private Sub lst_rest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_rest.SelectedIndexChanged
        MOSTRAR_PLATOS() 'Muestra los platos del restaurante seleccionado del usuario actual.
    End Sub
    '*************************************************************
    '                  AGREGAR/EDITAR RESTAURANTES
    '*************************************************************
    Private Sub pic_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_agregar.Click
        frm_add.Show() 'Abre el formulario de edición.
        Me.Hide()
    End Sub
    '*************************************************************
    '                  VER DETALLES DE PLATOS 
    '*************************************************************
    Private Sub pic_ver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ver.Click
        frm_show.Show() 'Abre el formulario de detalles de platos.
        Me.Hide()
    End Sub
End Class