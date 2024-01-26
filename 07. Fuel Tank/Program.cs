using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine().ToLower();
            double fuelLeft = double.Parse(Console.ReadLine());
            if (typeOfFuel == "gas" || typeOfFuel == "gasoline" || typeOfFuel == "diesel")
            {
                if (fuelLeft >= 25)
                {
                    Console.WriteLine($"You have enough {typeOfFuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeOfFuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
