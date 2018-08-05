Imports System.IO
Imports CoverageLevelCalculator

Public Class CLCalcExample
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadCoverageLevelComboBox()
		LoadDeductionFrequencyComboBox()
	End Sub

	Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
		Try
			Dim strSelectedCoverageLevel As String = cmbCL.SelectedItem
			If String.IsNullOrEmpty(strSelectedCoverageLevel) Then
				lblResults.Text = "Please select a Coverage Level!"
				Exit Sub
			End If

			Dim strDeductionFrequency As String = cmbDF.SelectedItem
			If String.IsNullOrEmpty(strDeductionFrequency) Then
				lblResults.Text = "Please select a Deduction Frequency!"
				Exit Sub
			End If

			Dim strFilePath As String = String.Format("{0}\{1}", Path.Combine(Directory.GetCurrentDirectory(), "Data"), "Rates.xml")
			Dim quotingModule As IQuotingModule = New QuotingModule(strFilePath)
			Dim intCoverageLevelID As Integer = GetCoverageLevelID(strSelectedCoverageLevel)
			Dim intDeductionFrequencyID As Integer = GetDeductionFrequencyID(strDeductionFrequency)
			Dim dcmPremium As Decimal = quotingModule.CalculatePremiumForCoverageLevelDeductionFrequency(intCoverageLevelID, intDeductionFrequencyID)

			lblResults.Text = String.Format("{0} coverage for {1} {2}", strSelectedCoverageLevel, dcmPremium.ToString("C"), strDeductionFrequency)
		Catch ex As Exception
			'For Now...
			lblResults.Text = ex.ToString()
		End Try
	End Sub

	Private Sub LoadCoverageLevelComboBox()
		'TODO: Get values from Rates file
		cmbCL.Items.Add("Employee Only")
		cmbCL.Items.Add("Employee Plus Children")
		cmbCL.Items.Add("Employee Plus Spouse")
		cmbCL.Items.Add("Family")
	End Sub

	Private Sub LoadDeductionFrequencyComboBox()
		'TODO: Get values from somewhere and add option for custom entry
		cmbDF.Items.Add("Weekly")       '52
		cmbDF.Items.Add("Bi-Weekly")    '26
		cmbDF.Items.Add("Semi-Monthly") '24
		cmbDF.Items.Add("Monthly")      '12
		cmbDF.Items.Add("Quarterly")    '4
		cmbDF.Items.Add("Yearly")       '1
	End Sub

	Private Function GetCoverageLevelID(coverageLevel As String) As Integer
		'Would be better to get ID from Rates File or have ID binded with ComboBox
		Select Case coverageLevel
			Case "Employee Only"
				Return 1
			Case "Employee Plus Children"
				Return 2
			Case "Employee Plus Spouse"
				Return 3
			Case "Family"
				Return 4
		End Select
		Throw New Exception("Invalid Coverage Level Selection!")
	End Function

	Private Function GetDeductionFrequencyID(deductionFrequency As String) As Integer
		'Would be better to get ID from Rates File or have ID binded with ComboBox
		Select Case deductionFrequency
			Case "Weekly"
				Return 52
			Case "Bi-Weekly"
				Return 26
			Case "Semi-Monthly"
				Return 24
			Case "Monthly"
				Return 12
			Case "Quarterly"
				Return 4
			Case "Yearly"
				Return 1
		End Select
		Throw New Exception("Invalid Coverage Level Selection!")
	End Function
End Class
