using System;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            int quntityFuel = int.Parse(Console.ReadLine());
            string clubCart = Console.ReadLine();
            double priceOfFuel = 0;
            double finalPrice = 0;

            switch (fuelType)
            {
                case "Gas":
                    priceOfFuel = (quntityFuel * 0.93);
                    if (clubCart == "Yes")
                    {
                        priceOfFuel = 0;
                        priceOfFuel = (quntityFuel * 0.85);
                    }
                    break;
                case "Gasoline":
                    priceOfFuel = (quntityFuel * 2.22);
                    if (clubCart == "Yes")
                    {
                        priceOfFuel = 0;
                        priceOfFuel = (quntityFuel * 2.04);
                    }
                    break;
                case "Diesel":
                    priceOfFuel = (quntityFuel * 2.33);
                    if (clubCart == "Yes")
                    {
                        priceOfFuel = 0;
                        priceOfFuel = (quntityFuel * 2.21);
                    }
                    break;
            }

            if (quntityFuel >= 20 && quntityFuel <= 25)
            {
                finalPrice = priceOfFuel - (priceOfFuel * 0.08);
            }
            else if (quntityFuel > 25)
            {
                finalPrice = priceOfFuel - (priceOfFuel * 0.10);
            }
            else
            {
              finalPrice = priceOfFuel;
            }
            Console.WriteLine($"{finalPrice:F2} lv.");
        }
    }
}
