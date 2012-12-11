Imports System.Data.OleDb
Module Funciones
    '*************************************************************
    '                  DECLARACIÓN DE VARIABLES
    '*************************************************************
    'USUARIO
    Public user As String   'Nombre de usuario actual (logueado).
    Public id_user As Integer 'Id de usuario actual (logueado).
    Public id_rest As Integer 'Id del restaurant seleccionado actualmente.
    Public rest As String     'Nombre del restaurant seleccionado actualmente.
    Public plato As String    'Nombre del plato seleccionado actualmente.
    'CONEXIONES A LA DB
    Dim sSQL As String 'String que guarda el query de la consulta.
    Dim conex As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + My.Application.Info.DirectoryPath + "\db_menurest1.mdb") 'objeto de Conexión.
    Dim comm As New OleDbCommand    'objeto de Comandos.
    Dim dr As OleDbDataReader       'DataReader.
    Dim dt As New DataTable         'DataTable.
    Dim ds As DataSet               'DataSet.
    'VALIDACIONES
    Public valida_r As Boolean 'Bandera usada para validar el registro.
    Public valida_rest As Boolean 'Bandera usada para validar datos de restaurantes.

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
    'Valida datos del restaurante.
    Sub validar_rest()
        If (frm_edicion_rest.txt_nombre_rest.Text = "") Or (frm_edicion_rest.txt_descripcion_rest.Text = "") Or (frm_edicion_rest.txt_tel_rest.Text = "") Or (frm_edicion_rest.txt_dir_rest.Text = "") Then
            MsgBox("Los datos ingresados no son válidos")
            valida_rest = False
            limpiar_edit_rest()
        Else
            If (IsNumeric(frm_edicion_rest.txt_tel_rest.Text) = False) Or (Strings.Len(frm_edicion_rest.txt_tel_rest.Text) < 7) Then
                MsgBox("El teléfono debe ser un número de al menos 7 cifras")
                valida_rest = False
                limpiar_edit_rest()
            Else
                valida_rest = True
            End If

        End If

    End Sub
    '*************************************************************
    '              CONEXIONES A LA BASE DE DATOS
    '*************************************************************
    'Conectarse con la base de datos.
    Sub CONECTAR(ByVal sSQL As String)
        Try
            conex.Close()
            'Query de consulta.
            comm.CommandText = sSQL
            'Asignamos la conexión al commando.
            comm.Connection = conex
            'Abrir conexión.
            conex.Open()

        Catch ex As Exception
            MsgBox("Error al conectarse con la DB: " & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub
    '-------------------------------------------------------------
    'Loguearse con un user y pass registrado.
    Sub LOGIN()

        sSQL = "Select * from usuarios where nombre = '" & frm_login.txt_nombre.Text & "' and pass = '" & frm_login.txt_pass.Text & "'"

        'Abre la conexión con la db.
        CONECTAR(sSQL)

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
    '-------------------------------------------------------------
    'Registrar un nuevo user y password.
    Sub REGISTRARSE()
        Try
            'Valida los datos ingresados en el form de registro.
            Funciones.validar_registro()
            If (Funciones.valida_r = True) Then

                'Query de consulta.
                sSQL = "Select * from usuarios where nombre = '" & frm_registro.txt_nombre.Text & "'"
                'Abre la conexión con la db.
                CONECTAR(sSQL)
                'Consulta.
                dt.TableName = "usuarios"
                dt.Load(comm.ExecuteReader())
                'Verifica que el usuario no exista en la db.
                If (dt.Rows.Count > 0) Then
                    'El usuario ya se encuentra registrado.
                    MsgBox("El nombre de usuario ingresado no está disponible. Por favor elija otro.")
                    limpiar_registro()
                Else
                    'Query.
                    sSQL = "insert into usuarios(nombre,pass) values('" & frm_registro.txt_nombre.Text & "','" & frm_registro.txt_pass.Text & "')"
                    'Abre la conexión.
                    CONECTAR(sSQL)

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
    End Sub
    '-------------------------------------------------------------
    'Mostrar listas de restaurantes y de platos.
    Sub MOSTRAR(ByVal sSQL As String, ByVal lista As ListBox)
        Try
            'Abrimos conexión con la db.
            CONECTAR(sSQL)
            'Consulta.
            dr = comm.ExecuteReader

            lista.Items.Clear() 'Se limpia el contenido de la lista rest.

            While dr.Read
                'Se agregan los rest vinculados al usuario actual a la lista.
                lista.Items.Add(dr.Item(2))
            End While
        Catch ex As Exception
            MsgBox("Error en la conexión a la DB" & vbCrLf & vbCrLf & ex.Message)
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
        Dim index As Integer = frm_app.lst_rest.SelectedIndex 'Guardo el índice del elemento seleccionado.
        rest = frm_app.lst_rest.SelectedItem

        'Query de consulta (Buscar id de restaurante).
        sSQL = "Select * from rest where nombre = '" & frm_app.lst_rest.SelectedItem & "'"

        'Abrimos conexión con la db.
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
    '-------------------------------------------------------------
    'Muestra los detalles del plato seleccionado.
    Sub ver_plato()

        sSQL = "Select * from platos where nombre = '" & plato & "' and id_rest = " & id_rest

        'Abrimos la conexión con la db.
        CONECTAR(sSQL)
        'Consulta.
        dr = comm.ExecuteReader

        If (dr.Read) Then
            frm_show.lbl_nombre_plato.Text = dr(2)
            frm_show.lbl_descripcion_plato.Text = dr(3)
            frm_show.lbl_precio.Text = dr(4)
            frm_show.lbl_nombre_rest.Text = rest
        End If
    End Sub
    '-------------------------------------------------------------
    ' Agregar nuevo restaurant.
    Sub add_rest()

        Try
            'Query.
            sSQL = "Select *  from rest where id_usuario = " & id_user & " and nombre = '" & frm_edicion_rest.txt_nombre_rest.Text & "'"

            CONECTAR(sSQL) 'Abrimos conexión con la db.

            dt.Reset()
            dt.Load(comm.ExecuteReader)

            'Verifico si el nombre ya existe.
            If (dt.Rows.Count > 0) Then
                MsgBox("El nombre del restaurante ingresado ya se encuentra en su lista")
                limpiar_edit_rest()
            Else
                'Query.
                sSQL = "insert into rest(id_usuario, nombre,descripcion, telefono, direccion) values(" & id_user & ",'" & frm_edicion_rest.txt_nombre_rest.Text & "', '" & frm_edicion_rest.txt_descripcion_rest.Text & "', " & Convert.ToInt64(frm_edicion_rest.txt_tel_rest.Text) & ",'" & frm_edicion_rest.txt_dir_rest.Text & "')"
                'Abre la conexión.
                CONECTAR(sSQL)

                comm.ExecuteNonQuery()

                'Muestra un mensaje y vuelve al form de edición.
                MsgBox("Nuevo restaurant creado correctamente.")
                limpiar_edit_rest()
                frm_add.Show()
                frm_edicion_rest.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error en la conexión a la DB" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub
    'Editar un restaurante que ya se encuentra en la cuenta del usuario.
    Sub edit_rest()
        Try
            'Query.
            sSQL = "Select *  from rest where id_usuario = " & id_user & " and nombre = '" & frm_edicion_rest.txt_nombre_rest.Text & "'"

            CONECTAR(sSQL) 'Abrimos conexión con la db.

            dt.Reset()
            dt.Load(comm.ExecuteReader)

            'Verifico si el nombre ya existe.
            If (dt.Rows.Count > 0) Then

                'Query.
                sSQL = "update rest set id_usuario = '" & id_user & "', nombre = '" & frm_edicion_rest.txt_nombre_rest.Text & "',descripcion = '" & frm_edicion_rest.txt_descripcion_rest.Text & "', telefono = " & Convert.ToInt64(frm_edicion_rest.txt_tel_rest.Text) & ", direccion = '" & frm_edicion_rest.txt_dir_rest.Text & "' where id_rest = " & dt.Rows.Item(0).Item(0) & ""

                If (MsgBox("¿Está seguro de querer modificar un restaurante ya existente?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok) Then
                    'Abre la conexión.
                    CONECTAR(sSQL)
                    comm.ExecuteNonQuery()
                    MsgBox("Restaurante modificado correctamente.")
                    frm_add.Show()
                    frm_edicion_rest.Close()

                Else
                    frm_add.Show()
                    frm_edicion_rest.Close()
                End If
            Else
                MsgBox("El restaurante que desea modificar no existe")
            End If
        Catch ex As Exception
            MsgBox("Error en la conexión a la DB" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub

    '*************************************************************
    '                         LIMPIAR
    '*************************************************************
    'Limpiar todos los campos del login.
    Sub limpiar_login()
        frm_login.txt_nombre.Focus()
        frm_login.txt_nombre.Text = ""
        frm_login.txt_pass.Text = ""

    End Sub
    'Limpiar todos los campos del registro.
    Sub limpiar_registro()
        frm_registro.txt_nombre.Text = ""
        frm_registro.txt_pass.Text = ""
        frm_registro.txt_pass_confirm.Text = ""
        frm_registro.txt_nombre.Focus()
    End Sub
    'Limpiar todos los campos del show.
    Sub limpiar_show()
        frm_show.lbl_nombre_plato.Text = ""
        frm_show.lbl_descripcion_plato.Text = ""
        frm_show.lbl_precio.Text = ""
        frm_show.lbl_nombre_rest.Text = ""
    End Sub
    'Limpiar todos los campos del form agregar rest
    Sub limpiar_edit_rest()
        frm_edicion_rest.txt_nombre_rest.Text = ""
        frm_edicion_rest.txt_descripcion_rest.Text = ""
        frm_edicion_rest.txt_tel_rest.Text = ""
        frm_edicion_rest.txt_dir_rest.Text = ""
        frm_edicion_rest.txt_nombre_rest.Focus()
    End Sub

End Module
