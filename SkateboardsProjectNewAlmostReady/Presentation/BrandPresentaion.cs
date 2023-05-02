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
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all rands");
            Console.WriteLine("2. Add new brand");
            Console.WriteLine("3. Update brand");
            Console.WriteLine("4. Find brand by ID");
            Console.WriteLine("5. Delete brand by ID");
            Console.WriteLine("6. Exit");
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
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            brandController.Delete(id);
            Console.WriteLine("Done.");
        }

        /// <summary>
        /// UI for getting a single product record from the database
        /// </summary>
        public void Find()
        {
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
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Brand brand = brandController.Get(id);
            if (brand != null)
            {
                Console.WriteLine("Enter name: ");
                brand.Name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                brand.Producer = Console.ReadLine();
                Console.WriteLine("Enter producer: ");
                brand.Country = Console.ReadLine();
                brandController.Update(brand);
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
            Brand brand = new Brand();
            Console.WriteLine("Enter name:");
            brand.Name = Console.ReadLine();
            Console.WriteLine("Enter producer:");
            brand.Producer = Console.ReadLine();
            Console.WriteLine("Enter country: ");
            brand.Country = Console.ReadLine();
            brandController.Add(brand);
        }

        /// <summary>
        /// UI to list all the products.
        /// </summary>
        public void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "BRANDS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var brands = brandController.GetAll();
            foreach (var item in brands)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Name, item.Producer, item.Country);
            }
        }
    }
}
