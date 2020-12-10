Public Class FrmTestBasicOperations

    Private _maxMinTest As Int32 = 120

    Private Sub FrmTestBasicOperations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer1.Interval = 1000
        timer1.Enabled = True
        timer1.Start()
    End Sub

    Private Sub SetTime()

        _maxMinTest -= 1
        Dim minutes = _maxMinTest / 60
        Dim seconds = _maxMinTest Mod 60
        lblTimeTest.Text = String.Format("{0}:{1}", minutes.ToString().Replace(".", ",").Split(",")(0), seconds.ToString().PadLeft(2, "0"))

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        SetTime()
        If _maxMinTest <= 0 Then
            timer1.Enabled = False
            timer1.Stop()
            MessageBox.Show("Finalizo el tiempo")
            ' EvaluateTest()
        End If
    End Sub

    Private Sub EvaluateTest()

    End Sub

End Class