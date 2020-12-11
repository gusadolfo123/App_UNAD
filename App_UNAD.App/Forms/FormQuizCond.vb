Public Class FormQuizCond
    Private Sub Quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.TabIndex = 0
    End Sub

    Private Sub Quiz_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        ' MenuPrincipal.Show()
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
        GroupBox6.Enabled = True
        GroupBox7.Enabled = True
        GroupBox8.Enabled = True
        GroupBox9.Enabled = True
        GroupBox10.Enabled = True
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
        Me.Hide()
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

        If (RadioButton21.Checked = True Or RadioButton22.Checked = True Or RadioButton23.Checked = True Or RadioButton24.Checked = True) Then
            If RadioButton21.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            Timer1.Stop()
            MessageBox.Show("No ha contestado la pregunta 6", "Falta responder la pregunta 6", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If

        If (RadioButton25.Checked = True Or RadioButton26.Checked = True Or RadioButton27.Checked = True Or RadioButton28.Checked = True) Then
            If RadioButton25.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            Timer1.Stop()
            MessageBox.Show("No ha contestado la pregunta 7", "Falta responder la pregunta 7", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If

        If (RadioButton29.Checked = True Or RadioButton30.Checked = True Or RadioButton31.Checked = True Or RadioButton32.Checked = True) Then
            If RadioButton30.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            Timer1.Stop()
            MessageBox.Show("No ha contestado la pregunta 8", "Falta responder la pregunta 8", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If

        If (RadioButton33.Checked = True Or RadioButton34.Checked = True Or RadioButton35.Checked = True Or RadioButton36.Checked = True) Then
            If RadioButton35.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            Timer1.Stop()
            MessageBox.Show("No ha contestado la pregunta 9", "Falta responder la pregunta 9", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If

        If (RadioButton37.Checked = True Or RadioButton38.Checked = True Or RadioButton39.Checked = True Or RadioButton40.Checked = True) Then
            If RadioButton38.Checked = True Then
                Puntaje += 1
            End If
            BanSalir += 1
        Else
            Timer1.Stop()
            MessageBox.Show("No ha contestado la pregunta 10", "Falta responder la pregunta 10", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Timer1.Start()
        End If
        Me.Show()


        If BanSalir = 10 Then
            Me.Hide()

            If Puntaje < 6 Then
                MessageBox.Show("Desaforunadamente no logro el puntaje requerido para aprobar, puntaje final " & Puntaje & " de 10", "Fallo el quiz", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Felicitaciones logro el puntaje requerido para pasar, puntaje final " & Puntaje & " de 10", "Aprobo el quiz", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Close()
            'MenuPrincipal.Show()
        End If

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class