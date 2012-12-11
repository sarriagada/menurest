Public Class frm_show

    

    '*************************************************************
    '              DETALLES DEL PLATO SELECCIONADO
    '*************************************************************

    Private Sub frm_show_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Funciones.limpiar_show() 'Limpia los lbl del form show.
        Funciones.ver_plato() 'Muestra los datos del plato seleccionado.
    End Sub

    '*************************************************************
    '              VOLVER A LA APLICACIÓN
    '*************************************************************
    Private Sub pic_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_volver.Click
        frm_app.Show() 'Regresa al formulario de la aplicación.
        Me.Hide()
    End Sub
End Class