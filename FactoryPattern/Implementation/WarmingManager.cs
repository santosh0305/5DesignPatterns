using System;

namespace FactoryMethod
{
    #region Concrete Class 2
    // this is Concrete Class 2
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
