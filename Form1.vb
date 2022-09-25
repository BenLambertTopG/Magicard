Public Class TestTrainer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelDensity2.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click 'Density Form Code


        Dim Target As Decimal
        Dim CurrentPower As Integer
        Dim Density1 As Decimal
        Dim Density2 As Decimal
        Dim Density3 As Decimal
        Dim TotalDensity As Decimal
        Dim CurrentDensity As Decimal
        Dim DensityDiff As Decimal
        Dim DensityComp As Decimal
        Dim RecommendedPower As Integer


        'This is the user input
        Target = txtTarget.Text
        CurrentPower = txtCurrentPower.Text
        Density1 = txtDensity1.Text
        Density2 = txtDensity2.Text
        Density3 = txtDensity3.Text


        'The math calculation
        TotalDensity = Density1 + Density2 + Density3
        CurrentDensity = TotalDensity / 3
        DensityDiff = Target - CurrentDensity
        DensityComp = DensityDiff / 2
        RecommendedPower = CurrentPower + (DensityComp * 100)


        txtCurrentDensity.Text = CurrentDensity
        txtRecommenedPower.Text = RecommendedPower


        'Rounding Current Desnity to two decimals MAX

        txtCurrentDensity.Text = Math.Round(Val(txtCurrentDensity.Text), 2)


        'Code to change backgorund colour of Box if density is in range
        If (DensityDiff <= 0.05) Then pbColour.BackColor = Color.Green
        If (DensityDiff > 0.05) Then pbColour.BackColor = Color.Red
        If (DensityDiff < 0.00) Then pbColour.BackColor = Color.Red


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click


        'Code to clear checkboxes
        CBCleanPrinthead.Checked = False
        CBBleed.Checked = False
        CBCleaningStrip.Checked = False
        CBDyeFilm.Checked = False
        CBDyeFilm.Checked = False
        CBPrinterID.Checked = False


        'Density Form is here

        'code to clear the last of the check boxes
        CBDensityCard.Checked = False
        CBBleed.Checked = False
        CBConfidence.Checked = False
        CBTestPrint.Checked = False
        CBDatabase.Checked = False
        CBStrip2.Checked = False
        CBPaint.Checked = False


        'Returns the Color Square back to Red
        pbColour.BackColor = Color.Red


    End Sub

    Private Sub txtTarget_Click(sender As Object, e As EventArgs) Handles txtTarget.Click

        txtTarget.SelectAll()

    End Sub

    Private Sub txtCurrentPower_Click(sender As Object, e As EventArgs) Handles txtCurrentPower.Click

        txtCurrentPower.SelectAll()

    End Sub

    Private Sub txtDensity1_Click(sender As Object, e As EventArgs) Handles txtDensity1.Click

        txtDensity1.SelectAll()

    End Sub

    Private Sub txtDensity2_Click(sender As Object, e As EventArgs) Handles txtDensity2.Click

        txtDensity2.SelectAll()

    End Sub

    Private Sub txtDensity3_Click(sender As Object, e As EventArgs) Handles txtDensity3.Click

        txtDensity3.SelectAll()

    End Sub
    Private Sub txtTarget_Enter(sender As Object, e As EventArgs) Handles txtTarget.Enter

        txtTarget.SelectAll() 'This enables quick auto highlight of text for faster change


    End Sub


    Private Sub txtCurrentPower_Enter(sender As Object, e As EventArgs) Handles txtCurrentPower.Enter

        txtCurrentPower.SelectAll()

    End Sub

    Private Sub txtDensity1_Enter(sender As Object, e As EventArgs) Handles txtDensity1.Enter

        txtDensity1.SelectAll()

    End Sub

    Private Sub txtDensity2_Enter(sender As Object, e As EventArgs) Handles txtDensity2.Enter

        txtDensity2.SelectAll()

    End Sub

    Private Sub txtDensity3_Enter(sender As Object, e As EventArgs) Handles txtDensity3.Enter

        txtDensity3.SelectAll()

    End Sub

    Private Sub TestTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class