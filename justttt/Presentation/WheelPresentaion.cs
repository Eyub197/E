using SkateboardsProject.Business.EntityesController;
using SkateboardsProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Presentation
{
    class WheelPresentaion: IPresentaion<Bearing>
    {
        private int closeOperationId = 5;
        private WheelsController wheelsController = new WheelsController();

        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(string.Format("{0," + ((60 + "WHEELS MENU".Length) / 2).ToString() + "}", "WHEELS MENU"));
            Console.WriteLine(new string('-', 60));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select an operation:");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1. List all WHEELS");
            Console.WriteLine(" 2. Add new WHEELS");
            Console.WriteLine(" 3. Update WHEELS");
            Console.WriteLine(" 4. Find WHEELS by ID");
            Console.WriteLine(" 5. Delete WHEELS by ID");
            Console.WriteLine(" 6. Exit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the number of your choice and press Enter.");
            Console.ResetColor();
        }

        public void WheelDisplay()
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
        public void Add()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "ADD WHEEL".Length) / 2).ToString() + "}", "ADD WHEEL"));
            Console.WriteLine(new string('-', 40));
            Wheel wheel = new Wheel();
            Console.WriteLine("Enter wheels size:");
            wheel.Wheels_size = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter hardness:");
            wheel.Hardness = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter wheels shape: ");
            wheel.Wheels_shape = Console.ReadLine();
            wheelsController.Add(wheel);
            Console.WriteLine("Opearation compleated sucsessfully");
        }

        public void Delete()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "DELETE WHEEL".Length) / 2).ToString() + "}", "DELETE WHEEL"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            wheelsController.Delete(id);
            Console.WriteLine("Done.");
            Console.WriteLine("Opearation compleated sucsessfully");
        }

        public void Find()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "DELETE WHEEL".Length) / 2).ToString() + "}", "DELETE WHEEL"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to find: ");
            int id = int.Parse(Console.ReadLine());
            Wheel wheel = wheelsController.Get(id);
            if (wheel != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + wheel.Id);
                Console.WriteLine("Wheels size: " + wheel.Wheels_size);
                Console.WriteLine("Hardness: " + wheel.Hardness);
                Console.WriteLine("Wheels shape: " + wheel.Wheels_shape);
                Console.WriteLine(new string('-', 40));
            }
        }

        public void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "ALL DATA".Length) / 2).ToString() + "}", "ALL DATA"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-10}", "ID", "Wheels Size", "Hardness", "Wheels Shape");
            Console.WriteLine(new string('-', 60));
            var wheels = wheelsController.GetAll();
            foreach (var item in wheels)
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-10}", item.Id, item.Wheels_size, item.Hardness, item.Wheels_shape);
            }
        }

        public void Update()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "UPDATE WHEEL".Length) / 2).ToString() + "}", "UPDATE WHEEL"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Wheel wheel = wheelsController.Get(id);
            if (wheel != null)
            {
                Console.WriteLine("What do you want to update?");
                Console.WriteLine("1. Wheels size");
                Console.WriteLine("2. Hardness");
                Console.WriteLine("3. Wheels shape");
                Console.WriteLine("4. ALL");
                Console.WriteLine("5. cancel");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new wheels size: ");
                        wheel.Wheels_size = decimal.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Enter new hardness: ");
                        wheel.Hardness = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter new wheels shape: ");
                        wheel.Wheels_shape = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter new wheels size: ");
                        wheel.Wheels_size = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new hardness: ");
                        wheel.Hardness = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new wheels shape: ");
                        wheel.Wheels_shape = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Update canceled.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                wheelsController.Update(wheel);
                Console.WriteLine("Operation completed successfully");
            }
            else
            {
                Console.WriteLine("Wheel not found!");
            }
        }
    }
}
