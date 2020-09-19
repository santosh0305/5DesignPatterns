using StrategyPattern.Models;
using System.Collections.Generic;

namespace StrategyPattern.Interface
{
	public interface IStrategyContext
	{
		double StrategyLogicCheck(IEnumerable<DeveloperReport> reports);
	}
}
