using System;
using System.Numerics;

namespace _02.SleepyCatTom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int caountOfRestDays = int.Parse(Console.ReadLine());
            int timeForPlaying = ((365 - caountOfRestDays) * 63 + (caountOfRestDays * 127));
            int diffrence = Math.Abs(timeForPlaying - 30000);

            var timeSpan = TimeSpan.FromMinutes(diffrence); //W method
            int dd = timeSpan.Days * 24;
            int hh = timeSpan.Hours + dd;
            int mm = timeSpan.Minutes;

            if (timeForPlaying > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hh} hours and {mm} minutes more for play ");


            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hh} hours and {mm} minutes less for play");
            }
            }
        }
    }

