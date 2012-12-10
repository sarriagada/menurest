Imports System.Data.OleDb
Module Funciones
    '*************************************************************
    '                  DECLARACI�N DE VARIABLES
    '*************************************************************
    'USUARIO
    Public user As String   'Nombre de usuario actual (logueado).
    Public id_user As Integer 'Id de usuario actual (logueado).
    Public id_rest As Integer 'Id del restaurant seleccionado actualmente.
    'CONEXIONES A LA DB
    Dim sSQL As String 'String que guarda el query de la consulta.
    Dim conex As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + My.Application.Info.DirectoryPath + "\db_menurest1.mdb") 'objeto de Conexi�n.
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
        'Valida que el nombre de usuario elegido sea v�lido.
        If (Strings.Len(frm_registro.txt_nombre.Text) < 4 Or frm_registro.txt_nombre.Text = " ") Then
            MsgBox("El nombre de usuario ingresado no es v�lido")
            limpiar_registro()
        Else
            'Valida que el password elegido sea v�lido.
            If (Strings.Len(frm_registro.txt_pass.Text) < 4 Or frm_registro.txt_pass.Text = " ") Then
                MsgBox("El password ingresado no es v�lido")
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
    Sub CONECTAR(ByVal sSQL As String)
        Try
            'Query de consulta.
            comm.CommandText = sSQL
            'Asignamos la conexi�n al commando.
            comm.Connection = conex
            'Abrir conexi�n.
            conex.Open()

        Catch ex As Exception
            MsgBox("Error al conectarse con la DB: " & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub
    '-------------------------------------------------------------
    'Loguearse con un user y pass registrado.
    Sub LOGIN()

        sSQL = "Select * from usuarios where nombre = '" & frm_login.txt_nombre.Text & "' and pass = '" & frm_login.txt_pass.Text & "'"

        'Abre la conexi�n con la db.
        CONECTAR(sSQL)

        'Consulta.
        dr = comm.ExecuteReader()

        'Validaci�n de resultados.
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

            'Se abre la aplicaci�n y se oculta el form de login.
            frm_app.Show()
            frm_login.Hide()
        Else
            MsgBox("Usuario o contrase�a inv�lidos.")
            limpiar_login()
        End If

        'Cierro la conexi�n.
        dr.Close()
        conex.Close()

    End Sub
    '-------------------------------------------------------------
    'Registrar un nuevo user y password.
    Sub REGISTRARSE()
        Try
            'Valida los datos ingresados en el form de registro.
            Funciones.validar_registro()
            If (Funciones.valida_r = True) Then

                'Query de consulta.
                sSQL = "Select * from usuarios where nombre = '" & frm_registro.txt_nombre.Text & "'"
                'Abre la conexi�n con la db.
                CONECTAR(sSQL)
                'Consulta.
                dt.TableName = "usuarios"
                dt.Load(comm.ExecuteReader())
                'Verifica que el usuario no exista en la db.
                If (dt.Rows.Count > 0) Then
                    'El usuario ya se encuentra registrado.
                    MsgBox("El nombre de usuario ingresado no est� disponible. Por favor elija otro.")
                    limpiar_registro()
                Else
                    conex.Close()
                    'Query.
                    sSQL = "insert into usuarios(nombre,pass) values('" & frm_registro.txt_nombre.Text & "','" & frm_registro.txt_pass.Text & "')"
                    'Abre la conexi�n.
                    CONECTAR(sSQL)

                    comm.ExecuteNonQuery()

                    'Muestra un mensaje y vuelve al form de login.
                    MsgBox("Nuevo usuario creado correctamente." & vbCrLf & vbCrLf & "Ya puede ingresar con su usuario y contrase�a")
                    frm_login.Show()
                    frm_registro.Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en la conexi�n a la DB" & vbCrLf & vbCrLf & ex.Message)
        End Try

        'Cierro la conexi�n.
        dt.Reset()
        conex.Close()
    End Sub
    '-------------------------------------------------------------
    'Mostrar listas de restaurantes y de platos.
    Sub MOSTRAR(ByVal sSQL As String, ByVal lista As ListBox)
        Try
            conex.Close()
            'Abrimos conexi�n con la db.
            CONECTAR(sSQL)
            'Consulta.
            dr = comm.ExecuteReader

            lista.Items.Clear() 'Se limpia el contenido de la lista rest.

            While dr.Read
                'Se agregan los rest vinculados al usuario actual a la lista.
                lista.Items.Add(dr.Item(2))
            End While
        Catch ex As Exception
            MsgBox("Error en la conexi�n a la DB" & vbCrLf & vbCrLf & ex.Message)
        End Try

        dr.Close()
        conex.Close()

    End Sub

    '-------------------------------------------------------------
    'Muestra la lista de restaurantes asociados a la id del usuario activo.
    Sub MOSTRAR_REST()
        'Query de consulta.
        sSQL = "Select * from rest where id_usuario = " & id_user

        MOSTRAR(sSQL, frm_app.lst_rest) 'Mostrar lista de rest.

    End Sub
    '-------------------------------------------------------------
    'Muestra la lista de platos en los restaurantes asociados a la id del usuario activo.
    Sub MOSTRAR_PLATOS()
        Dim index As Integer = frm_app.lst_rest.SelectedIndex 'Guardo el �ndice del elemento seleccionado.

        'Query de consulta (Buscar id de restaurante).
        sSQL = "Select * from rest where nombre = '" & frm_app.lst_rest.SelectedItem & "'"

        'Abrimos conexi�n con la db.
        conex.Close()
        CONECTAR(sSQL)
        'Consulta.
        dr = comm.ExecuteReader

        'Guardo la id del restaurant actual
        If (dr.Read) Then
            id_rest = dr(0)
        End If

        'Query de consulta (Mostrar platos asociados al restaurante actual).
        sSQL = "Select * from platos where id_rest = " & id_rest

        MOSTRAR(sSQL, frm_app.lst_platos) 'Mostrar lista de platos.

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