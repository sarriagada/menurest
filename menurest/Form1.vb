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

    Private Sub pic_registrarse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_registrarse.Click
        'Al hacer click se abre el form Registro.
        frm_registro.Show()
        Me.Hide()
    End Sub

    Private Sub pic_entrar_on_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_entrar_on.Click
        Dim conex As New OleDbConnection 'objeto de Conexión.
        Dim comm As New OleDbCommand     'objeto de Comandos.
        Dim dr As OleDbDataReader        'DataReader.

        Try
            'Cadena de conexión.
            conex.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + My.Application.Info.DirectoryPath + "\db_menurest1.mdb"

            'Abrir conexión.
            conex.Open()

            'Query de consulta.
            comm.CommandText = "Select * from usuarios where nombre = '" + txt_nombre.Text + "' and pass = '" + txt_pass.Text + "'"

            'Asignamos la conexión al commando.
            comm.Connection = conex

            'Consulta.
            dr = comm.ExecuteReader()

            'Validación de resultados.
            If (dr.HasRows) Then
                'Guardo el nombre de usuario activo.
                Funciones.user = txt_nombre.Text

                'Se abre la aplicación y se oculta el form de login.
                frm_app.Show()
                Me.Hide()
            Else
                MsgBox("Usuario o contraseña inválidos.")
            End If

            conex.Close()

        Catch ex As Exception
            MsgBox("Error al conectarse con la DB: " + vbCrLf + vbCrLf + ex.Message)
        End Try
        

    End Sub
End Class
