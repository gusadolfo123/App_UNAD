Imports AxWMPLib

Public Class FormPrin
    Private Sub AxWindowsMediaPlayer1_ClickEvent(sender As Object, e As _WMPOCXEvents_ClickEvent) Handles AxWindowsMediaPlayer1.ClickEvent

        If RadioButton1.Checked = True Then
            AxWindowsMediaPlayer1.URL = "Recursos/Video1.3gp"
        ElseIf RadioButton2.Checked = True Then
            AxWindowsMediaPlayer1.URL = "Recursos/Video2.3gp"
        Else
            MessageBox.Show("Seleccione un video y de click sobre la pantalla o click en el boton iniciar", "Selecione Video", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.Imagen1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.Imagen2
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        My.Computer.Audio.Play(My.Resources.Audio1, AudioPlayMode.Background)
    End Sub

    Private Sub AxAcroPDF1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.Imagen3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.Imagen4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.Imagen5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.Imagen6
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If RadioButton1.Checked = True Then
            AxWindowsMediaPlayer1.URL = "Recursos/Video1.3gp"
        ElseIf RadioButton2.Checked = True Then
            AxWindowsMediaPlayer1.URL = "Recursos/Video2.3gp"
        Else
            MessageBox.Show("Seleccione un video y de click sobre la pantalla o click en el boton iniciar", "Selecione Video", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FormPDF.Show()
    End Sub

    Private Sub FormPrin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
    End Sub

    Private Sub BtnQuiz_Click(sender As Object, e As EventArgs) Handles BtnQuiz.Click
        Dim childForm = New FormQuizCond()
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
