using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDataContainer.Instance;
            var db2 = SingletonDataContainer.Instance;
            var db3 = SingletonDataContainer.Instance;

            Thread.Sleep(3000);

            var newDelhi = db.GetPopulation("New Delhi");
            System.Console.WriteLine(newDelhi);

            var wachingtonDc = db2.GetPopulation("Washington, D.C.");
            System.Console.WriteLine(wachingtonDc);

            Thread.Sleep(3000);
        }
    }
}
