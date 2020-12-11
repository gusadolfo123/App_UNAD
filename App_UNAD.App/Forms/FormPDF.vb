Public Class FormPDF
    Private Sub FormPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxAcroPDF1.LoadFile("Recursos/ManualVB.pdf")
    End Sub
End Class