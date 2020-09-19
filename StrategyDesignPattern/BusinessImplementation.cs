using StrategyPattern.Interface;
using StrategyPattern.Models;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
	#region Strategies
	// these are actually conditions like if,else and if conditions
	#endregion
	public class Strategy1 : IStrategyContext
	{
		public double StrategyLogicCheck(IEnumerable<DeveloperReport> reports)
		{
			return reports
					.Where(r => r.Level == "Junior")
					.Select(r => r.CalculateSalary())
					.Sum();
		}
	}

	public class Strategy2 : IStrategyContext
	{
		public double StrategyLogicCheck(IEnumerable<DeveloperReport> reports)
		{
			return reports
				.Where(r => r.Level == "Senior")
				.Select(r => r.CalculateSalary() * 1.2)
				.Sum();
		}
	}

	public class Strategy3 : IStrategyContext
	{
		public double StrategyLogicCheck(IEnumerable<DeveloperReport> reports)
		{
			return reports
				.Where(r => r.Level == "SuperSenior")
				.Select(r => r.CalculateSalary() * 4.2)
				.Sum();
		}
	}
}
