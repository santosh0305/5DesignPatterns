using System.Threading;

namespace FactoryPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Initialize all factories in system
            var factories = AirConditioner.InitializeFactories();

            factories.ExecuteCreation(Factories.Warming, 30).Operate();

            Thread.Sleep(3000);

            factories.ExecuteCreation(Factories.Cooling, 15.5).Operate();

            Thread.Sleep(6000);
        }
    }
}
