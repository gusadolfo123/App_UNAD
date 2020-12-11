Imports System.Media

Public Class FrmBasicOperations

    Dim backmusic As New SoundPlayer("Audios/Operadores_Logicos.wav")

    Private Sub FrmBasicOperations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxMedia.URL = "Videos/Operadores_Logicos.mp4"
        AxMedia.Ctlcontrols.stop()
    End Sub

    Private Sub btnPlayVideo_Click(sender As Object, e As EventArgs) Handles btnPlayVideo.Click
        AxMedia.Ctlcontrols.play()
    End Sub

    Private Sub btnPauseVideo_Click(sender As Object, e As EventArgs) Handles btnPauseVideo.Click
        AxMedia.Ctlcontrols.pause()
    End Sub

    Private Sub btnStopVideo_Click(sender As Object, e As EventArgs) Handles btnStopVideo.Click
        AxMedia.Ctlcontrols.stop()
    End Sub

    Private Sub btnContinuousVideo_Click(sender As Object, e As EventArgs) Handles btnContinuousVideo.Click
        AxMedia.Ctlcontrols.play()
    End Sub

    Private Sub picLogic_MouseHover(sender As Object, e As EventArgs)
        lblImagenes.BackColor = Color.Red
    End Sub

    Private Sub picLogic_MouseLeave(sender As Object, e As EventArgs)
        lblImagenes.BackColor = Color.FromArgb(0, 74, 107)
    End Sub

    Private Sub btnExercise2Result_Click(sender As Object, e As EventArgs) Handles btnExercise2Result.Click

        Dim height = txtHeight.Value
        Dim weight = txtWeight.Value

        If height = 0 Then
            MessageBox.Show("La altuna no puede ser 0")
            Return
        End If

        If weight = 0 Then
            MessageBox.Show("El peso no puede ser 0")
            Return
        End If

        Dim result = weight / (height * height)
        txtResultExcercise2.Text = result.ToString()

    End Sub

    Private Sub btnExercise3Result_Click(sender As Object, e As EventArgs) Handles btnExercise3Result.Click

        Dim num = txtConvertNum.Value

        If num = 0 Then
            MessageBox.Show("El valor a convertir debe ser diferente de 0")
            Return
        End If

        If cbxFrom.SelectedIndex = -1 Or cbxTo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione los tipos a convertir")
            Return
        End If

        Dim result = 0.0D

        If cbxFrom.Text = "Metro cubico" Then
            If cbxTo.Text = "Litro" Then
                result = Convert.ToDecimal(num) * Convert.ToDecimal(1000)
                txtResultExcercise3.Text = result.ToString()
            ElseIf cbxTo.Text = "Decilitro" Then
                result = Convert.ToDecimal(num) * Convert.ToDecimal(10000)
                txtResultExcercise3.Text = result.ToString()
            ElseIf cbxTo.Text = "Centilitro" Then
                result = Convert.ToDecimal(num) * Convert.ToDecimal(100000)
                txtResultExcercise3.Text = result.ToString()
            End If
        ElseIf cbxFrom.Text = "Decímetro cubico" Then
            If cbxTo.Text = "Litro" Then
                result = Convert.ToDecimal(num) * Convert.ToDecimal(1)
                txtResultExcercise3.Text = result.ToString()
            ElseIf cbxTo.Text = "Decilitro" Then
                result = Convert.ToDecimal(num) * Convert.ToDecimal(10)
                txtResultExcercise3.Text = result.ToString()
            ElseIf cbxTo.Text = "Centilitro" Then
                result = Convert.ToDecimal(num) * Convert.ToDecimal(100)
                txtResultExcercise3.Text = result.ToString()
            End If
        ElseIf cbxFrom.Text = "Centímetro cubico" Then
            If cbxFrom.Text = "Litro" Then
                result = Convert.ToDecimal(num) / Convert.ToDecimal(1000)
                txtResultExcercise3.Text = result.ToString()
            ElseIf cbxFrom.Text = "Decilitro" Then
                result = Convert.ToDecimal(num) * Convert.ToDecimal(100)
                txtResultExcercise3.Text = result.ToString()
            ElseIf cbxFrom.Text = "Centilitro" Then
                result = Convert.ToDecimal(num) * Convert.ToDecimal(10)
                txtResultExcercise3.Text = result.ToString()
            End If
        End If

    End Sub

    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeight.KeyPress
        If e.KeyChar.Equals(".") Or e.KeyChar.Equals(",") Then
            e.KeyChar = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()(0)
        End If
    End Sub

    Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress
        If e.KeyChar.Equals(".") Or e.KeyChar.Equals(",") Then
            e.KeyChar = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()(0)
        End If
    End Sub

    Private Sub txtConvertNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConvertNum.KeyPress
        If e.KeyChar.Equals(".") Or e.KeyChar.Equals(",") Then
            e.KeyChar = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()(0)
        End If
    End Sub

    Private Sub BtnInitTest_Click(sender As Object, e As EventArgs) Handles BtnInitTest.Click
        Dim childForm = New FrmTestBasicOperations()
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