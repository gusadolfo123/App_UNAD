<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTestBasicOperations
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
        Me.components = New System.ComponentModel.Container()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.iconButton1 = New FontAwesome.Sharp.IconButton()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.radioButton5 = New System.Windows.Forms.RadioButton()
        Me.radioButton6 = New System.Windows.Forms.RadioButton()
        Me.label4 = New System.Windows.Forms.Label()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.checkBox4 = New System.Windows.Forms.CheckBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblTimeTest = New System.Windows.Forms.Label()
        Me.iconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.lblTitleExam = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel6.SuspendLayout()
        Me.panel5.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.iconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel6
        '
        Me.panel6.Controls.Add(Me.iconButton1)
        Me.panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel6.Location = New System.Drawing.Point(0, 514)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(1011, 138)
        Me.panel6.TabIndex = 10
        '
        'iconButton1
        '
        Me.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileSignature
        Me.iconButton1.IconColor = System.Drawing.Color.Black
        Me.iconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconButton1.IconSize = 16
        Me.iconButton1.Location = New System.Drawing.Point(32, 38)
        Me.iconButton1.Name = "iconButton1"
        Me.iconButton1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.iconButton1.Size = New System.Drawing.Size(174, 48)
        Me.iconButton1.TabIndex = 1
        Me.iconButton1.Text = "Finalizar"
        Me.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.iconButton1.UseVisualStyleBackColor = True
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.radioButton5)
        Me.panel5.Controls.Add(Me.radioButton6)
        Me.panel5.Controls.Add(Me.label4)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel5.Location = New System.Drawing.Point(0, 376)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(1011, 138)
        Me.panel5.TabIndex = 9
        '
        'radioButton5
        '
        Me.radioButton5.AutoSize = True
        Me.radioButton5.Location = New System.Drawing.Point(50, 94)
        Me.radioButton5.Name = "radioButton5"
        Me.radioButton5.Size = New System.Drawing.Size(85, 17)
        Me.radioButton5.TabIndex = 7
        Me.radioButton5.TabStop = True
        Me.radioButton5.Text = "Respuesta 2"
        Me.radioButton5.UseVisualStyleBackColor = True
        '
        'radioButton6
        '
        Me.radioButton6.AutoSize = True
        Me.radioButton6.Location = New System.Drawing.Point(50, 61)
        Me.radioButton6.Name = "radioButton6"
        Me.radioButton6.Size = New System.Drawing.Size(85, 17)
        Me.radioButton6.TabIndex = 6
        Me.radioButton6.TabStop = True
        Me.radioButton6.Text = "Respuesta 1"
        Me.radioButton6.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(28, 24)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(158, 19)
        Me.label4.TabIndex = 5
        Me.label4.Text = "3. Tercera Pregunta"
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.checkBox4)
        Me.panel4.Controls.Add(Me.checkBox3)
        Me.panel4.Controls.Add(Me.checkBox2)
        Me.panel4.Controls.Add(Me.checkBox1)
        Me.panel4.Controls.Add(Me.label2)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel4.Location = New System.Drawing.Point(0, 238)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(1011, 138)
        Me.panel4.TabIndex = 8
        '
        'checkBox4
        '
        Me.checkBox4.AutoSize = True
        Me.checkBox4.Location = New System.Drawing.Point(200, 97)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(80, 17)
        Me.checkBox4.TabIndex = 11
        Me.checkBox4.Text = "checkBox4"
        Me.checkBox4.UseVisualStyleBackColor = True
        '
        'checkBox3
        '
        Me.checkBox3.AutoSize = True
        Me.checkBox3.Location = New System.Drawing.Point(200, 64)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(80, 17)
        Me.checkBox3.TabIndex = 10
        Me.checkBox3.Text = "checkBox3"
        Me.checkBox3.UseVisualStyleBackColor = True
        '
        'checkBox2
        '
        Me.checkBox2.AutoSize = True
        Me.checkBox2.Location = New System.Drawing.Point(50, 97)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(80, 17)
        Me.checkBox2.TabIndex = 9
        Me.checkBox2.Text = "checkBox2"
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(50, 64)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(80, 17)
        Me.checkBox1.TabIndex = 8
        Me.checkBox1.Text = "checkBox1"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(28, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(171, 19)
        Me.label2.TabIndex = 5
        Me.label2.Text = "2. Segunda Pregunta"
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.radioButton2)
        Me.panel3.Controls.Add(Me.radioButton1)
        Me.panel3.Controls.Add(Me.label3)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel3.Location = New System.Drawing.Point(0, 100)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1011, 138)
        Me.panel3.TabIndex = 7
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Location = New System.Drawing.Point(50, 94)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(85, 17)
        Me.radioButton2.TabIndex = 7
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "Respuesta 2"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Location = New System.Drawing.Point(50, 61)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(85, 17)
        Me.radioButton1.TabIndex = 6
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Respuesta 1"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(28, 24)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(160, 19)
        Me.label3.TabIndex = 5
        Me.label3.Text = "1. Primera Pregunta"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.iconPictureBox1)
        Me.panel1.Controls.Add(Me.lblTitleExam)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1011, 100)
        Me.panel1.TabIndex = 6
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Controls.Add(Me.lblTimeTest)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel2.Location = New System.Drawing.Point(737, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(274, 100)
        Me.panel2.TabIndex = 4
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(48, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(143, 19)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Tiempo Restante: "
        '
        'lblTimeTest
        '
        Me.lblTimeTest.AutoSize = True
        Me.lblTimeTest.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeTest.ForeColor = System.Drawing.Color.White
        Me.lblTimeTest.Location = New System.Drawing.Point(197, 42)
        Me.lblTimeTest.Name = "lblTimeTest"
        Me.lblTimeTest.Size = New System.Drawing.Size(40, 19)
        Me.lblTimeTest.TabIndex = 3
        Me.lblTimeTest.Text = "2:00"
        '
        'iconPictureBox1
        '
        Me.iconPictureBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileSignature
        Me.iconPictureBox1.IconColor = System.Drawing.Color.White
        Me.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconPictureBox1.Location = New System.Drawing.Point(32, 36)
        Me.iconPictureBox1.Name = "iconPictureBox1"
        Me.iconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.iconPictureBox1.TabIndex = 1
        Me.iconPictureBox1.TabStop = False
        '
        'lblTitleExam
        '
        Me.lblTitleExam.AutoSize = True
        Me.lblTitleExam.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleExam.ForeColor = System.Drawing.Color.White
        Me.lblTitleExam.Location = New System.Drawing.Point(70, 42)
        Me.lblTitleExam.Name = "lblTitleExam"
        Me.lblTitleExam.Size = New System.Drawing.Size(238, 19)
        Me.lblTitleExam.TabIndex = 0
        Me.lblTitleExam.Text = "Examen Operaciones Basicas"
        '
        'timer1
        '
        '
        'FrmTestBasicOperations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 683)
        Me.Controls.Add(Me.panel6)
        Me.Controls.Add(Me.panel5)
        Me.Controls.Add(Me.panel4)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel1)
        Me.Name = "FrmTestBasicOperations"
        Me.Text = "FrmTestBasicOperations"
        Me.panel6.ResumeLayout(False)
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.iconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel6 As Panel
    Private WithEvents iconButton1 As FontAwesome.Sharp.IconButton
    Private WithEvents panel5 As Panel
    Private WithEvents radioButton5 As RadioButton
    Private WithEvents radioButton6 As RadioButton
    Private WithEvents label4 As Label
    Private WithEvents panel4 As Panel
    Private WithEvents checkBox4 As CheckBox
    Private WithEvents checkBox3 As CheckBox
    Private WithEvents checkBox2 As CheckBox
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents label2 As Label
    Private WithEvents panel3 As Panel
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton1 As RadioButton
    Private WithEvents label3 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents panel2 As Panel
    Private WithEvents label1 As Label
    Private WithEvents lblTimeTest As Label
    Private WithEvents iconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Private WithEvents lblTitleExam As Label
    Private WithEvents timer1 As Timer
End Class
