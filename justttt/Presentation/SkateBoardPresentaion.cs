using Microsoft.EntityFrameworkCore;
using SkateboardsProject.Business.EntityesController;
using SkateboardsProject.Model;
using SkateboardsProject.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Presentation
{
    class SkateBoardPresentaion: IPresentaion<Skateboard>
    {

        private SkateBoaradController skateBoaradController = new SkateBoaradController();
        private int closeOperationId = 6;
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(string.Format("{0," + ((60 + "SKATEBOARDS MENU".Length) / 2).ToString() + "}", "SKATEBOARDS MENU"));
            Console.WriteLine(new string('-', 60));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select an operation:");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1. List all SKATEBOARDS");
            Console.WriteLine(" 2. Add new SKATEBOARDS");
            Console.WriteLine(" 3. Update SKATEBOARDS");
            Console.WriteLine(" 4. Find SKATEBOARDS by ID");
            Console.WriteLine(" 5. Delete SKATEBOARDS by ID");
            Console.WriteLine(" 6. Exit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the number of your choice and press Enter.");
            Console.ResetColor();
        }


        public void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "ALL DECKS".Length) / 2).ToString() + "}", "ALL DECKS"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 130));
            Console.WriteLine("|{0,5}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|{8,-20}|", "ID", "PRICE", "DECK ID", "WHEEL ID", "BEARING ID", "BRAND ID", "HARDWARE", "DATE OF PRODUCTION");
            Console.WriteLine(new string('-', 130));
            var decks = skateBoaradController.GetAll();
            foreach (var deck in decks)
            {
                Console.WriteLine("|{0,5}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|{8,-20}|",
                    deck.Id, deck.Price, deck.DeckId, deck.WheelId, deck.BearingId, deck.BrandId, deck.Hardware, deck.Date_of_production);
            }
            Console.WriteLine(new string('-', 130));
        }



        public void Delete()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "DELETE SKATEBOARD".Length) / 2).ToString() + "}", "DELETE SKATEBOARD"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID of the skateboard to delete:");
            int id = int.Parse(Console.ReadLine());

            using (var context = new SkateboardsContext()) 
            {
                var skateboard = context.Skateboards.Find(id);

                if (skateboard != null)
                {
                    context.Skateboards.Remove(skateboard);
                    context.SaveChanges();
                    Console.WriteLine("Skateboard deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"Skateboard with ID {id} not found.");
                }
            }
        }


        public void Find()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "FIND SKATEBOARD".Length) / 2).ToString() + "}", "FIND SKATEBOARD"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to find:");
            int id = int.Parse(Console.ReadLine());
            Skateboard skateboard = skateBoaradController.Get(id);
            if (skateboard != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + skateboard.Id);
                Console.WriteLine("Price: " + skateboard.Price);
                Console.WriteLine("Deck ID: " + skateboard.DeckId);
                Console.WriteLine("Wheel ID: " + skateboard.WheelId);
                Console.WriteLine("Hardware: " + skateboard.Hardware);
                Console.WriteLine("Bearing ID: " + skateboard.BearingId);
                Console.WriteLine("Brand ID: " + skateboard.BrandId);
                Console.WriteLine("Date of production: " + skateboard.Date_of_production);
                Console.WriteLine(new string('-', 40));
            }
        }


        public void Update()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "UPDATE SKATEBOARD".Length) / 2).ToString() + "}", "UPDATE SKATEBOARD"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Skateboard skateboard = skateBoaradController.Get(id);
            if (skateboard != null)
            {
                Console.WriteLine("Which attribute(s) would you like to update?");
                Console.WriteLine("1. Price");
                Console.WriteLine("2. Hardware");
                Console.WriteLine("3. Date of production");
                Console.WriteLine("4. ALL");
                Console.WriteLine("5. Cancel");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new price:");
                        skateboard.Price = decimal.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Enter new hardware:");
                        skateboard.Hardware = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter new date of production:");
                        skateboard.Date_of_production = DateTime.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Enter new price:");
                        skateboard.Price = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new hardware:");
                        skateboard.Hardware = Console.ReadLine();
                        Console.WriteLine("Enter new date of production:");
                        skateboard.Date_of_production = DateTime.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Update canceled.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                skateBoaradController.Update(skateboard);
                
                Console.WriteLine("Operation completed successfully.");
            }
            else
            {
                Console.WriteLine("Skateboard not found!");
            }
        }

        public void Add()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "ADD SKATEBOARD".Length) / 2).ToString() + "}", "ADD SKATEBOARD"));
            Console.WriteLine(new string('-', 40));
            Skateboard skateboard = new Skateboard();
            Console.WriteLine("Enter price:");
            skateboard.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter hardware:");
            skateboard.Hardware = Console.ReadLine();
            Console.WriteLine("Enter date of production (yyyy-mm-dd):");
            skateboard.Date_of_production = DateTime.Parse(Console.ReadLine());

            skateBoaradController.Add(skateboard);
            Console.WriteLine("Operation completed successfully.");
        }
    }
}
