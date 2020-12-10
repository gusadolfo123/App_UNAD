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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlExamples = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnInitTest = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlExercise3 = New System.Windows.Forms.Panel()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtConvertNum = New System.Windows.Forms.NumericUpDown()
        Me.cbxTo = New System.Windows.Forms.ComboBox()
        Me.cbxFrom = New System.Windows.Forms.ComboBox()
        Me.btnExercise3Result = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtResultExcercise3 = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.richTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.pnlExercise2 = New System.Windows.Forms.Panel()
        Me.txtHeight = New System.Windows.Forms.NumericUpDown()
        Me.txtWeight = New System.Windows.Forms.NumericUpDown()
        Me.btnExercise2Result = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtResultExcercise2 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxMedia = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblVideo = New System.Windows.Forms.Label()
        Me.btnContinuousVideo = New System.Windows.Forms.Button()
        Me.btnPauseVideo = New System.Windows.Forms.Button()
        Me.btnPlayVideo = New System.Windows.Forms.Button()
        Me.btnStopVideo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblImagenes = New System.Windows.Forms.Label()
        Me.picLogic = New System.Windows.Forms.PictureBox()
        Me.rtxbox = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPLayAudio = New System.Windows.Forms.Button()
        Me.btnStopAudio = New System.Windows.Forms.Button()
        Me.lblAudio = New System.Windows.Forms.Label()
        Me.pnlFirst = New System.Windows.Forms.Panel()
        Me.pnlExamples.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlExercise3.SuspendLayout()
        CType(Me.txtConvertNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExercise2.SuspendLayout()
        CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picLogic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlFirst.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1157, 82)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Operaciones básicas de programación"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlExamples
        '
        Me.pnlExamples.Controls.Add(Me.Panel1)
        Me.pnlExamples.Controls.Add(Me.pnlExercise3)
        Me.pnlExamples.Controls.Add(Me.richTextBox2)
        Me.pnlExamples.Controls.Add(Me.pnlExercise2)
        Me.pnlExamples.Controls.Add(Me.richTextBox1)
        Me.pnlExamples.Controls.Add(Me.Label1)
        Me.pnlExamples.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlExamples.Location = New System.Drawing.Point(0, 766)
        Me.pnlExamples.Name = "pnlExamples"
        Me.pnlExamples.Size = New System.Drawing.Size(1157, 532)
        Me.pnlExamples.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnInitTest)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 430)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1157, 90)
        Me.Panel1.TabIndex = 11
        '
        'BtnInitTest
        '
        Me.BtnInitTest.BackColor = System.Drawing.Color.White
        Me.BtnInitTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInitTest.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnInitTest.Location = New System.Drawing.Point(28, 17)
        Me.BtnInitTest.Name = "BtnInitTest"
        Me.BtnInitTest.Size = New System.Drawing.Size(1067, 55)
        Me.BtnInitTest.TabIndex = 7
        Me.BtnInitTest.Text = "Iniciar Examen Operaciones Basicas"
        Me.BtnInitTest.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(57, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Ingresar Datos"
        '
        'pnlExercise3
        '
        Me.pnlExercise3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.pnlExercise3.Controls.Add(Me.label9)
        Me.pnlExercise3.Controls.Add(Me.txtConvertNum)
        Me.pnlExercise3.Controls.Add(Me.cbxTo)
        Me.pnlExercise3.Controls.Add(Me.cbxFrom)
        Me.pnlExercise3.Controls.Add(Me.btnExercise3Result)
        Me.pnlExercise3.Controls.Add(Me.label5)
        Me.pnlExercise3.Controls.Add(Me.txtResultExcercise3)
        Me.pnlExercise3.Controls.Add(Me.label6)
        Me.pnlExercise3.Controls.Add(Me.label7)
        Me.pnlExercise3.Controls.Add(Me.label8)
        Me.pnlExercise3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlExercise3.Location = New System.Drawing.Point(0, 321)
        Me.pnlExercise3.Name = "pnlExercise3"
        Me.pnlExercise3.Size = New System.Drawing.Size(1157, 109)
        Me.pnlExercise3.TabIndex = 10
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(57, 48)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(97, 15)
        Me.label9.TabIndex = 11
        Me.label9.Text = "Valor a convertir"
        '
        'txtConvertNum
        '
        Me.txtConvertNum.DecimalPlaces = 2
        Me.txtConvertNum.Location = New System.Drawing.Point(60, 66)
        Me.txtConvertNum.Name = "txtConvertNum"
        Me.txtConvertNum.Size = New System.Drawing.Size(120, 20)
        Me.txtConvertNum.TabIndex = 10
        '
        'cbxTo
        '
        Me.cbxTo.FormattingEnabled = True
        Me.cbxTo.Items.AddRange(New Object() {"Litro", "Decilitro", "Centilitro"})
        Me.cbxTo.Location = New System.Drawing.Point(321, 67)
        Me.cbxTo.Name = "cbxTo"
        Me.cbxTo.Size = New System.Drawing.Size(121, 21)
        Me.cbxTo.TabIndex = 9
        Me.cbxTo.Text = "Seleccione..."
        '
        'cbxFrom
        '
        Me.cbxFrom.FormattingEnabled = True
        Me.cbxFrom.Items.AddRange(New Object() {"Metro cubico", "Decímetro cubico", "Centímetro cubico"})
        Me.cbxFrom.Location = New System.Drawing.Point(190, 67)
        Me.cbxFrom.Name = "cbxFrom"
        Me.cbxFrom.Size = New System.Drawing.Size(121, 21)
        Me.cbxFrom.TabIndex = 8
        Me.cbxFrom.Text = "Seleccione..."
        '
        'btnExercise3Result
        '
        Me.btnExercise3Result.BackColor = System.Drawing.Color.White
        Me.btnExercise3Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExercise3Result.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnExercise3Result.Location = New System.Drawing.Point(586, 65)
        Me.btnExercise3Result.Name = "btnExercise3Result"
        Me.btnExercise3Result.Size = New System.Drawing.Size(75, 23)
        Me.btnExercise3Result.TabIndex = 7
        Me.btnExercise3Result.Text = "Calular"
        Me.btnExercise3Result.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(453, 48)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 15)
        Me.label5.TabIndex = 6
        Me.label5.Text = "Resultado"
        '
        'txtResultExcercise3
        '
        Me.txtResultExcercise3.Enabled = False
        Me.txtResultExcercise3.Location = New System.Drawing.Point(456, 67)
        Me.txtResultExcercise3.Name = "txtResultExcercise3"
        Me.txtResultExcercise3.Size = New System.Drawing.Size(100, 20)
        Me.txtResultExcercise3.TabIndex = 5
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(318, 48)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(66, 15)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Convertir a"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(187, 48)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 15)
        Me.label7.TabIndex = 1
        Me.label7.Text = "Convertir de"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(57, 17)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(83, 15)
        Me.label8.TabIndex = 0
        Me.label8.Text = "Ingresar Datos"
        '
        'richTextBox2
        '
        Me.richTextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.richTextBox2.Location = New System.Drawing.Point(0, 250)
        Me.richTextBox2.Name = "richTextBox2"
        Me.richTextBox2.Size = New System.Drawing.Size(1157, 71)
        Me.richTextBox2.TabIndex = 9
        Me.richTextBox2.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Programa que haga la conversión de:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Metro cubico, Decímetro cubico, Centímetro" &
    " cubico" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Convertir a: Litro, Decilitro, Centilitro"
        '
        'pnlExercise2
        '
        Me.pnlExercise2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.pnlExercise2.Controls.Add(Me.txtHeight)
        Me.pnlExercise2.Controls.Add(Me.txtWeight)
        Me.pnlExercise2.Controls.Add(Me.btnExercise2Result)
        Me.pnlExercise2.Controls.Add(Me.label4)
        Me.pnlExercise2.Controls.Add(Me.txtResultExcercise2)
        Me.pnlExercise2.Controls.Add(Me.label3)
        Me.pnlExercise2.Controls.Add(Me.label2)
        Me.pnlExercise2.Controls.Add(Me.Label10)
        Me.pnlExercise2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlExercise2.Location = New System.Drawing.Point(0, 137)
        Me.pnlExercise2.Name = "pnlExercise2"
        Me.pnlExercise2.Size = New System.Drawing.Size(1157, 113)
        Me.pnlExercise2.TabIndex = 8
        '
        'txtHeight
        '
        Me.txtHeight.DecimalPlaces = 2
        Me.txtHeight.Location = New System.Drawing.Point(192, 69)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(120, 20)
        Me.txtHeight.TabIndex = 9
        '
        'txtWeight
        '
        Me.txtWeight.DecimalPlaces = 2
        Me.txtWeight.Location = New System.Drawing.Point(61, 69)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(120, 20)
        Me.txtWeight.TabIndex = 8
        '
        'btnExercise2Result
        '
        Me.btnExercise2Result.BackColor = System.Drawing.Color.White
        Me.btnExercise2Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExercise2Result.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnExercise2Result.Location = New System.Drawing.Point(457, 66)
        Me.btnExercise2Result.Name = "btnExercise2Result"
        Me.btnExercise2Result.Size = New System.Drawing.Size(75, 23)
        Me.btnExercise2Result.TabIndex = 7
        Me.btnExercise2Result.Text = "Calular"
        Me.btnExercise2Result.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(324, 49)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(60, 15)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Resultado"
        '
        'txtResultExcercise2
        '
        Me.txtResultExcercise2.Enabled = False
        Me.txtResultExcercise2.Location = New System.Drawing.Point(327, 68)
        Me.txtResultExcercise2.Name = "txtResultExcercise2"
        Me.txtResultExcercise2.Size = New System.Drawing.Size(100, 20)
        Me.txtResultExcercise2.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(189, 49)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(59, 15)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Altura (m)"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(58, 49)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 15)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Peso (Kg)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(57, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Ingresar Datos"
        '
        'richTextBox1
        '
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.richTextBox1.Location = New System.Drawing.Point(0, 66)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(1157, 71)
        Me.richTextBox1.TabIndex = 7
        Me.richTextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Programa para calcular la masa corporal de una persona." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "IMC = Peso (kg) / alt" &
    "ura (m)2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1157, 66)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ejercicios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.AxMedia)
        Me.Panel4.Controls.Add(Me.lblVideo)
        Me.Panel4.Controls.Add(Me.btnContinuousVideo)
        Me.Panel4.Controls.Add(Me.btnPauseVideo)
        Me.Panel4.Controls.Add(Me.btnPlayVideo)
        Me.Panel4.Controls.Add(Me.btnStopVideo)
        Me.Panel4.Location = New System.Drawing.Point(28, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(516, 394)
        Me.Panel4.TabIndex = 9
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblImagenes)
        Me.Panel2.Controls.Add(Me.picLogic)
        Me.Panel2.Controls.Add(Me.rtxbox)
        Me.Panel2.Location = New System.Drawing.Point(565, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 621)
        Me.Panel2.TabIndex = 10
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
        'rtxbox
        '
        Me.rtxbox.Location = New System.Drawing.Point(15, 351)
        Me.rtxbox.Name = "rtxbox"
        Me.rtxbox.Size = New System.Drawing.Size(514, 258)
        Me.rtxbox.TabIndex = 0
        Me.rtxbox.Text = resources.GetString("rtxbox.Text")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnPLayAudio)
        Me.Panel3.Controls.Add(Me.btnStopAudio)
        Me.Panel3.Controls.Add(Me.lblAudio)
        Me.Panel3.Location = New System.Drawing.Point(29, 435)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(512, 213)
        Me.Panel3.TabIndex = 11
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
        'pnlFirst
        '
        Me.pnlFirst.Controls.Add(Me.Panel3)
        Me.pnlFirst.Controls.Add(Me.Panel2)
        Me.pnlFirst.Controls.Add(Me.Panel4)
        Me.pnlFirst.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFirst.Location = New System.Drawing.Point(0, 82)
        Me.pnlFirst.Name = "pnlFirst"
        Me.pnlFirst.Size = New System.Drawing.Size(1157, 684)
        Me.pnlFirst.TabIndex = 6
        '
        'FrmBasicOperations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1174, 812)
        Me.Controls.Add(Me.pnlExamples)
        Me.Controls.Add(Me.pnlFirst)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBasicOperations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBasicOperations"
        Me.pnlExamples.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlExercise3.ResumeLayout(False)
        Me.pnlExercise3.PerformLayout()
        CType(Me.txtConvertNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExercise2.ResumeLayout(False)
        Me.pnlExercise2.PerformLayout()
        CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxMedia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.picLogic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnlFirst.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblTitle As Label
    Friend WithEvents pnlExamples As Panel
    Private WithEvents Label1 As Label
    Private WithEvents pnlExercise3 As Panel
    Private WithEvents label9 As Label
    Private WithEvents txtConvertNum As NumericUpDown
    Private WithEvents cbxTo As ComboBox
    Private WithEvents cbxFrom As ComboBox
    Private WithEvents btnExercise3Result As Button
    Private WithEvents label5 As Label
    Private WithEvents txtResultExcercise3 As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents richTextBox2 As RichTextBox
    Private WithEvents pnlExercise2 As Panel
    Private WithEvents txtHeight As NumericUpDown
    Private WithEvents txtWeight As NumericUpDown
    Private WithEvents btnExercise2Result As Button
    Private WithEvents label4 As Label
    Private WithEvents txtResultExcercise2 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents Label10 As Label
    Private WithEvents richTextBox1 As RichTextBox
    Friend WithEvents AxMedia As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel4 As Panel
    Private WithEvents lblVideo As Label
    Friend WithEvents btnContinuousVideo As Button
    Friend WithEvents btnPauseVideo As Button
    Friend WithEvents btnPlayVideo As Button
    Friend WithEvents btnStopVideo As Button
    Friend WithEvents Panel2 As Panel
    Private WithEvents lblImagenes As Label
    Friend WithEvents picLogic As PictureBox
    Friend WithEvents rtxbox As RichTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPLayAudio As Button
    Friend WithEvents btnStopAudio As Button
    Private WithEvents lblAudio As Label
    Friend WithEvents pnlFirst As Panel
    Private WithEvents Panel1 As Panel
    Private WithEvents BtnInitTest As Button
    Private WithEvents Label15 As Label
End Class
