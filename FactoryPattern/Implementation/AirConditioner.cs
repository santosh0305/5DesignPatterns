using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public class AirConditioner
    {
        private readonly Dictionary<Factories, AirConditionerFactory> factories = new Dictionary<Factories, AirConditionerFactory>();
        // Dynamically get all factories based on 'FactoryPattern' factory text
        private AirConditioner()
        {
            var allFactoriesInSystem = Enum.GetValues(typeof(Factories));

            foreach (Factories factory in allFactoriesInSystem)
            {
                var specificFactory = Enum.GetName(typeof(Factories), factory);
                var factoryType = Type.GetType("FactoryPattern." + specificFactory + "Factory");
                var currentFactory = (AirConditionerFactory) Activator.CreateInstance(factoryType);
                factories.Add(factory, currentFactory);
            }
        }
        public static AirConditioner InitializeFactories()
        {
            return new AirConditioner();
        }
        public IAirConditioner ExecuteCreation(Factories factory, double temperature)
        {
            return factories[factory].Create(temperature);
        }
    }

    public enum Factories
    {
        Cooling,
        Warming
    }
}
