Public Class CoverageLevelRate
	Implements ICoverageLevelRate

	Private m_root As XElement
	Public Sub New(root As XElement)
		m_root = root
	End Sub

	Public ReadOnly Property ID As Integer? Implements ICoverageLevelRate.ID
		Get
			Dim strValue As String = m_root.@coveragelevel
			Dim intValue As Integer
			If Not String.IsNullOrEmpty(strValue) AndAlso Integer.TryParse(strValue, intValue) Then
				Return intValue
			End If

			Return Nothing
		End Get
	End Property

	Public ReadOnly Property Rate As Decimal? Implements ICoverageLevelRate.Rate
		Get
			Dim strValue As String = m_root.Value
			Dim dcmValue As Decimal
			If Not String.IsNullOrEmpty(strValue) AndAlso Decimal.TryParse(strValue, dcmValue) Then
				Return dcmValue
			End If

			Return Nothing
		End Get
	End Property

	Public ReadOnly Property Frequency As Integer? Implements ICoverageLevelRate.Frequency
		Get
			Dim strValue As String = m_root.@freq
			Dim intValue As Integer
			If Not String.IsNullOrEmpty(strValue) AndAlso Integer.TryParse(strValue, intValue) Then
				Return intValue
			End If

			Return Nothing
		End Get
	End Property
End Class
