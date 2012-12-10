Imports System.Data.OleDb
Module Funciones
    '*************************************************************
    '                  DECLARACIÓN DE VARIABLES
    '*************************************************************
    'USUARIO
    Public user As String   'Nombre de usuario actual (logueado).
    Public id_user As Integer 'Id de usuario actual (logueado).
    'CONEXIONES A LA DB
    Dim conex As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + My.Application.Info.DirectoryPath + "\db_menurest1.mdb") 'objeto de Conexión.
    Dim comm As New OleDbCommand    'objeto de Comandos.
    Dim dr As OleDbDataReader       'DataReader.
    Dim dt As New DataTable         'DataTable.
    Dim ds As DataSet               'DataSet.
    'VALIDACIONES
    Public valida_r As Boolean 'Bandera usada para validar el registro.

    '*************************************************************
    '                      VALIDACIONES
    '*************************************************************
    Sub validar_registro()
        valida_r = False
        'Valida que el nombre de usuario elegido sea válido.
        If (Strings.Len(frm_registro.txt_nombre.Text) < 4 Or frm_registro.txt_nombre.Text = " ") Then
            MsgBox("El nombre de usuario ingresado no es válido")
            limpiar_registro()
        Else
            'Valida que el password elegido sea válido.
            If (Strings.Len(frm_registro.txt_pass.Text) < 4 Or frm_registro.txt_pass.Text = " ") Then
                MsgBox("El password ingresado no es válido")
                limpiar_registro()
            Else
                'Verifica que los password coincidan.
                If (frm_registro.txt_pass.Text <> frm_registro.txt_pass_confirm.Text) Then
                    MsgBox("Los password no coinciden")
                    limpiar_registro()
                Else
                    valida_r = True
                End If
            End If
        End If
    End Sub
    '*************************************************************
    '              CONEXIONES A LA BASE DE DATOS
    '*************************************************************
    'Conectarse con la base de datos.
    Sub CONECTAR()
        Try
            'Abrir conexión.
            conex.Open()

            'Asignamos la conexión al commando.
            comm.Connection = conex

        Catch ex As Exception
            MsgBox("Error al conectarse con la DB: " + vbCrLf + vbCrLf + ex.Message)
        End Try
    End Sub
    'Loguearse con un user y pass registrado.
    Sub LOGIN()
        'Query de consulta.
        comm.CommandText = "Select * from usuarios where nombre = '" & frm_login.txt_nombre.Text & "' and pass = '" & frm_login.txt_pass.Text & "'"
        'Consulta.
        dr = comm.ExecuteReader()

        'Validación de resultados.
        If (dr.HasRows) Then
            'Guardo el nombre de usuario activo.
            user = frm_login.txt_nombre.Text

            'Guardo el id de usuario activo.
            'Para ello hago una lectura del campo 0 del datareader.
            If (dr.Read) Then
                id_user = dr(0)
            Else
                MsgBox("Error al leer id de usuario de la DB.")
            End If

            'Se abre la aplicación y se oculta el form de login.
            frm_app.Show()
            frm_login.Hide()
        Else
            MsgBox("Usuario o contraseña inválidos.")
            limpiar_login()
        End If

        'Cierro la conexión.
        dr.Close()
        conex.Close()

    End Sub
    'Registrar un nuevo user y password.
    Sub REGISTRARSE()
        Try
            'Valida los datos ingresados en el form de registro.
            Funciones.validar_registro()
            If (Funciones.valida_r = True) Then
                'Query de consulta.
                comm.CommandText = "Select * from usuarios where nombre = '" & frm_registro.txt_nombre.Text & "'"
                'Consulta.
                dt.TableName = "usuarios"
                dt.Load(comm.ExecuteReader())
                'Verifica que el usuario no exista en la db.
                If (dt.Rows.Count > 0) Then
                    'El usuario ya se encuentra registrado.
                    MsgBox("El nombre de usuario ingresado no está disponible. Por favor elija otro.")
                    limpiar_registro()
                Else
                    comm.Connection = conex
                    comm.CommandText = "insert into usuarios(nombre,pass) values('" & frm_registro.txt_nombre.Text & "','" & frm_registro.txt_pass.Text & "')"

                    comm.ExecuteNonQuery()

                    'Muestra un mensaje y vuelve al form de login.
                    MsgBox("Nuevo usuario creado correctamente." & vbCrLf & vbCrLf & "Ya puede ingresar con su usuario y contraseña")
                    frm_login.Show()
                    frm_registro.Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en la conexión a la DB" & vbCrLf & vbCrLf & ex.Message)
        End Try

        'Cierro la conexión.
        dt.Reset()
        conex.Close()


    End Sub

    '*************************************************************
    '                         LIMPIAR
    '*************************************************************
    'Limpiar todos los campos del login.
    Sub limpiar_login()
        frm_login.txt_nombre.Text = ""
        frm_login.txt_pass.Text = ""
        frm_login.txt_nombre.Focus()
    End Sub
    'Limpiar todos los campos del registro.
    Sub limpiar_registro()
        frm_registro.txt_nombre.Text = ""
        frm_registro.txt_pass.Text = ""
        frm_registro.txt_pass_confirm.Text = ""
        frm_registro.txt_nombre.Focus()
    End Sub

End Module
