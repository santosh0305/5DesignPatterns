using System;

namespace FactoryPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Actions.Warming, 22.5)
                .Operate();

            Console.ReadLine();
        }
    }
}
