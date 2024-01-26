using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmLoze = int.Parse(Console.ReadLine());
            double grapeForKM = double.Parse(Console.ReadLine());
            double nededVIneLt = int.Parse(Console.ReadLine());
            double caoutOfWorkers = int.Parse(Console.ReadLine());

            double allgrape = kmLoze * grapeForKM;
            double vine = (0.40 * allgrape) / 2.5;
            double VineLeft = vine - nededVIneLt;

            if (vine >= nededVIneLt)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Ceiling(vine)} liters.");
                Console.WriteLine($"{Math.Floor(VineLeft)} liters left -> {Math.Ceiling(VineLeft / caoutOfWorkers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(nededVIneLt - vine)} liters wine needed.");
            }
        }
    }
}
