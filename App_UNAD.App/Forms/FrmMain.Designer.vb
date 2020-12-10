<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnConditional = New FontAwesome.Sharp.IconButton()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnIterable = New FontAwesome.Sharp.IconButton()
        Me.btnBasicOp = New FontAwesome.Sharp.IconButton()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNameUser = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.pnlPrimary = New System.Windows.Forms.Panel()
        Me.pnlMenu.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProgress.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConditional
        '
        Me.btnConditional.BackColor = System.Drawing.Color.Transparent
        Me.btnConditional.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConditional.FlatAppearance.BorderSize = 0
        Me.btnConditional.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnConditional.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnConditional.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConditional.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConditional.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.btnConditional.IconColor = System.Drawing.Color.White
        Me.btnConditional.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnConditional.IconSize = 34
        Me.btnConditional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConditional.Location = New System.Drawing.Point(0, 242)
        Me.btnConditional.Name = "btnConditional"
        Me.btnConditional.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnConditional.Size = New System.Drawing.Size(200, 60)
        Me.btnConditional.TabIndex = 2
        Me.btnConditional.Text = " Condicionales"
        Me.btnConditional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConditional.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConditional.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnExit)
        Me.pnlMenu.Controls.Add(Me.btnIterable)
        Me.pnlMenu.Controls.Add(Me.btnConditional)
        Me.pnlMenu.Controls.Add(Me.btnBasicOp)
        Me.pnlMenu.Controls.Add(Me.panel2)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.ForeColor = System.Drawing.Color.White
        Me.pnlMenu.Location = New System.Drawing.Point(0, 65)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(200, 565)
        Me.pnlMenu.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnExit.IconColor = System.Drawing.Color.White
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 34
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 505)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(200, 60)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = " Salir"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnIterable
        '
        Me.btnIterable.BackColor = System.Drawing.Color.Transparent
        Me.btnIterable.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIterable.FlatAppearance.BorderSize = 0
        Me.btnIterable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnIterable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnIterable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIterable.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIterable.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.btnIterable.IconColor = System.Drawing.Color.White
        Me.btnIterable.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnIterable.IconSize = 34
        Me.btnIterable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIterable.Location = New System.Drawing.Point(0, 302)
        Me.btnIterable.Name = "btnIterable"
        Me.btnIterable.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnIterable.Size = New System.Drawing.Size(200, 60)
        Me.btnIterable.TabIndex = 3
        Me.btnIterable.Text = " Ciclos"
        Me.btnIterable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIterable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIterable.UseVisualStyleBackColor = False
        '
        'btnBasicOp
        '
        Me.btnBasicOp.BackColor = System.Drawing.Color.Transparent
        Me.btnBasicOp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBasicOp.FlatAppearance.BorderSize = 0
        Me.btnBasicOp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnBasicOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnBasicOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBasicOp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBasicOp.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.btnBasicOp.IconColor = System.Drawing.Color.White
        Me.btnBasicOp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBasicOp.IconSize = 34
        Me.btnBasicOp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBasicOp.Location = New System.Drawing.Point(0, 182)
        Me.btnBasicOp.Name = "btnBasicOp"
        Me.btnBasicOp.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnBasicOp.Size = New System.Drawing.Size(200, 60)
        Me.btnBasicOp.TabIndex = 1
        Me.btnBasicOp.Text = " Operaciones básicas"
        Me.btnBasicOp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBasicOp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBasicOp.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.pictureBox1)
        Me.panel2.Controls.Add(Me.lblNameUser)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(200, 182)
        Me.panel2.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.App_UNAD.App.My.Resources.Resources.usuario
        Me.pictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(145, 137)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'lblNameUser
        '
        Me.lblNameUser.AutoSize = True
        Me.lblNameUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameUser.Location = New System.Drawing.Point(45, 152)
        Me.lblNameUser.Name = "lblNameUser"
        Me.lblNameUser.Size = New System.Drawing.Size(114, 16)
        Me.lblNameUser.TabIndex = 0
        Me.lblNameUser.Text = "Gustavo Moreno"
        Me.lblNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 65)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1008, 565)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Inicio"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlProgress
        '
        Me.pnlProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.pnlProgress.Controls.Add(Me.progressBar1)
        Me.pnlProgress.Controls.Add(Me.label1)
        Me.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlProgress.ForeColor = System.Drawing.Color.White
        Me.pnlProgress.Location = New System.Drawing.Point(0, 27)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(1008, 38)
        Me.pnlProgress.TabIndex = 6
        '
        'progressBar1
        '
        Me.progressBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBar1.Location = New System.Drawing.Point(104, 12)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(867, 13)
        Me.progressBar1.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(16, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Tu Progreso"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.button1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1008, 27)
        Me.pnlHeader.TabIndex = 5
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.BackColor = System.Drawing.Color.White
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.button1.Location = New System.Drawing.Point(980, 0)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(27, 26)
        Me.button1.TabIndex = 0
        Me.button1.Text = "X"
        Me.button1.UseVisualStyleBackColor = False
        '
        'pnlPrimary
        '
        Me.pnlPrimary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrimary.Location = New System.Drawing.Point(200, 65)
        Me.pnlPrimary.Name = "pnlPrimary"
        Me.pnlPrimary.Size = New System.Drawing.Size(808, 565)
        Me.pnlPrimary.TabIndex = 7
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 630)
        Me.Controls.Add(Me.pnlPrimary)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlProgress)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FrmMain"
        Me.Text = "FrmMain"
        Me.pnlMenu.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProgress.ResumeLayout(False)
        Me.pnlProgress.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnConditional As FontAwesome.Sharp.IconButton
    Private WithEvents pnlMenu As Panel
    Private WithEvents btnExit As FontAwesome.Sharp.IconButton
    Private WithEvents btnIterable As FontAwesome.Sharp.IconButton
    Private WithEvents btnBasicOp As FontAwesome.Sharp.IconButton
    Private WithEvents panel2 As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lblNameUser As Label
    Private WithEvents lblTitle As Label
    Private WithEvents pnlProgress As Panel
    Private WithEvents progressBar1 As ProgressBar
    Private WithEvents label1 As Label
    Private WithEvents pnlHeader As Panel
    Private WithEvents button1 As Button
    Private WithEvents pnlPrimary As Panel
End Class
