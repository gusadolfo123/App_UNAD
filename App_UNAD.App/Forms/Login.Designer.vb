<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.linkLogin = New System.Windows.Forms.LinkLabel()
        Me.txtPassReg = New System.Windows.Forms.TextBox()
        Me.pictureBox8 = New System.Windows.Forms.PictureBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtDocumentReg = New System.Windows.Forms.TextBox()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtEmailReg = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pictureBox7 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.linkRegister = New System.Windows.Forms.LinkLabel()
        Me.lblErros = New System.Windows.Forms.Label()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlRegister.SuspendLayout()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogin.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(8, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 26)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlRegister
        '
        Me.pnlRegister.Controls.Add(Me.linkLogin)
        Me.pnlRegister.Controls.Add(Me.txtPassReg)
        Me.pnlRegister.Controls.Add(Me.pictureBox8)
        Me.pnlRegister.Controls.Add(Me.label3)
        Me.pnlRegister.Controls.Add(Me.txtDocumentReg)
        Me.pnlRegister.Controls.Add(Me.pictureBox5)
        Me.pnlRegister.Controls.Add(Me.txtEmailReg)
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.pictureBox6)
        Me.pnlRegister.Controls.Add(Me.pictureBox7)
        Me.pnlRegister.Location = New System.Drawing.Point(422, 28)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(222, 392)
        Me.pnlRegister.TabIndex = 20
        '
        'linkLogin
        '
        Me.linkLogin.AutoSize = True
        Me.linkLogin.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLogin.LinkColor = System.Drawing.Color.White
        Me.linkLogin.Location = New System.Drawing.Point(4, 372)
        Me.linkLogin.Name = "linkLogin"
        Me.linkLogin.Size = New System.Drawing.Size(50, 15)
        Me.linkLogin.TabIndex = 16
        Me.linkLogin.TabStop = True
        Me.linkLogin.Text = "Ingresar"
        '
        'txtPassReg
        '
        Me.txtPassReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtPassReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassReg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassReg.ForeColor = System.Drawing.Color.Silver
        Me.txtPassReg.Location = New System.Drawing.Point(23, 282)
        Me.txtPassReg.Name = "txtPassReg"
        Me.txtPassReg.Size = New System.Drawing.Size(175, 16)
        Me.txtPassReg.TabIndex = 15
        Me.txtPassReg.Tag = ""
        Me.txtPassReg.Text = "Contraseña"
        Me.txtPassReg.UseSystemPasswordChar = True
        '
        'pictureBox8
        '
        Me.pictureBox8.Image = Global.App_UNAD.App.My.Resources.Resources.input2
        Me.pictureBox8.Location = New System.Drawing.Point(3, 268)
        Me.pictureBox8.Name = "pictureBox8"
        Me.pictureBox8.Size = New System.Drawing.Size(215, 41)
        Me.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox8.TabIndex = 14
        Me.pictureBox8.TabStop = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(4, 149)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(0, 17)
        Me.label3.TabIndex = 13
        '
        'txtDocumentReg
        '
        Me.txtDocumentReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtDocumentReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocumentReg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentReg.ForeColor = System.Drawing.Color.Silver
        Me.txtDocumentReg.Location = New System.Drawing.Point(23, 233)
        Me.txtDocumentReg.Name = "txtDocumentReg"
        Me.txtDocumentReg.Size = New System.Drawing.Size(175, 16)
        Me.txtDocumentReg.TabIndex = 11
        Me.txtDocumentReg.Tag = ""
        Me.txtDocumentReg.Text = "Documento"
        '
        'pictureBox5
        '
        Me.pictureBox5.Image = Global.App_UNAD.App.My.Resources.Resources.input2
        Me.pictureBox5.Location = New System.Drawing.Point(3, 219)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(215, 41)
        Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox5.TabIndex = 10
        Me.pictureBox5.TabStop = False
        '
        'txtEmailReg
        '
        Me.txtEmailReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtEmailReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailReg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailReg.ForeColor = System.Drawing.Color.Silver
        Me.txtEmailReg.Location = New System.Drawing.Point(23, 182)
        Me.txtEmailReg.Name = "txtEmailReg"
        Me.txtEmailReg.Size = New System.Drawing.Size(175, 16)
        Me.txtEmailReg.TabIndex = 9
        Me.txtEmailReg.Text = "Correo Institucional"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(3, 324)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(215, 41)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "Registrarse"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'pictureBox6
        '
        Me.pictureBox6.Image = Global.App_UNAD.App.My.Resources.Resources.input2
        Me.pictureBox6.Location = New System.Drawing.Point(3, 168)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(215, 41)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox6.TabIndex = 7
        Me.pictureBox6.TabStop = False
        '
        'pictureBox7
        '
        Me.pictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox7.Image = Global.App_UNAD.App.My.Resources.Resources.programador
        Me.pictureBox7.Location = New System.Drawing.Point(50, 3)
        Me.pictureBox7.Name = "pictureBox7"
        Me.pictureBox7.Size = New System.Drawing.Size(111, 108)
        Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox7.TabIndex = 0
        Me.pictureBox7.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.White
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(92, 246)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(212, 19)
        Me.label1.TabIndex = 18
        Me.label1.Text = "Bienvenido a LearningLab"
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.White
        Me.pictureBox2.Image = Global.App_UNAD.App.My.Resources.Resources.unad_log
        Me.pictureBox2.Location = New System.Drawing.Point(58, 142)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(284, 76)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 17
        Me.pictureBox2.TabStop = False
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.linkRegister)
        Me.pnlLogin.Controls.Add(Me.lblErros)
        Me.pnlLogin.Controls.Add(Me.checkBox1)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.pictureBox4)
        Me.pnlLogin.Controls.Add(Me.txtEmail)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.pictureBox3)
        Me.pnlLogin.Controls.Add(Me.pictureBox1)
        Me.pnlLogin.Location = New System.Drawing.Point(419, 28)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(222, 392)
        Me.pnlLogin.TabIndex = 12
        '
        'linkRegister
        '
        Me.linkRegister.AutoSize = True
        Me.linkRegister.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkRegister.LinkColor = System.Drawing.Color.White
        Me.linkRegister.Location = New System.Drawing.Point(4, 372)
        Me.linkRegister.Name = "linkRegister"
        Me.linkRegister.Size = New System.Drawing.Size(66, 15)
        Me.linkRegister.TabIndex = 17
        Me.linkRegister.TabStop = True
        Me.linkRegister.Text = "Registrarse"
        '
        'lblErros
        '
        Me.lblErros.AutoSize = True
        Me.lblErros.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErros.ForeColor = System.Drawing.Color.White
        Me.lblErros.Location = New System.Drawing.Point(4, 149)
        Me.lblErros.Name = "lblErros"
        Me.lblErros.Size = New System.Drawing.Size(0, 17)
        Me.lblErros.TabIndex = 13
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox1.ForeColor = System.Drawing.Color.White
        Me.checkBox1.Location = New System.Drawing.Point(3, 267)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(92, 19)
        Me.checkBox1.TabIndex = 12
        Me.checkBox1.Text = "Recordarme"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Silver
        Me.txtPassword.Location = New System.Drawing.Point(23, 233)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(175, 16)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Tag = ""
        Me.txtPassword.Text = "Contraseña"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = Global.App_UNAD.App.My.Resources.Resources.input2
        Me.pictureBox4.Location = New System.Drawing.Point(3, 219)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(215, 41)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox4.TabIndex = 10
        Me.pictureBox4.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Silver
        Me.txtEmail.Location = New System.Drawing.Point(23, 182)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(175, 16)
        Me.txtEmail.TabIndex = 9
        Me.txtEmail.Text = "Correo Institucional"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(3, 324)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(215, 41)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Ingresar"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global.App_UNAD.App.My.Resources.Resources.input2
        Me.pictureBox3.Location = New System.Drawing.Point(3, 168)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(215, 41)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 7
        Me.pictureBox3.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = Global.App_UNAD.App.My.Resources.Resources.programador
        Me.pictureBox1.Location = New System.Drawing.Point(50, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(111, 108)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BackgroundImage = Global.App_UNAD.App.My.Resources.Resources.Formulario1
        Me.ClientSize = New System.Drawing.Size(688, 449)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnClose As Button
    Private WithEvents pnlRegister As Panel
    Private WithEvents linkLogin As LinkLabel
    Private WithEvents txtPassReg As TextBox
    Private WithEvents pictureBox8 As PictureBox
    Private WithEvents label3 As Label
    Private WithEvents txtDocumentReg As TextBox
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents txtEmailReg As TextBox
    Private WithEvents btnRegister As Button
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents pictureBox7 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pnlLogin As Panel
    Private WithEvents linkRegister As LinkLabel
    Private WithEvents lblErros As Label
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents txtPassword As TextBox
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents btnLogin As Button
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
End Class
