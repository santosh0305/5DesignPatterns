using System;

namespace FactoryMethod
{
    #region FactoryImplementation2
    // Implement Factory 2 functionality i.e. methods
    #endregion
    public class WarmingManager : IAirConditioner
    {
        private readonly double _temperature;

        public WarmingManager(double temperature)
        {
            _temperature = temperature;
        }

        public void Operate()
        {
            Console.WriteLine("WARMING FACTORY.......");
            Console.WriteLine($"Warming : The room temperature is {_temperature} degrees.");
        }
    }
}
