<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLCalcExample
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnCalc = New System.Windows.Forms.Button()
		Me.lblResults = New System.Windows.Forms.Label()
		Me.cmbCL = New System.Windows.Forms.ComboBox()
		Me.cmbDF = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(78, 35)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(150, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Select Coverage Level"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(78, 101)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(186, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Select Deduction Frequency"
		'
		'btnCalc
		'
		Me.btnCalc.Location = New System.Drawing.Point(270, 153)
		Me.btnCalc.Name = "btnCalc"
		Me.btnCalc.Size = New System.Drawing.Size(120, 41)
		Me.btnCalc.TabIndex = 4
		Me.btnCalc.Text = "Calculate"
		Me.btnCalc.UseVisualStyleBackColor = True
		'
		'lblResults
		'
		Me.lblResults.AutoSize = True
		Me.lblResults.Location = New System.Drawing.Point(78, 220)
		Me.lblResults.Name = "lblResults"
		Me.lblResults.Size = New System.Drawing.Size(0, 17)
		Me.lblResults.TabIndex = 5
		'
		'cmbCL
		'
		Me.cmbCL.AutoCompleteCustomSource.AddRange(New String() {"1, Employee Only", "2, Employee Plus Spouse", "3, Employee Plus Children", "4, Family"})
		Me.cmbCL.FormattingEnabled = True
		Me.cmbCL.Location = New System.Drawing.Point(270, 35)
		Me.cmbCL.Name = "cmbCL"
		Me.cmbCL.Size = New System.Drawing.Size(203, 24)
		Me.cmbCL.TabIndex = 6
		'
		'cmbDF
		'
		Me.cmbDF.FormattingEnabled = True
		Me.cmbDF.Location = New System.Drawing.Point(270, 101)
		Me.cmbDF.Name = "cmbDF"
		Me.cmbDF.Size = New System.Drawing.Size(203, 24)
		Me.cmbDF.TabIndex = 7
		'
		'CLCalcExample
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.cmbDF)
		Me.Controls.Add(Me.cmbCL)
		Me.Controls.Add(Me.lblResults)
		Me.Controls.Add(Me.btnCalc)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "CLCalcExample"
		Me.Text = "Coverage Level Calculator"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents btnCalc As Button
	Friend WithEvents lblResults As Label
	Friend WithEvents cmbCL As ComboBox
	Friend WithEvents cmbDF As ComboBox
End Class
