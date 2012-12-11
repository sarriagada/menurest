Public Class frm_edicion_rest
    '*************************************************************
    '    GUARDAR CAMBIOS EN LA CREACIÓN/EDICIÓN DE RESTAURANTES
    '*************************************************************
    Private Sub pic_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_guardar.Click
        validar_rest()
        If (Funciones.valida_rest = True) Then
            If (Me.Text = "Agregar restaurante") Then
                Funciones.add_rest()
            Else
                Funciones.edit_rest()
            End If
        End If
    End Sub
    '*************************************************************
    '                      CANCELAR
    '*************************************************************
    Private Sub pic_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_cancelar.Click
        frm_add.Show()
        Me.Close()
    End Sub
End Class