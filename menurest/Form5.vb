Public Class frm_add
    '*************************************************************
    '              AGREGAR NUEVO RESTAURANTE
    '*************************************************************

    Private Sub pic_nuevo_rest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_nuevo_rest.Click
        frm_edicion_rest.Show()
        frm_edicion_rest.Text = "Agregar restaurante"
        Me.Close()
    End Sub
    '*************************************************************
    '              EDITAR RESTAURANTE
    '*************************************************************
    Private Sub pic_editar_rest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_editar_rest.Click
        frm_edicion_rest.Show()
        frm_edicion_rest.Text = "Editar restaurante"
        Me.Close()
    End Sub

    '*************************************************************
    '              VOLVER A LA APLICACIÓN
    '*************************************************************
    Private Sub pic_volver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_volver.Click
        frm_app.Show() 'Regresa al formulario de la aplicación.
        Me.Hide()
    End Sub
End Class