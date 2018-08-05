Public Class CoverageLevelRateDocument
	Implements ICoverageLevelRateDocument

	Private m_ratesDocument As XDocument
	Public Sub New(ratesFilePath As String)
		m_ratesDocument = XDocument.Load(ratesFilePath)
	End Sub

	Private m_coverageLevelRates As IList(Of CoverageLevelRate)
	Private ReadOnly Property CoverageLevelRates As IList(Of CoverageLevelRate)
		Get
			If m_coverageLevelRates Is Nothing Then
				m_coverageLevelRates = (From rate In m_ratesDocument.Root.Elements Where rate.Name = "Rate" Select New CoverageLevelRate(rate)).ToList()
			End If

			Return m_coverageLevelRates
		End Get
	End Property

	Public Function GetRateForCoverageLevel(coverageLevel As Integer) As ICoverageLevelRate Implements ICoverageLevelRateDocument.GetRateForCoverageLevel
		Try
			Return CoverageLevelRates.Where(Function(r) r.ID.HasValue AndAlso r.ID.Value = coverageLevel).SingleOrDefault()
		Catch ex As Exception
			Return Nothing
		End Try
	End Function
End Class
