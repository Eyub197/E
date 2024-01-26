using System;

namespace _01._Pipes_in_pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacityOfPool = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double p1Production = P1 * H;
            double p2Production = p2 * H;
            double production = p1Production + p2Production;
            double allField = (production / capacityOfPool) * 100;
            double p1Field = (p1Production / production) * 100;
            double p2Field = (p2Production / production) * 100;

            if (production <= capacityOfPool)
            {
                Console.WriteLine($"The pool is {allField:f2}% full. Pipe 1: {p1Field:f2}%. Pipe 2: {p2Field:f2}%.");
            }

            else
            {
                Console.WriteLine($"For {H} hours the pool overflows with {production - capacityOfPool} liters.");
            }


          
        }
    }
 }

    

