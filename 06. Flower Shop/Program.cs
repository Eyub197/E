using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());   
            int zumbuli = int.Parse(Console.ReadLine());    
            int rozi = int.Parse(Console.ReadLine());   
            int kaktusi = int.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());

            double priceOfMagnolii = magnolii * 3.25;
            double priceOfZumbuli = zumbuli* 4;
            double priceOfRozi = rozi * 3.5;
            double priceOfKaktusi = kaktusi * 8;
            double allPrice = priceOfMagnolii + priceOfKaktusi + priceOfRozi + priceOfZumbuli;
            double priceWithDds = allPrice - (allPrice * 0.05);

            if (priceWithDds >= priceOfGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(priceWithDds - priceOfGift )} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceOfGift - priceWithDds)} leva.");    
            }
        }
    }
}
