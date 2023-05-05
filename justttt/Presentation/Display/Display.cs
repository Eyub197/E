using SkateboardsProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Presentation.Display
{
    public class Display
    {
        BearingPresentaion bearingPresentaion = new BearingPresentaion();
        BrandPresentaion brandPresentaion = new BrandPresentaion();
        DeckPresentaion deckPresentaion = new DeckPresentaion();
        WheelPresentaion wheelPresentaion = new WheelPresentaion();
        SkateBoardPresentaion skateBoardPresentaio = new SkateBoardPresentaion();
  

        private int closeOperationId = 6;

        public Display()
        {
           Menu();
        }

        public void ChooseMenu()
        {
            Console.WriteLine("******WELCOME TO SAKTEBOARD DATABASE MANAGMENT SYSTEM******");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(new string(' ', 25) + "SKATEBOARD MENU" + new string(' ', 25));
            Console.WriteLine(new string('-', 60));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select a table to view:");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1. Decks");
            Console.WriteLine(" 2. Bearings");
            Console.WriteLine(" 3. Brands");
            Console.WriteLine(" 4. Wheels");
            Console.WriteLine(" 5. Skateboards");
            Console.WriteLine(" 6. Exit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the number of your choice and press Enter.");
            Console.ResetColor();
        }
        public void Menu()
        {
            var operation = -1;
            do
            {
                ChooseMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        DeckDislplay();
                        break;
                    case 2:
                        BearingDisplay();
                        break;
                    case 3:
                        BrandDisplay();
                        break;
                    case 4:
                        WheelDisplay();
                        break;
                    case 5:
                        SkateboardDisplay();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        //Deck
        public void DeckDislplay()
        {
            var operation = -1;
            do
            {
                deckPresentaion.ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                      deckPresentaion.ListAll();
                        break;
                    case 2:
                       deckPresentaion.Add();
                        break;
                    case 3:
                       deckPresentaion.Update();
                        break;
                    case 4:
                        deckPresentaion.Find();
                        break;
                    case 5:
                       deckPresentaion.Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        //Bearing
        public void BearingDisplay()
        {
            var operation = -1;
            do
            {
                bearingPresentaion.ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                       bearingPresentaion.ListAll();
                        break;
                    case 2:
                        bearingPresentaion.Add();
                        break;
                    case 3:
                       bearingPresentaion.Update();
                        break;
                    case 4:
                       bearingPresentaion.Find();
                        break;
                    case 5:
                       bearingPresentaion.Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }
        //Brand
        public void BrandDisplay()
        {
            var operation = -1;
            do
            {
               brandPresentaion.ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                       brandPresentaion.ListAll();
                        break;
                    case 2:
                       brandPresentaion.Add();
                        break;
                    case 3:
                       brandPresentaion.Update();
                        break;
                    case 4:
                       brandPresentaion.Find();
                        break;
                    case 5:
                        brandPresentaion.Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }
        //Wheels
        public void WheelDisplay()
        {
            var operation = -1;
            do
            {
               wheelPresentaion.ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                       wheelPresentaion.ListAll();
                        break;
                    case 2:
                       wheelPresentaion.Add();
                        break;
                    case 3:
                       wheelPresentaion.Update();
                        break;
                    case 4:
                       wheelPresentaion.Find();
                        break;
                    case 5:
                       wheelPresentaion.Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        //Skateboard
        public void SkateboardDisplay()
        {
            var operation = -1;
            do
            {
                skateBoardPresentaio.ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        skateBoardPresentaio.ListAll();
                        break;
                    case 2:
                        skateBoardPresentaio.Add();
                        break;
                    case 3:
                        skateBoardPresentaio.Update();
                        break;
                    case 4:
                        skateBoardPresentaio.Find();
                        break;
                    case 5:
                        skateBoardPresentaio.Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }
    }
}

