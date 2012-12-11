Public Class frm_edicion_platos

    '*************************************************************
    '             CARGAR RESTAURANTES DISPONIBLES
    '*************************************************************

    Private Sub frm_edicion_platos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Query de consulta.
        Funciones.sSQL = "Select * from rest where id_usuario = " & id_user

        MOSTRAR(Funciones.sSQL, Me.lst_restaurantes) 'Mostrar lista de rest.
    End Sub
    '*************************************************************
    '                      GUARDAR RESTAURANTE SELECCIONADO
    '*************************************************************
    Private Sub lst_restaurantes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_restaurantes.SelectedIndexChanged
        Funciones.rest = lst_restaurantes.SelectedItem
    End Sub
    '*************************************************************
    '                      GUARDAR
    '*************************************************************
    Private Sub pic_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_guardar.Click
        If (lst_restaurantes.SelectedIndex = -1) Then
            MsgBox("Debe seleccionar el restaurant al que quiere agregar/modificar platos")
        Else
            If (Me.Text = "Agregar platos") Then
                Funciones.add_plato()
            Else
                Funciones.edit_plato()
            End If
        End If
    End Sub
    '*************************************************************
    '                       VOLVER
    '*************************************************************
    Private Sub pic_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_volver.Click
        frm_add.Show()
        Me.Close()
    End Sub
End Class