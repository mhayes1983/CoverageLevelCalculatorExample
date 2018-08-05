using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoverageLevelCalculator.Data;

namespace CoverageLevelCalculator
{
    public class QuotingModule : IQuotingModule
	{
		private string m_ratesFilePath;
		public QuotingModule(string ratesFilePath)
		{
			if (string.IsNullOrEmpty(ratesFilePath))
			{
				throw new Exception("ratesFilePath is nothing");
			}

			m_ratesFilePath = ratesFilePath;
		}

		public decimal CalculatePremiumForCoverageLevelDeductionFrequency(int coverageLevel, int deductionFrequency)
		{
			ICoverageLevelRateDocument rateDocument = new CoverageLevelRateDocument(m_ratesFilePath);
			ICoverageLevelRate rate = rateDocument.GetRateForCoverageLevel(coverageLevel);

			if (rate == null || !rate.Rate.HasValue)
			{
				throw new Exception(string.Format("Unable to find rate for Coverage Level ID {0}", coverageLevel));
			}
			if (!rate.Frequency.HasValue)
			{
				throw new Exception(string.Format("Rate frequency missing for Coverage Level ID {0}", coverageLevel));
			}

			decimal dcmAnnualRate = (rate.Rate.Value * rate.Frequency.Value);
			return Math.Round(dcmAnnualRate / deductionFrequency, 2);
		}
	}
}
