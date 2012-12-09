Module Funciones
    Public user As String   'Nombre de usuario actual (logueado).
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
