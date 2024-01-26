using System;
using System.IO;
using System.Linq.Expressions;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottels = int.Parse(Console.ReadLine());
            double preparat = bottels * 750;
            string input;
            int caounter = 0;
            double caountOfPlates = 0;
            double caountOfPods = 0; ;
            double neededPreparat = 0;
            int caountOfPlatsOrpots = 0;
            
           

            while ((input = Console.ReadLine()) != "End")
            {
                 caountOfPlatsOrpots = int.Parse(input);

                if (caounter == 2)
                {
                    double podsNeeds = caountOfPlatsOrpots * 15;
                    caounter = 0;
                    neededPreparat = preparat - (preparat - podsNeeds);
                    preparat = preparat - neededPreparat;
                    caountOfPods += caountOfPlatsOrpots;
                }
                else
                {
                    double plateNeeds = caountOfPlatsOrpots * 5;
                    neededPreparat = preparat - (preparat - plateNeeds);
                    preparat = preparat - neededPreparat;
                    caounter++;
                    caountOfPlates += caountOfPlatsOrpots;
                }
                 

                if (preparat < 0)
                {
                    break;
                }
            }

            if (input == "End")
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{caountOfPlates} dishes and {caountOfPods} pots were washed.");
                Console.WriteLine($"Leftover detergent {preparat} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(preparat)} ml. more necessary!");
            }

        }
    }
}
