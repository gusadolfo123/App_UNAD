Public Class FormEjmQuiz
    Private Sub Quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button2.TabIndex = 0


    End Sub

    Private Sub Quiz_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer1.Start()
        Label10.Text = 9
        Label9.Text = 5
        Label7.Text = 1

        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        GroupBox4.Enabled = True
        GroupBox5.Enabled = True
        Button2.Enabled = True

        Button1.Enabled = False


    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles Button1.GotFocus

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label10.Text -= 1
        If Label10.Text < 0 Then
            If Label9.Text = 0 Then
                If Label7.Text = 0 Then
                    Label10.Text = 0
                    Timer1.Stop()
                    Me.Hide()
                    MessageBox.Show("Fallo el examen por tiempo debe volver a empezar", "Se termino el tiempo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Controls.Clear()
                    Me.InitializeComponent()
                    Button2.TabIndex = 0
                    Me.Show()
                Else
                    Label7.Text -= 1
                    Label10.Text = 9
                    Label9.Text = 5
                End If
            Else
                Label9.Text -= 1
                Label10.Text = 9
            End If
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Puntaje, BanSalir As Integer

        Timer1.Stop()
        BanSalir = 0
        'Me.Hide()
        If (RadioButton1.Checked = True Or RadioButton2.Checked = True Or RadioButton3.Checked = True Or RadioButton4.Checked = True) Then
            If RadioButton3.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            MessageBox.Show("No ha contestado la pregunta 1", "Falta responder la pregunta 1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If

        If (RadioButton5.Checked = True Or RadioButton6.Checked = True Or RadioButton7.Checked = True Or RadioButton8.Checked = True) Then
            If RadioButton5.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            Timer1.Stop()
            MessageBox.Show("No ha contestado la pregunta 2", "Falta responder la pregunta 2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If

        If (RadioButton9.Checked = True Or RadioButton10.Checked = True Or RadioButton11.Checked = True Or RadioButton12.Checked = True) Then
            If RadioButton12.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            Timer1.Stop()
            MessageBox.Show("No ha contestado la pregunta 3", "Falta responder la pregunta 3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If

        If (RadioButton13.Checked = True Or RadioButton14.Checked = True Or RadioButton15.Checked = True Or RadioButton16.Checked = True) Then
            If RadioButton16.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            Timer1.Stop()
            MessageBox.Show("No ha contestado la pregunta 4", "Falta responder la pregunta 4", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If

        If (RadioButton17.Checked = True Or RadioButton18.Checked = True Or RadioButton19.Checked = True Or RadioButton20.Checked = True) Then
            If RadioButton18.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            Timer1.Stop()
            MessageBox.Show("No ha contestado la pregunta 5", "Falta responder la pregunta 5", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If
        'Me.Show()


        If BanSalir = 5 Then
            'Me.Hide()

            If Puntaje < 4 Then
                MessageBox.Show("Desaforunadamente no logro el puntaje requerido para aprobar, puntaje final " & Puntaje & " de 5", "Fallo el quiz", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
                MessageBox.Show("Felicitaciones logro el puntaje requerido para pasar, puntaje final " & Puntaje & " de 5", "Aprobo el quiz", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'FormPrin.Show()
            'Me.Hide()
        End If

    End Sub
End Class