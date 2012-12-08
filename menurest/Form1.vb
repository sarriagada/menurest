Imports System.Data.OleDb
Public Class frm_login
    '************************************************
    'Efecto al pasar el mouse por el bot�n ENTRAR.
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

    Private Sub pic_registrarse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_registrarse.Click
        'Al hacer click se abre el form Registro.
        frm_registro.Show()
        Me.Hide()
    End Sub

    Private Sub pic_entrar_on_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_entrar_on.Click
        Dim conex As New OleDbConnection 'objeto de Conexi�n.
        Dim comm As New OleDbCommand     'objeto de Comandos.
        Dim dr As OleDbDataReader        'DataReader.

        Try
            'Cadena de conexi�n.
            conex.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + My.Application.Info.DirectoryPath + "\db_menurest1.mdb"

            'Abrir conexi�n.
            conex.Open()

            'Query de consulta.
            comm.CommandText = "Select * from usuarios where nombre = '" + txt_nombre.Text + "' and pass = '" + txt_pass.Text + "'"

            'Asignamos la conexi�n al commando.
            comm.Connection = conex

            'Consulta.
            dr = comm.ExecuteReader()

            'Validaci�n de resultados.
            If (dr.HasRows) Then
                'Guardo el nombre de usuario activo.
                Funciones.user = txt_nombre.Text

                'Se abre la aplicaci�n y se oculta el form de login.
                frm_app.Show()
                Me.Hide()
            Else
                MsgBox("Usuario o contrase�a inv�lidos.")
            End If

            conex.Close()

        Catch ex As Exception
            MsgBox("Error al conectarse con la DB: " + vbCrLf + vbCrLf + ex.Message)
        End Try
        

    End Sub
End Class
