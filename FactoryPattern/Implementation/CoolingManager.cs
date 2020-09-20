using System;

namespace FactoryMethod
{
    #region FactoryImplementation1
    // Implement Factory 1 functionality i.e. methods
    #endregion
    public class CoolingManager : IAirConditioner
    {
        private readonly double _temperature;

        public CoolingManager(double temperature)
        {
            _temperature = temperature;
        }

        public void Operate()
        {
            Console.WriteLine("Cooling Factory Invoked.......");
            Console.WriteLine($"Cooling : The room temperature is {_temperature} degrees");
        }
    }
}
