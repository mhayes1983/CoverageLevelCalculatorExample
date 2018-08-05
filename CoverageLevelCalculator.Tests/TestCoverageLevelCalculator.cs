using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CoverageLevelCalculator;

namespace CoverageLevelCalculator.Tests
{
	[TestClass]
	//[DeploymentItem("CoverageLevelCalculator.Tests\\Data\\Rates.xml", "Data")]
	//[DeploymentItem("Data\\", "Data")]
	public class TestCoverageLevelCalculator
	{
		[TestMethod]
		public void CalculatePremiumForEmployeeOnlyWeekly()
		{
			string fileName = "Data\\Rates.xml";
			IQuotingModule quotingModule = new QuotingModule(fileName);
			decimal dcmPremium = quotingModule.CalculatePremiumForCoverageLevelDeductionFrequency(1, 52);

			Assert.IsTrue(dcmPremium == .87m);
		}

		[TestMethod]
		public void CalculatePremiumForEmployeePlusChildrenWeekly()
		{
			string fileName = "Data\\Rates.xml";
			IQuotingModule quotingModule = new QuotingModule(fileName);
			decimal dcmPremium = quotingModule.CalculatePremiumForCoverageLevelDeductionFrequency(2, 52);

			Assert.IsTrue(dcmPremium == .98m);
		}

		[TestMethod]
		public void CalculatePremiumForEmployeePlusSpouseWeekly()
		{
			string fileName = "Data\\Rates.xml";
			IQuotingModule quotingModule = new QuotingModule(fileName);
			decimal dcmPremium = quotingModule.CalculatePremiumForCoverageLevelDeductionFrequency(3, 52);

			Assert.IsTrue(dcmPremium == 1.10m);
		}

		[TestMethod]
		public void CalculatePremiumForFamilyWeekly()
		{
			string fileName = "Data\\Rates.xml";
			IQuotingModule quotingModule = new QuotingModule(fileName);
			decimal dcmPremium = quotingModule.CalculatePremiumForCoverageLevelDeductionFrequency(4, 52);

			Assert.IsTrue(dcmPremium == 1.50m);
		}

		[TestMethod]
		public void CalculatePremiumForEmployeeOnlyBiWeekly()
		{
			string fileName = "Data\\Rates.xml";
			IQuotingModule quotingModule = new QuotingModule(fileName);
			decimal dcmPremium = quotingModule.CalculatePremiumForCoverageLevelDeductionFrequency(1, 26);

			Assert.IsTrue(dcmPremium == 1.73m);
		}

		[TestMethod]
		public void CalculatePremiumForEmployeePlusChildrenBiWeekly()
		{
			string fileName = "Data\\Rates.xml";
			IQuotingModule quotingModule = new QuotingModule(fileName);
			decimal dcmPremium = quotingModule.CalculatePremiumForCoverageLevelDeductionFrequency(2, 26);

			Assert.IsTrue(dcmPremium == 1.96m);
		}

		[TestMethod]
		public void CalculatePremiumForEmployeePlusSpouseBiWeekly()
		{
			string fileName = "Data\\Rates.xml";
			IQuotingModule quotingModule = new QuotingModule(fileName);
			decimal dcmPremium = quotingModule.CalculatePremiumForCoverageLevelDeductionFrequency(3, 26);

			Assert.IsTrue(dcmPremium == 2.19m);
		}

		[TestMethod]
		public void CalculatePremiumForFamilyBiWeekly()
		{
			string fileName = "Data\\Rates.xml";
			IQuotingModule quotingModule = new QuotingModule(fileName);
			decimal dcmPremium = quotingModule.CalculatePremiumForCoverageLevelDeductionFrequency(4, 26);

			Assert.IsTrue(dcmPremium == 3m);
		}
	}
}
