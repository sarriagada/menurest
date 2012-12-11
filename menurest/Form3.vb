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
    '                  SELECCIONAR PLATO
    '*************************************************************
    Private Sub lst_platos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_platos.SelectedIndexChanged
        Funciones.plato = lst_platos.SelectedItem
    End Sub
    '*************************************************************
    '                  AGREGAR/EDITAR RESTAURANTES
    '*************************************************************
    Private Sub pic_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_agregar.Click
        frm_add.Show() 'Abre el formulario de edición.
        Me.Close()
    End Sub
    '*************************************************************
    '                  VER DETALLES DE PLATOS 
    '*************************************************************
    Private Sub pic_ver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ver.Click
        If (lst_platos.SelectedIndex = -1) Then
            MsgBox("Debe seleccionar un plato para mostrar sus detalles.")
        Else
            frm_show.Show() 'Abre el formulario de detalles de platos.
            Me.Hide()
        End If
    End Sub
    '*************************************************************
    '                  CERRAR SESIÓN
    '*************************************************************
    Private Sub pic_cerrar_sesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_cerrar_sesion.Click
        Funciones.user = ""
        Funciones.limpiar_login()
        frm_login.Show()
        Me.Close()

    End Sub

    Private Sub pic_borrar_plato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_borrar_plato.Click
        Funciones.borrar_plato()
    End Sub

    Private Sub pic_borrar_rest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_borrar_rest.Click
        Funciones.borrar_restaurant()
    End Sub
End Class