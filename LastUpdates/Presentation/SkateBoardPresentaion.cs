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
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Chose opearation");
            Console.WriteLine("1. List all skateboards");
            Console.WriteLine("2. Add new skateboard");
            Console.WriteLine("3. Update skateboards");
            Console.WriteLine("4. Find skateboard by ID");
            Console.WriteLine("5. Delete skateboard by ID");
            Console.WriteLine("6. Exit");
        }

        public void ListAll()
        {
            using (var context = new SkateboardsContext())
            {
                var skateboards = context.Skateboards
                    .Include(s => s.Decks)
                    .Include(s => s.Wheels)
                    .Include(s => s.Bearings)
                    .Include(s => s.Brands)
                    .ToList();

                foreach (var skateboard in skateboards)
                {
                    Console.WriteLine($"Skateboard ID: {skateboard.Id}");
                    Console.WriteLine($"Price: {skateboard.Price:C}");

                    Console.Write("Decks: ");
                    foreach (var deck in skateboard.Decks)
                    {
                        Console.Write($"{deck.Id}), ");
                    }
                    Console.WriteLine();

                    Console.Write("Wheels: ");
                    foreach (var wheel in skateboard.Wheels)
                    {
                        Console.Write($"{wheel.Id}  ");
                    }
                    Console.WriteLine();

                    Console.Write("Bearings: ");
                    foreach (var bearing in skateboard.Bearings)
                    {
                        Console.Write($"{bearing.Id}, ");
                    }
                    Console.WriteLine();

                    Console.Write("Brands: ");
                    foreach (var brand in skateboard.Brands)
                    {
                        Console.Write($"{brand.Id},");
                    }
                    Console.WriteLine();

                    Console.WriteLine($"Hardware: {skateboard.Hardware}");
                    Console.WriteLine($"Date of Production: {skateboard.Date_of_production.ToShortDateString()}");
                    Console.WriteLine();
                }
            }
        }

        public void Delete()
        {
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
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Skateboard skateboard = skateBoaradController.Get(id);
            if (skateboard != null)
            {
                Console.WriteLine("Which attribute(s) would you like to update?");
                Console.WriteLine("1. Price");
                Console.WriteLine("2. Hardware");
                Console.WriteLine("3. Date of production");
                Console.WriteLine("4. Cancel");
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
