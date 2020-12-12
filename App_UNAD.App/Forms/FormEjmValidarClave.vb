Public Class FormEjmValidarClave
    Private Sub ValidarClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        Label4.Visible = False
    End Sub

    Private Sub ValidarClave_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Usuario, Clave As String
        Static CIntentos As Integer


        Usuario = "Mauricio"
        Clave = "Mao123+"

        If CIntentos < 3 Then
            If UCase(Usuario) = UCase(TextBox1.Text) Then
                If Clave = TextBox2.Text Then
                    Me.Hide()
                    MessageBox.Show("Bienvenido clave y usuario correcto.", "Ingreso validado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'FormPrin.Show()

                    Dim childForm = New FormPrin()
                    Dim _currentChildForm = Me
                    Dim myPanel As Panel = Me.Parent

                    If _currentChildForm IsNot Nothing Then
                        _currentChildForm.Close()
                    End If

                    childForm.TopLevel = False
                    childForm.FormBorderStyle = FormBorderStyle.None
                    childForm.Dock = DockStyle.Fill
                    myPanel.Controls.Add(childForm)
                    myPanel.Tag = childForm
                    childForm.BringToFront()
                    childForm.Width = myPanel.Width
                    childForm.Show()

                Else
                    CIntentos += 1
                    If CIntentos = 3 Then
                        MessageBox.Show("La clave ingresada no es valida, tiene " & 4 - CIntentos & " intento.", "Clave Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("La clave ingresada no es valida, tiene " & 4 - CIntentos & " intentos.", "Clave Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                CIntentos += 1
                If CIntentos = 3 Then
                    MessageBox.Show("El usuario ingresado no es valido, tiene " & 4 - CIntentos & " intento.", "Usuario Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("El usuario ingresado no es valido, tiene " & 4 - CIntentos & " intentos.", "Usuario Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

            Label4.Text = 60
            Timer1.Start()
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            Label5.Visible = True
            Button2.Visible = True
            Timer1.Stop()
        End If

        TextBox1.Clear()
        TextBox2.Clear()
        Me.TextBox1.Focus()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Label4.Text -= 1

        If Label4.Text = 0 Then
            Timer1.Stop()
            MessageBox.Show("El tiempo para ingresar la clave y contraseña a caducado.", "Tiempo Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            Button1.Enabled = False
            Label5.Visible = True
            Button2.Visible = True
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Timer1.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim childForm = New FormPrin()
        Dim _currentChildForm = Me
        Dim myPanel As Panel = Me.Parent

        If _currentChildForm IsNot Nothing Then
            _currentChildForm.Close()
        End If

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        myPanel.Controls.Add(childForm)
        myPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Width = myPanel.Width
        childForm.Show()
    End Sub
End Class