using System;

namespace _05._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double currentNumber = 0;

            for (int i = 0; i < n; i++)
            {
                currentNumber = double.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine($"{sum / n:f2}");
        }
    }
}
