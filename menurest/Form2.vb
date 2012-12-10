Imports System.Data.OleDb
Public Class frm_registro
    '*************************************************************
    '                     REGISTRARSE
    '*************************************************************
    Private Sub pic_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_guardar.Click
        Funciones.CONECTAR()
        Funciones.REGISTRARSE()
    End Sub
    '*************************************************************
    '                 CANCELAR 
    '*************************************************************
    Private Sub pic_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_cancelar.Click
        'Al hacer click se cierra el formulario y regresa al form login.
        frm_login.Show()
        Me.Hide()
    End Sub
End Class