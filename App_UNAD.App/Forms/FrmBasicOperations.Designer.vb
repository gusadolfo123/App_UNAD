<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBasicOperations
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBasicOperations))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblImagenes = New System.Windows.Forms.Label()
        Me.rtxbox = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblVideo = New System.Windows.Forms.Label()
        Me.btnContinuousVideo = New System.Windows.Forms.Button()
        Me.btnPauseVideo = New System.Windows.Forms.Button()
        Me.btnPlayVideo = New System.Windows.Forms.Button()
        Me.btnStopVideo = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPLayAudio = New System.Windows.Forms.Button()
        Me.btnStopAudio = New System.Windows.Forms.Button()
        Me.lblAudio = New System.Windows.Forms.Label()
        Me.picLogic = New System.Windows.Forms.PictureBox()
        Me.AxMedia = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picLogic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblImagenes)
        Me.Panel2.Controls.Add(Me.picLogic)
        Me.Panel2.Controls.Add(Me.rtxbox)
        Me.Panel2.Location = New System.Drawing.Point(558, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 621)
        Me.Panel2.TabIndex = 7
        '
        'lblImagenes
        '
        Me.lblImagenes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblImagenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblImagenes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblImagenes.ForeColor = System.Drawing.Color.White
        Me.lblImagenes.Location = New System.Drawing.Point(0, 0)
        Me.lblImagenes.Name = "lblImagenes"
        Me.lblImagenes.Size = New System.Drawing.Size(547, 42)
        Me.lblImagenes.TabIndex = 6
        Me.lblImagenes.Text = "Imagenes y Texto"
        Me.lblImagenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtxbox
        '
        Me.rtxbox.Location = New System.Drawing.Point(15, 351)
        Me.rtxbox.Name = "rtxbox"
        Me.rtxbox.Size = New System.Drawing.Size(514, 258)
        Me.rtxbox.TabIndex = 0
        Me.rtxbox.Text = resources.GetString("rtxbox.Text")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AxMedia)
        Me.Panel1.Controls.Add(Me.lblVideo)
        Me.Panel1.Controls.Add(Me.btnContinuousVideo)
        Me.Panel1.Controls.Add(Me.btnPauseVideo)
        Me.Panel1.Controls.Add(Me.btnPlayVideo)
        Me.Panel1.Controls.Add(Me.btnStopVideo)
        Me.Panel1.Location = New System.Drawing.Point(21, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 394)
        Me.Panel1.TabIndex = 6
        '
        'lblVideo
        '
        Me.lblVideo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblVideo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVideo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblVideo.ForeColor = System.Drawing.Color.White
        Me.lblVideo.Location = New System.Drawing.Point(0, 0)
        Me.lblVideo.Name = "lblVideo"
        Me.lblVideo.Size = New System.Drawing.Size(516, 42)
        Me.lblVideo.TabIndex = 5
        Me.lblVideo.Text = "Video"
        Me.lblVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnContinuousVideo
        '
        Me.btnContinuousVideo.Location = New System.Drawing.Point(395, 47)
        Me.btnContinuousVideo.Name = "btnContinuousVideo"
        Me.btnContinuousVideo.Size = New System.Drawing.Size(118, 50)
        Me.btnContinuousVideo.TabIndex = 4
        Me.btnContinuousVideo.Text = "Continuar"
        Me.btnContinuousVideo.UseVisualStyleBackColor = True
        '
        'btnPauseVideo
        '
        Me.btnPauseVideo.Location = New System.Drawing.Point(135, 47)
        Me.btnPauseVideo.Name = "btnPauseVideo"
        Me.btnPauseVideo.Size = New System.Drawing.Size(118, 50)
        Me.btnPauseVideo.TabIndex = 3
        Me.btnPauseVideo.Text = "Pausar"
        Me.btnPauseVideo.UseVisualStyleBackColor = True
        '
        'btnPlayVideo
        '
        Me.btnPlayVideo.Location = New System.Drawing.Point(4, 47)
        Me.btnPlayVideo.Name = "btnPlayVideo"
        Me.btnPlayVideo.Size = New System.Drawing.Size(118, 50)
        Me.btnPlayVideo.TabIndex = 2
        Me.btnPlayVideo.Text = "Iniciar"
        Me.btnPlayVideo.UseVisualStyleBackColor = True
        '
        'btnStopVideo
        '
        Me.btnStopVideo.Location = New System.Drawing.Point(266, 47)
        Me.btnStopVideo.Name = "btnStopVideo"
        Me.btnStopVideo.Size = New System.Drawing.Size(118, 50)
        Me.btnStopVideo.TabIndex = 1
        Me.btnStopVideo.Text = "Parar"
        Me.btnStopVideo.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1126, 82)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Operaciones básicas de programación"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnPLayAudio)
        Me.Panel3.Controls.Add(Me.btnStopAudio)
        Me.Panel3.Controls.Add(Me.lblAudio)
        Me.Panel3.Location = New System.Drawing.Point(22, 509)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(512, 213)
        Me.Panel3.TabIndex = 8
        '
        'btnPLayAudio
        '
        Me.btnPLayAudio.Location = New System.Drawing.Point(5, 48)
        Me.btnPLayAudio.Name = "btnPLayAudio"
        Me.btnPLayAudio.Size = New System.Drawing.Size(253, 50)
        Me.btnPLayAudio.TabIndex = 8
        Me.btnPLayAudio.Text = "Iniciar"
        Me.btnPLayAudio.UseVisualStyleBackColor = True
        '
        'btnStopAudio
        '
        Me.btnStopAudio.Location = New System.Drawing.Point(261, 48)
        Me.btnStopAudio.Name = "btnStopAudio"
        Me.btnStopAudio.Size = New System.Drawing.Size(245, 50)
        Me.btnStopAudio.TabIndex = 7
        Me.btnStopAudio.Text = "Parar"
        Me.btnStopAudio.UseVisualStyleBackColor = True
        '
        'lblAudio
        '
        Me.lblAudio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblAudio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAudio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAudio.ForeColor = System.Drawing.Color.White
        Me.lblAudio.Location = New System.Drawing.Point(0, 0)
        Me.lblAudio.Name = "lblAudio"
        Me.lblAudio.Size = New System.Drawing.Size(512, 42)
        Me.lblAudio.TabIndex = 6
        Me.lblAudio.Text = "Audio"
        Me.lblAudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogic
        '
        Me.picLogic.Image = Global.App_UNAD.App.My.Resources.Resources.operadores
        Me.picLogic.Location = New System.Drawing.Point(15, 47)
        Me.picLogic.Name = "picLogic"
        Me.picLogic.Size = New System.Drawing.Size(514, 298)
        Me.picLogic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogic.TabIndex = 1
        Me.picLogic.TabStop = False
        '
        'AxMedia
        '
        Me.AxMedia.Enabled = True
        Me.AxMedia.Location = New System.Drawing.Point(8, 103)
        Me.AxMedia.Name = "AxMedia"
        Me.AxMedia.OcxState = CType(resources.GetObject("AxMedia.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMedia.Size = New System.Drawing.Size(502, 323)
        Me.AxMedia.TabIndex = 6
        '
        'FrmBasicOperations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 743)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBasicOperations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBasicOperations"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.picLogic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxMedia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Private WithEvents lblImagenes As Label
    Friend WithEvents picLogic As PictureBox
    Friend WithEvents rtxbox As RichTextBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents lblVideo As Label
    Friend WithEvents btnContinuousVideo As Button
    Friend WithEvents btnPauseVideo As Button
    Friend WithEvents btnPlayVideo As Button
    Friend WithEvents btnStopVideo As Button
    Private WithEvents lblTitle As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPLayAudio As Button
    Friend WithEvents btnStopAudio As Button
    Private WithEvents lblAudio As Label
    Friend WithEvents AxMedia As AxWMPLib.AxWindowsMediaPlayer
End Class
