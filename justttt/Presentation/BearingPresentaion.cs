using SkateboardsProject.Business.EntityesController;
using SkateboardsProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Presentation
{
   public class BearingPresentaion :IPresentaion<Bearing>
   {
        private BearingController bearingController = new BearingController();
        private int closeOperationId = 6;
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(string.Format("{0," + ((60 + "BEARING MENU".Length) / 2).ToString() + "}", "BEARING MENU"));
            Console.WriteLine(new string('-', 60));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select an operation:");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1. List all bearings");
            Console.WriteLine(" 2. Add new bearing");
            Console.WriteLine(" 3. Update bearing");
            Console.WriteLine(" 4. Find bearing by ID");
            Console.WriteLine(" 5. Delete bearing by ID");
            Console.WriteLine(" 6. Exit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the number of your choice and press Enter.");
            Console.ResetColor();
        }


        public void BearingDisplay()
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
            Console.WriteLine(string.Format("{0," + ((40 + "ADD BEARING".Length) / 2).ToString() + "}", "ADD BEARING"));
            Console.WriteLine(new string('-', 40));
            Bearing bearing = new Bearing();
            Console.WriteLine("Enter name:");
            bearing.Name = Console.ReadLine();
            Console.WriteLine("Enter Abec raiting:");
            bearing.Abec_ratiang = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bearing material:");
            bearing.Bearing_material = Console.ReadLine();
            bearingController.Add(bearing);
            Console.WriteLine("Opearation compleated sucsessfully");
        }

        public void Delete()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "DELETE BEARING".Length) / 2).ToString() + "}", "DELETE BEARING"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to delete:");
            int id = int.Parse(Console.ReadLine());
            bearingController.Delete(id);
            Console.WriteLine("Done.");
        }

        public void Find()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "FIND BEARING".Length) / 2).ToString() + "}", "FIND BEARING"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to find:");
            int id = int.Parse(Console.ReadLine());
            Bearing bearing = bearingController.Get(id);
            if (bearing != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + bearing.Id);
                Console.WriteLine("Name: " + bearing.Name);
                Console.WriteLine("Abec raiting: " + bearing.Abec_ratiang);
                Console.WriteLine("Material: " + bearing.Bearing_material);
                Console.WriteLine(new string('-', 40));
            }
        }

        public void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "ALL DATA".Length) / 2).ToString() + "}", "ALL DATA"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("|{0,5}|{1,-20}|{2,-15}|{3,-25}|", "ID", "NAME", "ABEC RATING", "BEARING MATERIAL");
            Console.WriteLine(new string('-', 70));
            var bearings = bearingController.GetAll();
            foreach (var item in bearings)
            {
                Console.WriteLine("|{0,5}|{1,-20}|{2,-15}|{3,-25}|", item.Id, item.Name, item.Abec_ratiang, item.Bearing_material);
            }
            Console.WriteLine(new string('-', 70));
        }

        public void Update()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "UPDATE BEARING".Length) / 2).ToString() + "}", "UPDATE BEARING"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Bearing bearing = bearingController.Get(id);
            if (bearing != null)
            {
                Console.WriteLine("Which attribute(s) would you like to update?");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Abec rating");
                Console.WriteLine("3. Bearing material");
                Console.WriteLine("4. ALL");
                Console.WriteLine("5. Cancel");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new name:");
                        bearing.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter new Abec rating:");
                        bearing.Abec_ratiang = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter new bearing material:");
                        bearing.Bearing_material = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter new name:");
                        bearing.Name = Console.ReadLine();
                        Console.WriteLine("Enter new Abec rating:");
                        bearing.Abec_ratiang = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new bearing material:");
                        bearing.Bearing_material = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Update canceled.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;

                }

                bearingController.Update(bearing);
                Console.WriteLine("Operation completed successfully.");
            }
            else
            {
                Console.WriteLine("Bearing not found!");
            }
        }
    }
}

