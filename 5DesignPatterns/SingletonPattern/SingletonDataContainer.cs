using System;
using System.Collections.Generic;

namespace SingletonPattern
{
    public class SingletonDataContainer
    {
        private readonly Dictionary<string, int> capitals = new Dictionary<string, int>();

        private SingletonDataContainer()
        {
            Console.WriteLine("Initializing Singleton Object");

            capitals.Add("New Delhi", 16787949);
            capitals.Add("Washington, D.C.", 658893);
            capitals.Add("London", 8630100);
            capitals.Add("Beijing", 20693000);
        }
        
        private static SingletonDataContainer instance = new SingletonDataContainer();

        public static SingletonDataContainer Instance => instance;

        public int GetPopulation(string name)
        {
            return capitals[name];
        }
    }
}
