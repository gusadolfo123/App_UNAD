Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class FrmMain
    Private _currentChildForm As Form
    Private currentButton As IconButton
    Private leftBorderBtn As Panel
    Private Shared _instance As FrmMain

    Public Shared Function GetInstance(ByVal nameUser As String)
        If _instance Is Nothing Then
            _instance = New FrmMain(nameUser)
        End If
        Return _instance
    End Function

    Public Sub New(ByVal nameUser As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        pnlMenu.Controls.Add(leftBorderBtn)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea

        lblNameUser.Text = nameUser
    End Sub

    Private Sub OpenFormChild(ByVal childForm As Form)
        If (_currentChildForm IsNot Nothing) Then
            _currentChildForm.Close()
        End If

        _currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlPrimary.Controls.Add(childForm)
        pnlPrimary.Tag = childForm
        childForm.BringToFront()
        childForm.Width = pnlPrimary.Width
        childForm.Show()
    End Sub

    Private Sub ActivateButton(ByVal senderBtn As Object, ByVal color As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()

            currentButton = CType(senderBtn, IconButton)
            currentButton.BackColor = Color.FromArgb(0, 68, 107)
            currentButton.ForeColor = color
            currentButton.IconColor = color

            leftBorderBtn.BackColor = color
            leftBorderBtn.Location = New Point(0, currentButton.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            lblTitle.Text = currentButton.Text
        End If
    End Sub


    Private Sub DisableButton()
        If currentButton IsNot Nothing Then
            currentButton.BackColor = Color.FromArgb(0, 74, 107)
            currentButton.ForeColor = Color.White
            currentButton.TextAlign = ContentAlignment.MiddleLeft
            currentButton.IconColor = Color.White
            currentButton.TextImageRelation = TextImageRelation.ImageBeforeText
            currentButton.ImageAlign = ContentAlignment.MiddleLeft
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenFormChild(New FrmHome())
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBasicOp_Click(sender As Object, e As EventArgs) Handles btnBasicOp.Click
        ActivateButton(sender, Color.White)
        OpenFormChild(New FrmBasicOperations())
    End Sub

    Private Sub btnConditional_Click(sender As Object, e As EventArgs) Handles btnConditional.Click

    End Sub

    Private Sub btnIterable_Click(sender As Object, e As EventArgs) Handles btnIterable.Click

    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Reset()
        lblTitle.Text = "Inicio"
        OpenFormChild(New FrmHome())
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Application.Exit()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32)
    End Sub

    Private Sub pnlHeader_MouseDown(sender As Object, e As EventArgs) Handles pnlHeader.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

End Class