using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double days = int.Parse(Console.ReadLine());
            double food = int.Parse(Console.ReadLine());   
            double dogFood =double.Parse(Console.ReadLine());   
            double catFood = double.Parse(Console.ReadLine());  
            double turtleFood = double.Parse(Console.ReadLine()) / 1000;

            double dogNeeds = dogFood * days;
            double catNeeds = catFood * days;
            double turtleNeeds = (turtleFood * days); 
            double neededFood = dogNeeds + catNeeds + turtleNeeds;

            if (food >= neededFood)
            {
                Console.WriteLine($"{Math.Floor(food - neededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(neededFood - food )} more kilos of food are needed.");
            }

        }
    }
}
