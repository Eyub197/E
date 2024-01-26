using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double expectedSum = double.Parse(Console.ReadLine());
            string input;
            double transaction;
            int transactionCaount = 0;
            double moneyWithCard = 0;
            double moneyWithCash = 0;
            double totalSum = 0;
            double cardPayers = 0;
            double cashPayers = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                if (totalSum >= expectedSum)
                {
                    break;
                }

                transaction = double.Parse(input);
                transactionCaount++;

                if (transactionCaount % 2 == 0 )
                {
                   
                    
                    if (transaction > 100 || transaction >= 10)
                    {
                        cardPayers++;
                        moneyWithCard += transaction;
                        totalSum += transaction;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");   
                    }
                }
                else 
                {
                    if (transaction <= 100)
                    {
                        cashPayers++;
                        moneyWithCash += transaction;
                        totalSum += transaction;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
            }

            if (totalSum >= expectedSum)
            {
                Console.WriteLine($"Average CS: {moneyWithCash / cashPayers:f2}");
                Console.WriteLine($"Average CC: {moneyWithCard / cardPayers:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }

        }
    }
 }
    

