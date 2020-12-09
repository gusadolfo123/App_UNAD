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

End Class