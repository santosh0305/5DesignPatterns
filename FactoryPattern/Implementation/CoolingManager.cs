using System;

namespace FactoryPattern
{
    #region Concrete Class 1
    // this is Concrete Class 1
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
            Console.WriteLine("COOLING FACTORY.......");
            Console.WriteLine($"Cooling : The room temperature is {_temperature} degrees");
        }
    }
}
