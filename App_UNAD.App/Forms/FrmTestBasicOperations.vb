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
            If EvaluateTest() Then
                MessageBox.Show("Aprobaste el test puedes ver el siguiente tema")
            Else
                MessageBox.Show("Reprobaste el test vuelve a ver el tema")

                Dim childForm = New FrmBasicOperations()
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

            End If
        End If
    End Sub

    Private Function EvaluateTest() As Boolean
        Dim total = 0
        If Q1Op4.Checked Then
            total += 1
        End If
        If Q2Op1.Checked Then
            total += 1
        End If
        If Q3Op2.Checked Then
            total += 1
        End If
        If Q4Op2.Checked Then
            total += 1
        End If
        If Q5Op2.Checked Then
            total += 1
        End If
        If Q6Op2.Checked Then
            total += 1
        End If
        If Q7Op3.Checked And Q7Op4.Checked Then
            total += 1
        End If
        If Q8Op4.Checked Then
            total += 1
        End If
        If Q9Op3.Checked Then
            total += 1
        End If
        If Q10Op4.Checked Then
            total += 1
        End If

        If total >= 6 Then
            Return True
        End If

        Return False
    End Function

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If EvaluateTest() Then
            MessageBox.Show("Aprobaste el test puedes ver el siguiente tema")
        Else
            MessageBox.Show("Reprobaste el test vuelve a ver el tema")

            Dim childForm = New FrmBasicOperations()
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

        End If
    End Sub
End Class