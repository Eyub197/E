using SkateboardsProject.Business;
using SkateboardsProject.Business.EntityesController;
using SkateboardsProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Presentation
{
    class BrandPresentaion : IPresentaion<Brand>
    {
        private int closeOperationId = 6;

        private BrandController brandController = new BrandController();

        /// <summary>
        ///  Constructor
        /// </summary>


        /// <summary>
        /// Menu UI
        /// </summary>
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(string.Format("{0," + ((60 + "BRAND MENU".Length) / 2).ToString() + "}", "BRAND MENU"));
            Console.WriteLine(new string('-', 60));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select an operation:");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1. List all BRANDS");
            Console.WriteLine(" 2. Add new BRAND");
            Console.WriteLine(" 3. Update BRAND");
            Console.WriteLine(" 4. Find BRAND by ID");
            Console.WriteLine(" 5. Delete BRAND by ID");
            Console.WriteLine(" 6. Exit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the number of your choice and press Enter.");
            Console.ResetColor();
        }



        /// <summary>
        /// User Input
        /// </summary>
        public void BrandInput()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Find();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }
       
        /// <summary>
        /// US for Deletion
        /// </summary>
        public void Delete()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "DELETE BRAND".Length) / 2).ToString() + "}", "DELETE BRAND"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            brandController.Delete(id);
            Console.WriteLine("Done.");
            Console.WriteLine("Opearation compleated sucsessfully");
        }

        /// <summary>
        /// UI for getting a single product record from the database
        /// </summary>
        public void Find()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "FIND BRAND".Length) / 2).ToString() + "}", "FIND BRAND"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Brand brand = brandController.Get(id);
            if (brand != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + brand.Id);
                Console.WriteLine("Name: " + brand.Name);
                Console.WriteLine("Price: " + brand.Producer);
                Console.WriteLine("Stock: " + brand.Country);
                Console.WriteLine(new string('-', 40));
            }
        }

        /// <summary>
        /// UI dor updating a single product record in the database.
        /// </summary>
        public void Update()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "UPDATE BRAND".Length) / 2).ToString() + "}", "UPDATE BRAND"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Brand brand = brandController.Get(id);
            if (brand != null)
            {
                Console.WriteLine("Which attribute(s) would you like to update?");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Producer");
                Console.WriteLine("3. Country");
                Console.WriteLine("4. ALL");
                Console.WriteLine("5. Cancel");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new name: ");
                        brand.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter new producer: ");
                        brand.Producer = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter new country: ");
                        brand.Country = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter new name: ");
                        brand.Name = Console.ReadLine();
                        Console.WriteLine("Enter new producer: ");
                        brand.Producer = Console.ReadLine();
                        Console.WriteLine("Enter new country: ");
                        brand.Country = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Update canceled.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                brandController.Update(brand);
                Console.WriteLine("Operation completed successfully.");
            }
            else
            {
                Console.WriteLine("Brand not found!");
            }
        }

        /// <summary>
        /// UI for adding a single product record to the database.
        /// </summary>
        public void Add()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "UPDATE BRAND".Length) / 2).ToString() + "}", "UPDATE BRAND"));
            Console.WriteLine(new string('-', 40));;
            Brand brand = new Brand();
            Console.WriteLine("Enter name:");
            brand.Name = Console.ReadLine();
            Console.WriteLine("Enter producer:");
            brand.Producer = Console.ReadLine();
            Console.WriteLine("Enter country: ");
            brand.Country = Console.ReadLine();
            brandController.Add(brand);
            Console.WriteLine("Opearation compleated sucsessfully");
        }

        /// <summary>
        /// UI to list all the products.
        /// </summary>
        public void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "ALL DATA".Length) / 2).ToString() + "}", "ALL DATA"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("|{0,5}|{1,-20}|{2,-20}|{3,-20}|", "ID", "NAME", "PRODUCER", "COUNTRY");
            Console.WriteLine(new string('-', 70));
            var brands = brandController.GetAll();
            foreach (var item in brands)
            {
                Console.WriteLine("|{0,5}|{1,-20}|{2,-20}|{3,-20}|", item.Id, item.Name, item.Producer, item.Country);
            }
            Console.WriteLine(new string('-', 70));
        }
    }
}
