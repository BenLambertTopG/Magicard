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
        Me.pbColour = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbColour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(21, 169)
        Me.txtTarget.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTarget.MaximumSize = New System.Drawing.Size(36, 20)
        Me.txtTarget.MinimumSize = New System.Drawing.Size(36, 20)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(36, 20)
        Me.txtTarget.TabIndex = 4
        Me.txtTarget.Text = "0.00"
        Me.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelTarget
        '
        Me.LabelTarget.AutoSize = True
        Me.LabelTarget.Location = New System.Drawing.Point(58, 171)
        Me.LabelTarget.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTarget.Name = "LabelTarget"
        Me.LabelTarget.Size = New System.Drawing.Size(38, 13)
        Me.LabelTarget.TabIndex = 1
        Me.LabelTarget.Text = "Target"
        '
        'txtDensity1
        '
        Me.txtDensity1.Location = New System.Drawing.Point(21, 211)
        Me.txtDensity1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDensity1.MaximumSize = New System.Drawing.Size(36, 20)
        Me.txtDensity1.MinimumSize = New System.Drawing.Size(36, 20)
        Me.txtDensity1.Name = "txtDensity1"
        Me.txtDensity1.Size = New System.Drawing.Size(36, 20)
        Me.txtDensity1.TabIndex = 6
        Me.txtDensity1.Text = "1.00"
        Me.txtDensity1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDensity2
        '
        Me.txtDensity2.Location = New System.Drawing.Point(21, 231)
        Me.txtDensity2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDensity2.MaximumSize = New System.Drawing.Size(36, 20)
        Me.txtDensity2.MinimumSize = New System.Drawing.Size(36, 20)
        Me.txtDensity2.Name = "txtDensity2"
        Me.txtDensity2.Size = New System.Drawing.Size(36, 20)
        Me.txtDensity2.TabIndex = 7
        Me.txtDensity2.Text = "1.00"
        Me.txtDensity2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelDensity1
        '
        Me.LabelDensity1.AutoSize = True
        Me.LabelDensity1.Location = New System.Drawing.Point(58, 213)
        Me.LabelDensity1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDensity1.Name = "LabelDensity1"
        Me.LabelDensity1.Size = New System.Drawing.Size(51, 13)
        Me.LabelDensity1.TabIndex = 4
        Me.LabelDensity1.Text = "Density 1"
        '
        'LabelDensity2
        '
        Me.LabelDensity2.AutoSize = True
        Me.LabelDensity2.Location = New System.Drawing.Point(58, 233)
        Me.LabelDensity2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDensity2.Name = "LabelDensity2"
        Me.LabelDensity2.Size = New System.Drawing.Size(51, 13)
        Me.LabelDensity2.TabIndex = 5
        Me.LabelDensity2.Text = "Density 2"
        '
        'txtDensity3
        '
        Me.txtDensity3.Location = New System.Drawing.Point(21, 252)
        Me.txtDensity3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDensity3.MaximumSize = New System.Drawing.Size(36, 20)
        Me.txtDensity3.MinimumSize = New System.Drawing.Size(36, 20)
        Me.txtDensity3.Name = "txtDensity3"
        Me.txtDensity3.Size = New System.Drawing.Size(36, 20)
        Me.txtDensity3.TabIndex = 8
        Me.txtDensity3.Text = "1.00"
        Me.txtDensity3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelDensity3
        '
        Me.LabelDensity3.AutoSize = True
        Me.LabelDensity3.Location = New System.Drawing.Point(58, 254)
        Me.LabelDensity3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDensity3.Name = "LabelDensity3"
        Me.LabelDensity3.Size = New System.Drawing.Size(51, 13)
        Me.LabelDensity3.TabIndex = 7
        Me.LabelDensity3.Text = "Density 3"
        '
        'txtCurrentPower
        '
        Me.txtCurrentPower.Location = New System.Drawing.Point(21, 190)
        Me.txtCurrentPower.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCurrentPower.MaximumSize = New System.Drawing.Size(36, 20)
        Me.txtCurrentPower.MinimumSize = New System.Drawing.Size(36, 20)
        Me.txtCurrentPower.Name = "txtCurrentPower"
        Me.txtCurrentPower.Size = New System.Drawing.Size(36, 20)
        Me.txtCurrentPower.TabIndex = 5
        Me.txtCurrentPower.Text = "000"
        Me.txtCurrentPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelCurrentPower
        '
        Me.LabelCurrentPower.AutoSize = True
        Me.LabelCurrentPower.Location = New System.Drawing.Point(58, 192)
        Me.LabelCurrentPower.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCurrentPower.Name = "LabelCurrentPower"
        Me.LabelCurrentPower.Size = New System.Drawing.Size(74, 13)
        Me.LabelCurrentPower.TabIndex = 9
        Me.LabelCurrentPower.Text = "Current Power"
        '
        'txtCurrentDensity
        '
        Me.txtCurrentDensity.Location = New System.Drawing.Point(21, 273)
        Me.txtCurrentDensity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCurrentDensity.MaximumSize = New System.Drawing.Size(36, 20)
        Me.txtCurrentDensity.MinimumSize = New System.Drawing.Size(36, 20)
        Me.txtCurrentDensity.Name = "txtCurrentDensity"
        Me.txtCurrentDensity.Size = New System.Drawing.Size(36, 20)
        Me.txtCurrentDensity.TabIndex = 9
        Me.txtCurrentDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelCurrentDensity
        '
        Me.LabelCurrentDensity.AutoSize = True
        Me.LabelCurrentDensity.Location = New System.Drawing.Point(58, 275)
        Me.LabelCurrentDensity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCurrentDensity.Name = "LabelCurrentDensity"
        Me.LabelCurrentDensity.Size = New System.Drawing.Size(79, 13)
        Me.LabelCurrentDensity.TabIndex = 11
        Me.LabelCurrentDensity.Text = "Current Density"
        '
        'txtRecommenedPower
        '
        Me.txtRecommenedPower.Location = New System.Drawing.Point(21, 294)
        Me.txtRecommenedPower.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRecommenedPower.MaximumSize = New System.Drawing.Size(36, 20)
        Me.txtRecommenedPower.MinimumSize = New System.Drawing.Size(36, 20)
        Me.txtRecommenedPower.Name = "txtRecommenedPower"
        Me.txtRecommenedPower.Size = New System.Drawing.Size(36, 20)
        Me.txtRecommenedPower.TabIndex = 10
        Me.txtRecommenedPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelRecommendedPower
        '
        Me.LabelRecommendedPower.AutoSize = True
        Me.LabelRecommendedPower.Location = New System.Drawing.Point(58, 296)
        Me.LabelRecommendedPower.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRecommendedPower.Name = "LabelRecommendedPower"
        Me.LabelRecommendedPower.Size = New System.Drawing.Size(112, 13)
        Me.LabelRecommendedPower.TabIndex = 13
        Me.LabelRecommendedPower.Text = "Recommended Power"
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCalculate.Location = New System.Drawing.Point(192, 275)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.MaximumSize = New System.Drawing.Size(79, 39)
        Me.btnCalculate.MinimumSize = New System.Drawing.Size(79, 39)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(79, 39)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'CBCleanPrinthead
        '
        Me.CBCleanPrinthead.AutoSize = True
        Me.CBCleanPrinthead.Location = New System.Drawing.Point(21, 81)
        Me.CBCleanPrinthead.Margin = New System.Windows.Forms.Padding(2)
        Me.CBCleanPrinthead.Name = "CBCleanPrinthead"
        Me.CBCleanPrinthead.Size = New System.Drawing.Size(154, 17)
        Me.CBCleanPrinthead.TabIndex = 0
        Me.CBCleanPrinthead.TabStop = False
        Me.CBCleanPrinthead.Text = "Clean and Adjust Printhead"
        Me.CBCleanPrinthead.UseVisualStyleBackColor = True
        '
        'CBCleaningStrip
        '
        Me.CBCleaningStrip.AutoSize = True
        Me.CBCleaningStrip.Location = New System.Drawing.Point(21, 103)
        Me.CBCleaningStrip.Margin = New System.Windows.Forms.Padding(2)
        Me.CBCleaningStrip.Name = "CBCleaningStrip"
        Me.CBCleaningStrip.Size = New System.Drawing.Size(113, 17)
        Me.CBCleaningStrip.TabIndex = 1
        Me.CBCleaningStrip.TabStop = False
        Me.CBCleaningStrip.Text = "Use Cleaning Strip"
        Me.CBCleaningStrip.UseVisualStyleBackColor = True
        '
        'CBDyeFilm
        '
        Me.CBDyeFilm.AutoSize = True
        Me.CBDyeFilm.Location = New System.Drawing.Point(21, 124)
        Me.CBDyeFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.CBDyeFilm.Name = "CBDyeFilm"
        Me.CBDyeFilm.Size = New System.Drawing.Size(95, 17)
        Me.CBDyeFilm.TabIndex = 2
        Me.CBDyeFilm.TabStop = False
        Me.CBDyeFilm.Text = "Insert Dye Film"
        Me.CBDyeFilm.UseVisualStyleBackColor = True
        '
        'CBPrinterID
        '
        Me.CBPrinterID.AutoSize = True
        Me.CBPrinterID.Location = New System.Drawing.Point(21, 146)
        Me.CBPrinterID.Margin = New System.Windows.Forms.Padding(2)
        Me.CBPrinterID.Name = "CBPrinterID"
        Me.CBPrinterID.Size = New System.Drawing.Size(179, 17)
        Me.CBPrinterID.TabIndex = 3
        Me.CBPrinterID.TabStop = False
        Me.CBPrinterID.Text = "Change Printer and Printhead ID"
        Me.CBPrinterID.UseVisualStyleBackColor = True
        '
        'CBDensityCard
        '
        Me.CBDensityCard.AutoSize = True
        Me.CBDensityCard.Location = New System.Drawing.Point(21, 322)
        Me.CBDensityCard.Margin = New System.Windows.Forms.Padding(2)
        Me.CBDensityCard.Name = "CBDensityCard"
        Me.CBDensityCard.Size = New System.Drawing.Size(86, 17)
        Me.CBDensityCard.TabIndex = 12
        Me.CBDensityCard.TabStop = False
        Me.CBDensityCard.Text = "Density Card"
        Me.CBDensityCard.UseVisualStyleBackColor = True
        '
        'CBBleed
        '
        Me.CBBleed.AutoSize = True
        Me.CBBleed.Location = New System.Drawing.Point(21, 342)
        Me.CBBleed.Margin = New System.Windows.Forms.Padding(2)
        Me.CBBleed.Name = "CBBleed"
        Me.CBBleed.Size = New System.Drawing.Size(122, 17)
        Me.CBBleed.TabIndex = 13
        Me.CBBleed.TabStop = False
        Me.CBBleed.Text = "Auto Full Bleed Card"
        Me.CBBleed.UseVisualStyleBackColor = True
        '
        'CBConfidence
        '
        Me.CBConfidence.AutoSize = True
        Me.CBConfidence.Location = New System.Drawing.Point(21, 362)
        Me.CBConfidence.Margin = New System.Windows.Forms.Padding(2)
        Me.CBConfidence.Name = "CBConfidence"
        Me.CBConfidence.Size = New System.Drawing.Size(116, 17)
        Me.CBConfidence.TabIndex = 14
        Me.CBConfidence.TabStop = False
        Me.CBConfidence.Text = "Confidence Card(s)"
        Me.CBConfidence.UseVisualStyleBackColor = True
        '
        'CBTestPrint
        '
        Me.CBTestPrint.AutoSize = True
        Me.CBTestPrint.Location = New System.Drawing.Point(21, 381)
        Me.CBTestPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.CBTestPrint.Name = "CBTestPrint"
        Me.CBTestPrint.Size = New System.Drawing.Size(96, 17)
        Me.CBTestPrint.TabIndex = 15
        Me.CBTestPrint.TabStop = False
        Me.CBTestPrint.Text = "Test Print Card"
        Me.CBTestPrint.UseVisualStyleBackColor = True
        '
        'CBDatabase
        '
        Me.CBDatabase.AutoSize = True
        Me.CBDatabase.Location = New System.Drawing.Point(21, 420)
        Me.CBDatabase.Margin = New System.Windows.Forms.Padding(2)
        Me.CBDatabase.Name = "CBDatabase"
        Me.CBDatabase.Size = New System.Drawing.Size(218, 17)
        Me.CBDatabase.TabIndex = 17
        Me.CBDatabase.TabStop = False
        Me.CBDatabase.Text = "Add Printer to Database and Scan Cards"
        Me.CBDatabase.UseVisualStyleBackColor = True
        '
        'CBStrip2
        '
        Me.CBStrip2.AutoSize = True
        Me.CBStrip2.Location = New System.Drawing.Point(21, 400)
        Me.CBStrip2.Margin = New System.Windows.Forms.Padding(2)
        Me.CBStrip2.Name = "CBStrip2"
        Me.CBStrip2.Size = New System.Drawing.Size(156, 17)
        Me.CBStrip2.TabIndex = 16
        Me.CBStrip2.TabStop = False
        Me.CBStrip2.Text = "Reclean with Cleaning Strip"
        Me.CBStrip2.UseVisualStyleBackColor = True
        '
        'CBPaint
        '
        Me.CBPaint.AutoSize = True
        Me.CBPaint.Location = New System.Drawing.Point(21, 439)
        Me.CBPaint.Margin = New System.Windows.Forms.Padding(2)
        Me.CBPaint.Name = "CBPaint"
        Me.CBPaint.Size = New System.Drawing.Size(82, 17)
        Me.CBPaint.TabIndex = 18
        Me.CBPaint.TabStop = False
        Me.CBPaint.Text = "Green Paint"
        Me.CBPaint.UseVisualStyleBackColor = True
        '
        'pbColour
        '
        Me.pbColour.BackColor = System.Drawing.Color.Red
        Me.pbColour.Location = New System.Drawing.Point(275, 275)
        Me.pbColour.Margin = New System.Windows.Forms.Padding(2)
        Me.pbColour.MaximumSize = New System.Drawing.Size(36, 39)
        Me.pbColour.MinimumSize = New System.Drawing.Size(36, 39)
        Me.pbColour.Name = "pbColour"
        Me.pbColour.Size = New System.Drawing.Size(36, 39)
        Me.pbColour.TabIndex = 15
        Me.pbColour.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Location = New System.Drawing.Point(61, 466)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.MaximumSize = New System.Drawing.Size(204, 27)
        Me.btnClear.MinimumSize = New System.Drawing.Size(204, 27)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 27)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(114, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(111, 56)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(111, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'TestTrainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(333, 504)
        Me.Controls.Add(Me.pbColour)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.LabelRecommendedPower)
        Me.Controls.Add(Me.txtRecommenedPower)
        Me.Controls.Add(Me.CBPaint)
        Me.Controls.Add(Me.LabelCurrentDensity)
        Me.Controls.Add(Me.CBStrip2)
        Me.Controls.Add(Me.txtCurrentDensity)
        Me.Controls.Add(Me.CBDatabase)
        Me.Controls.Add(Me.LabelCurrentPower)
        Me.Controls.Add(Me.CBTestPrint)
        Me.Controls.Add(Me.txtCurrentPower)
        Me.Controls.Add(Me.CBConfidence)
        Me.Controls.Add(Me.LabelDensity3)
        Me.Controls.Add(Me.CBBleed)
        Me.Controls.Add(Me.txtDensity3)
        Me.Controls.Add(Me.CBDensityCard)
        Me.Controls.Add(Me.LabelDensity2)
        Me.Controls.Add(Me.CBPrinterID)
        Me.Controls.Add(Me.LabelDensity1)
        Me.Controls.Add(Me.CBDyeFilm)
        Me.Controls.Add(Me.txtDensity2)
        Me.Controls.Add(Me.CBCleaningStrip)
        Me.Controls.Add(Me.txtDensity1)
        Me.Controls.Add(Me.CBCleanPrinthead)
        Me.Controls.Add(Me.LabelTarget)
        Me.Controls.Add(Me.txtTarget)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TestTrainer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Test Trainer"
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
    Friend WithEvents btnClear As Button
    Friend WithEvents pbColour As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
