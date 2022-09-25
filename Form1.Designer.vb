<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestTrainer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestTrainer))
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.LabelTarget = New System.Windows.Forms.Label()
        Me.txtDensity1 = New System.Windows.Forms.TextBox()
        Me.txtDensity2 = New System.Windows.Forms.TextBox()
        Me.LabelDensity1 = New System.Windows.Forms.Label()
        Me.LabelDensity2 = New System.Windows.Forms.Label()
        Me.txtDensity3 = New System.Windows.Forms.TextBox()
        Me.LabelDensity3 = New System.Windows.Forms.Label()
        Me.txtCurrentPower = New System.Windows.Forms.TextBox()
        Me.LabelCurrentPower = New System.Windows.Forms.Label()
        Me.txtCurrentDensity = New System.Windows.Forms.TextBox()
        Me.LabelCurrentDensity = New System.Windows.Forms.Label()
        Me.txtRecommenedPower = New System.Windows.Forms.TextBox()
        Me.LabelRecommendedPower = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.CBCleanPrinthead = New System.Windows.Forms.CheckBox()
        Me.CBCleaningStrip = New System.Windows.Forms.CheckBox()
        Me.CBDyeFilm = New System.Windows.Forms.CheckBox()
        Me.CBPrinterID = New System.Windows.Forms.CheckBox()
        Me.CBDensityCard = New System.Windows.Forms.CheckBox()
        Me.CBBleed = New System.Windows.Forms.CheckBox()
        Me.CBConfidence = New System.Windows.Forms.CheckBox()
        Me.CBTestPrint = New System.Windows.Forms.CheckBox()
        Me.CBDatabase = New System.Windows.Forms.CheckBox()
        Me.CBStrip2 = New System.Windows.Forms.CheckBox()
        Me.CBPaint = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbColour = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbColour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(57, 35)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(100, 26)
        Me.txtTarget.TabIndex = 4
        Me.txtTarget.Text = "0.00"
        Me.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelTarget
        '
        Me.LabelTarget.AutoSize = True
        Me.LabelTarget.Location = New System.Drawing.Point(163, 38)
        Me.LabelTarget.Name = "LabelTarget"
        Me.LabelTarget.Size = New System.Drawing.Size(55, 20)
        Me.LabelTarget.TabIndex = 1
        Me.LabelTarget.Text = "Target"
        '
        'txtDensity1
        '
        Me.txtDensity1.Location = New System.Drawing.Point(57, 99)
        Me.txtDensity1.Name = "txtDensity1"
        Me.txtDensity1.Size = New System.Drawing.Size(100, 26)
        Me.txtDensity1.TabIndex = 6
        Me.txtDensity1.Text = "1.00"
        Me.txtDensity1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDensity2
        '
        Me.txtDensity2.Location = New System.Drawing.Point(57, 131)
        Me.txtDensity2.Name = "txtDensity2"
        Me.txtDensity2.Size = New System.Drawing.Size(100, 26)
        Me.txtDensity2.TabIndex = 7
        Me.txtDensity2.Text = "1.00"
        Me.txtDensity2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelDensity1
        '
        Me.LabelDensity1.AutoSize = True
        Me.LabelDensity1.Location = New System.Drawing.Point(163, 102)
        Me.LabelDensity1.Name = "LabelDensity1"
        Me.LabelDensity1.Size = New System.Drawing.Size(75, 20)
        Me.LabelDensity1.TabIndex = 4
        Me.LabelDensity1.Text = "Density 1"
        '
        'LabelDensity2
        '
        Me.LabelDensity2.AutoSize = True
        Me.LabelDensity2.Location = New System.Drawing.Point(163, 134)
        Me.LabelDensity2.Name = "LabelDensity2"
        Me.LabelDensity2.Size = New System.Drawing.Size(75, 20)
        Me.LabelDensity2.TabIndex = 5
        Me.LabelDensity2.Text = "Density 2"
        '
        'txtDensity3
        '
        Me.txtDensity3.Location = New System.Drawing.Point(57, 163)
        Me.txtDensity3.Name = "txtDensity3"
        Me.txtDensity3.Size = New System.Drawing.Size(100, 26)
        Me.txtDensity3.TabIndex = 8
        Me.txtDensity3.Text = "1.00"
        Me.txtDensity3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelDensity3
        '
        Me.LabelDensity3.AutoSize = True
        Me.LabelDensity3.Location = New System.Drawing.Point(163, 166)
        Me.LabelDensity3.Name = "LabelDensity3"
        Me.LabelDensity3.Size = New System.Drawing.Size(75, 20)
        Me.LabelDensity3.TabIndex = 7
        Me.LabelDensity3.Text = "Density 3"
        '
        'txtCurrentPower
        '
        Me.txtCurrentPower.Location = New System.Drawing.Point(57, 67)
        Me.txtCurrentPower.Name = "txtCurrentPower"
        Me.txtCurrentPower.Size = New System.Drawing.Size(100, 26)
        Me.txtCurrentPower.TabIndex = 5
        Me.txtCurrentPower.Text = "000"
        Me.txtCurrentPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelCurrentPower
        '
        Me.LabelCurrentPower.AutoSize = True
        Me.LabelCurrentPower.Location = New System.Drawing.Point(163, 70)
        Me.LabelCurrentPower.Name = "LabelCurrentPower"
        Me.LabelCurrentPower.Size = New System.Drawing.Size(110, 20)
        Me.LabelCurrentPower.TabIndex = 9
        Me.LabelCurrentPower.Text = "Current Power"
        '
        'txtCurrentDensity
        '
        Me.txtCurrentDensity.Location = New System.Drawing.Point(57, 195)
        Me.txtCurrentDensity.Name = "txtCurrentDensity"
        Me.txtCurrentDensity.Size = New System.Drawing.Size(100, 26)
        Me.txtCurrentDensity.TabIndex = 9
        Me.txtCurrentDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelCurrentDensity
        '
        Me.LabelCurrentDensity.AutoSize = True
        Me.LabelCurrentDensity.Location = New System.Drawing.Point(163, 198)
        Me.LabelCurrentDensity.Name = "LabelCurrentDensity"
        Me.LabelCurrentDensity.Size = New System.Drawing.Size(119, 20)
        Me.LabelCurrentDensity.TabIndex = 11
        Me.LabelCurrentDensity.Text = "Current Density"
        '
        'txtRecommenedPower
        '
        Me.txtRecommenedPower.Location = New System.Drawing.Point(57, 227)
        Me.txtRecommenedPower.Name = "txtRecommenedPower"
        Me.txtRecommenedPower.Size = New System.Drawing.Size(100, 26)
        Me.txtRecommenedPower.TabIndex = 10
        Me.txtRecommenedPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelRecommendedPower
        '
        Me.LabelRecommendedPower.AutoSize = True
        Me.LabelRecommendedPower.Location = New System.Drawing.Point(163, 230)
        Me.LabelRecommendedPower.Name = "LabelRecommendedPower"
        Me.LabelRecommendedPower.Size = New System.Drawing.Size(166, 20)
        Me.LabelRecommendedPower.TabIndex = 13
        Me.LabelRecommendedPower.Text = "Recommended Power"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(57, 269)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(272, 115)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'CBCleanPrinthead
        '
        Me.CBCleanPrinthead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBCleanPrinthead.AutoSize = True
        Me.CBCleanPrinthead.Location = New System.Drawing.Point(111, 296)
        Me.CBCleanPrinthead.Name = "CBCleanPrinthead"
        Me.CBCleanPrinthead.Size = New System.Drawing.Size(228, 24)
        Me.CBCleanPrinthead.TabIndex = 0
        Me.CBCleanPrinthead.TabStop = False
        Me.CBCleanPrinthead.Text = "Clean and Adjust Printhead"
        Me.CBCleanPrinthead.UseVisualStyleBackColor = True
        '
        'CBCleaningStrip
        '
        Me.CBCleaningStrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBCleaningStrip.AutoSize = True
        Me.CBCleaningStrip.Location = New System.Drawing.Point(111, 329)
        Me.CBCleaningStrip.Name = "CBCleaningStrip"
        Me.CBCleaningStrip.Size = New System.Drawing.Size(167, 24)
        Me.CBCleaningStrip.TabIndex = 1
        Me.CBCleaningStrip.TabStop = False
        Me.CBCleaningStrip.Text = "Use Cleaning Strip"
        Me.CBCleaningStrip.UseVisualStyleBackColor = True
        '
        'CBDyeFilm
        '
        Me.CBDyeFilm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBDyeFilm.AutoSize = True
        Me.CBDyeFilm.Location = New System.Drawing.Point(111, 362)
        Me.CBDyeFilm.Name = "CBDyeFilm"
        Me.CBDyeFilm.Size = New System.Drawing.Size(141, 24)
        Me.CBDyeFilm.TabIndex = 2
        Me.CBDyeFilm.TabStop = False
        Me.CBDyeFilm.Text = "Insert Dye Film"
        Me.CBDyeFilm.UseVisualStyleBackColor = True
        '
        'CBPrinterID
        '
        Me.CBPrinterID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBPrinterID.AutoSize = True
        Me.CBPrinterID.Location = New System.Drawing.Point(111, 395)
        Me.CBPrinterID.Name = "CBPrinterID"
        Me.CBPrinterID.Size = New System.Drawing.Size(265, 24)
        Me.CBPrinterID.TabIndex = 3
        Me.CBPrinterID.TabStop = False
        Me.CBPrinterID.Text = "Change Printer and Printhead ID"
        Me.CBPrinterID.UseVisualStyleBackColor = True
        '
        'CBDensityCard
        '
        Me.CBDensityCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBDensityCard.AutoSize = True
        Me.CBDensityCard.Location = New System.Drawing.Point(111, 864)
        Me.CBDensityCard.Name = "CBDensityCard"
        Me.CBDensityCard.Size = New System.Drawing.Size(126, 24)
        Me.CBDensityCard.TabIndex = 12
        Me.CBDensityCard.TabStop = False
        Me.CBDensityCard.Text = "Density Card"
        Me.CBDensityCard.UseVisualStyleBackColor = True
        '
        'CBBleed
        '
        Me.CBBleed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBBleed.AutoSize = True
        Me.CBBleed.Location = New System.Drawing.Point(111, 894)
        Me.CBBleed.Name = "CBBleed"
        Me.CBBleed.Size = New System.Drawing.Size(181, 24)
        Me.CBBleed.TabIndex = 13
        Me.CBBleed.TabStop = False
        Me.CBBleed.Text = "Auto Full Bleed Card"
        Me.CBBleed.UseVisualStyleBackColor = True
        '
        'CBConfidence
        '
        Me.CBConfidence.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBConfidence.AutoSize = True
        Me.CBConfidence.Location = New System.Drawing.Point(111, 924)
        Me.CBConfidence.Name = "CBConfidence"
        Me.CBConfidence.Size = New System.Drawing.Size(172, 24)
        Me.CBConfidence.TabIndex = 14
        Me.CBConfidence.TabStop = False
        Me.CBConfidence.Text = "Confidence Card(s)"
        Me.CBConfidence.UseVisualStyleBackColor = True
        '
        'CBTestPrint
        '
        Me.CBTestPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBTestPrint.AutoSize = True
        Me.CBTestPrint.Location = New System.Drawing.Point(111, 954)
        Me.CBTestPrint.Name = "CBTestPrint"
        Me.CBTestPrint.Size = New System.Drawing.Size(140, 24)
        Me.CBTestPrint.TabIndex = 15
        Me.CBTestPrint.TabStop = False
        Me.CBTestPrint.Text = "Test Print Card"
        Me.CBTestPrint.UseVisualStyleBackColor = True
        '
        'CBDatabase
        '
        Me.CBDatabase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBDatabase.AutoSize = True
        Me.CBDatabase.Location = New System.Drawing.Point(111, 1014)
        Me.CBDatabase.Name = "CBDatabase"
        Me.CBDatabase.Size = New System.Drawing.Size(324, 24)
        Me.CBDatabase.TabIndex = 17
        Me.CBDatabase.TabStop = False
        Me.CBDatabase.Text = "Add Printer to Database and Scan Cards"
        Me.CBDatabase.UseVisualStyleBackColor = True
        '
        'CBStrip2
        '
        Me.CBStrip2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBStrip2.AutoSize = True
        Me.CBStrip2.Location = New System.Drawing.Point(111, 984)
        Me.CBStrip2.Name = "CBStrip2"
        Me.CBStrip2.Size = New System.Drawing.Size(229, 24)
        Me.CBStrip2.TabIndex = 16
        Me.CBStrip2.TabStop = False
        Me.CBStrip2.Text = "Reclean with Cleaning Strip"
        Me.CBStrip2.UseVisualStyleBackColor = True
        '
        'CBPaint
        '
        Me.CBPaint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBPaint.AutoSize = True
        Me.CBPaint.Location = New System.Drawing.Point(111, 1044)
        Me.CBPaint.Name = "CBPaint"
        Me.CBPaint.Size = New System.Drawing.Size(120, 24)
        Me.CBPaint.TabIndex = 18
        Me.CBPaint.TabStop = False
        Me.CBPaint.Text = "Green Paint"
        Me.CBPaint.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.pbColour)
        Me.Panel1.Controls.Add(Me.btnCalculate)
        Me.Panel1.Controls.Add(Me.LabelRecommendedPower)
        Me.Panel1.Controls.Add(Me.txtRecommenedPower)
        Me.Panel1.Controls.Add(Me.LabelCurrentDensity)
        Me.Panel1.Controls.Add(Me.txtCurrentDensity)
        Me.Panel1.Controls.Add(Me.LabelCurrentPower)
        Me.Panel1.Controls.Add(Me.txtCurrentPower)
        Me.Panel1.Controls.Add(Me.LabelDensity3)
        Me.Panel1.Controls.Add(Me.txtDensity3)
        Me.Panel1.Controls.Add(Me.LabelDensity2)
        Me.Panel1.Controls.Add(Me.LabelDensity1)
        Me.Panel1.Controls.Add(Me.txtDensity2)
        Me.Panel1.Controls.Add(Me.txtDensity1)
        Me.Panel1.Controls.Add(Me.LabelTarget)
        Me.Panel1.Controls.Add(Me.txtTarget)
        Me.Panel1.Location = New System.Drawing.Point(50, 437)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 402)
        Me.Panel1.TabIndex = 37
        '
        'pbColour
        '
        Me.pbColour.BackColor = System.Drawing.Color.Red
        Me.pbColour.Location = New System.Drawing.Point(345, 290)
        Me.pbColour.Name = "pbColour"
        Me.pbColour.Size = New System.Drawing.Size(72, 79)
        Me.pbColour.TabIndex = 15
        Me.pbColour.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(111, 1085)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(218, 64)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(50, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(455, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'TestTrainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(556, 1203)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CBPaint)
        Me.Controls.Add(Me.CBStrip2)
        Me.Controls.Add(Me.CBDatabase)
        Me.Controls.Add(Me.CBTestPrint)
        Me.Controls.Add(Me.CBConfidence)
        Me.Controls.Add(Me.CBBleed)
        Me.Controls.Add(Me.CBDensityCard)
        Me.Controls.Add(Me.CBPrinterID)
        Me.Controls.Add(Me.CBDyeFilm)
        Me.Controls.Add(Me.CBCleaningStrip)
        Me.Controls.Add(Me.CBCleanPrinthead)
        Me.Name = "TestTrainer"
        Me.Text = "Test Trainer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbColour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTarget As TextBox
    Friend WithEvents LabelTarget As Label
    Friend WithEvents txtDensity1 As TextBox
    Friend WithEvents txtDensity2 As TextBox
    Friend WithEvents LabelDensity1 As Label
    Friend WithEvents LabelDensity2 As Label
    Friend WithEvents txtDensity3 As TextBox
    Friend WithEvents LabelDensity3 As Label
    Friend WithEvents txtCurrentPower As TextBox
    Friend WithEvents LabelCurrentPower As Label
    Friend WithEvents txtCurrentDensity As TextBox
    Friend WithEvents LabelCurrentDensity As Label
    Friend WithEvents txtRecommenedPower As TextBox
    Friend WithEvents LabelRecommendedPower As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents CBCleanPrinthead As CheckBox
    Friend WithEvents CBCleaningStrip As CheckBox
    Friend WithEvents CBDyeFilm As CheckBox
    Friend WithEvents CBPrinterID As CheckBox
    Friend WithEvents CBDensityCard As CheckBox
    Friend WithEvents CBBleed As CheckBox
    Friend WithEvents CBConfidence As CheckBox
    Friend WithEvents CBTestPrint As CheckBox
    Friend WithEvents CBDatabase As CheckBox
    Friend WithEvents CBStrip2 As CheckBox
    Friend WithEvents CBPaint As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents pbColour As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
