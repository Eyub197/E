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
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all bearing");
            Console.WriteLine("2. Add new bearing");
            Console.WriteLine("3. Update bearing");
            Console.WriteLine("4. Find bearing by ID");
            Console.WriteLine("5. Delete bearing by ID");
            Console.WriteLine("6. Exit");
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
            Bearing bearing = new Bearing();
            Console.WriteLine("Enter name:");
            bearing.Name = Console.ReadLine();
            Console.WriteLine("Enter Abec raiting:");
            bearing.Abec_ratiang = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bearing material:");
            bearing.Bearing_material = Console.ReadLine();
            bearingController.Add(bearing);
        }

        public void Delete()
        {
            Console.WriteLine("Enter ID to delete:");
            int id = int.Parse(Console.ReadLine());
            bearingController.Delete(id);
            Console.WriteLine("Done.");
        }

        public void Find()
        {
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
            Console.WriteLine(new string(' ', 16) + "BEARINGS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var bearings = bearingController.GetAll();
            foreach (var item in bearings)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Name, item.Abec_ratiang, item.Bearing_material);
            }
        }

        public void Update()
        {
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Bearing bearing = bearingController.Get(id);
            if (bearing != null)
            {
                Console.WriteLine("Enter name:");
                bearing.Name = Console.ReadLine();
                Console.WriteLine("Enter Abec raiting:");
                bearing.Abec_ratiang = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bearing material:");
                bearing.Bearing_material = Console.ReadLine();
                bearingController.Update(bearing);
            }
            else
            {
                Console.WriteLine("Bearing not found!");
            }
        }
    }
}
