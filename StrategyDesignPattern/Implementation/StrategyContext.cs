using StrategyPattern.Interface;
using StrategyPattern.Models;
using System.Collections.Generic;

namespace StrategyPattern.Implementation
{
	public class StrategyContext
	{
		private IStrategyContext strategyContext;

		public StrategyContext(IStrategyContext strategyContext)    // Strategy1,Strategy2,Strategy3
        {
			this.strategyContext = strategyContext;
		}

		public void SetContext(IStrategyContext strategyContext)
		{
			this.strategyContext = strategyContext;
		}

        #region CommonMethod
        // This is common method used by all strategies
        // 'strategyContext' is instance which is created for StrategyContext by doing DI
        #endregion
        public double CommonStrategyEntry(IEnumerable<DeveloperReport> reports)
		{
			return strategyContext.StrategyLogicCheck(reports);
		}
	}
}
