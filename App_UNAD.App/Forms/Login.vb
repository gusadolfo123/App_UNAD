Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlRegister.Visible = False
        pnlLogin.Visible = True
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub

    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked
        pnlLogin.Visible = True
        pnlRegister.Visible = False
    End Sub

    Private Sub linkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegister.LinkClicked
        pnlRegister.Visible = True
        pnlLogin.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Metodo sobreescrito para que se pueda mover la pantalla cuando la propiedad formborderstyle = none
    ''' <UrlResource>https://stackoverflow.com/questions/1241812/how-to-move-a-windows-form-when-its-formborderstyle-property-is-set-to-none</UrlResource>
    ''' </summary>
    ''' <param name="m"></param>
    Protected Overrides Sub WndProc(ByRef m As Message)

        Select Case m.Msg
            Case &H84
                MyBase.WndProc(m)
                If CInt(m.Result = &H1) Then
                    m.Result = CType(&H2, IntPtr)
                End If
                Return
        End Select

        MyBase.WndProc(m)
    End Sub

    Private Sub txtEmailReg_GotFocus(sender As Object, e As EventArgs) Handles txtEmailReg.GotFocus
        If Trim(txtEmailReg.Text) = "Correo Institucional" Then
            txtEmailReg.Text = ""
        End If
    End Sub

    Private Sub txtEmailReg_LostFocus(sender As Object, e As EventArgs) Handles txtEmailReg.LostFocus
        If Trim(txtEmailReg.Text) = "" Then
            txtEmailReg.Text = "Correo Institucional"
        End If
    End Sub

    Private Sub txtDocumentReg_GotFocus(sender As Object, e As EventArgs) Handles txtDocumentReg.GotFocus
        If Trim(txtDocumentReg.Text) = "Documento" Then
            txtDocumentReg.Text = ""
        End If
    End Sub

    Private Sub txtDocumentReg_LostFocus(sender As Object, e As EventArgs) Handles txtDocumentReg.LostFocus
        If Trim(txtDocumentReg.Text) = "" Then
            txtDocumentReg.Text = "Documento"
        End If
    End Sub

    Private Sub txtPassReg_GotFocus(sender As Object, e As EventArgs) Handles txtPassReg.GotFocus
        If Trim(txtPassReg.Text) = "Contraseña" Then
            txtEmailReg.Text = ""
        End If
    End Sub

    Private Sub txtPassReg_LostFocus(sender As Object, e As EventArgs) Handles txtPassReg.LostFocus
        If Trim(txtPassReg.Text) = "" Then
            txtEmailReg.Text = "Contraseña"
        End If
    End Sub

    Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
        If Trim(txtEmail.Text) = "Correo Institucional" Then
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        If Trim(txtEmail.Text) = "" Then
            txtEmail.Text = "Correo Institucional"
        End If
    End Sub


    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If Trim(txtPassword.Text) = "Contraseña" Then
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If Trim(txtPassword.Text) = "" Then
            txtPassword.Text = "Contraseña"
        End If
    End Sub

End Class