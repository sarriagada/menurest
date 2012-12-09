Imports System.Data.OleDb
Public Class frm_registro

    '*************************************************************
    'GUARDAR DATOS DE REGISTRO.
    '*************************************************************
    Private Sub pic_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_guardar.Click
        
        Try
            Funciones.validar_registro()
            If (Funciones.valida_r = True) Then
                Dim conex As New OleDbConnection 'Objeto Conexión.

                'Cadena de conexión.
                conex.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + My.Application.Info.DirectoryPath + "\db_menurest1.mdb"

                'Abrir conexión.
                conex.Open()
                Dim comm As New OleDbCommand("insert into usuarios(nombre,pass) values('" & txt_nombre.Text & "','" & txt_pass.Text & "')", conex)

                comm.ExecuteNonQuery()
                conex.Close()
                'Muestra un mensaje y vuelve al form de login.
                MsgBox("Nuevo usuario creado correctamente." & vbCrLf & vbCrLf & "Ya puede ingresar con su usuario y contraseña")
                frm_login.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error en la conexión a la DB" & vbCrLf & vbCrLf & ex.Message)
        End Try
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