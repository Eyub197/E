using SkateboardsProject.Business;
using SkateboardsProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Presentation
{
  public  class DeckPresentaion : IPresentaion<Deck>
    {
        private int closeOperationId = 6;
        DeckController deckController = new DeckController();
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(string.Format("{0," + ((60 + "DECK MENU".Length) / 2).ToString() + "}", "DECK MENU"));
            Console.WriteLine(new string('-', 60));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select an operation:");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1. List all DECKS");
            Console.WriteLine(" 2. Add new DECKS");
            Console.WriteLine(" 3. Update DECKS");
            Console.WriteLine(" 4. Find DECKS by ID");
            Console.WriteLine(" 5. Delete DECKS by ID");
            Console.WriteLine(" 6. Exit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the number of your choice and press Enter.");
            Console.ResetColor();
        }

        public void DeckInput()
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
        public void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "ALL DATE".Length) / 2).ToString() + "}", "ALL DATA"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-10}", "ID", "Wood Type", "Deck Shape", "Deck Concave");
            Console.WriteLine(new string('-', 60));
            var decks = deckController.GetAll();
            foreach (var item in decks)
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-10}", item.Id, item.Wood_type, item.Deck_shape, item.Deck_concave);
            }
        }

        public void Add()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "ADD DECK".Length) / 2).ToString() + "}", "ADD DECK"));
            Console.WriteLine(new string('-', 40));
            Deck deck = new Deck();
            Console.WriteLine("Enter wood type:");
            deck.Wood_type = Console.ReadLine();
            Console.WriteLine("Enter deck shape:");
            deck.Deck_shape = Console.ReadLine();
            Console.WriteLine("Enter deck concave:");
            deck.Deck_concave = Console.ReadLine();
            deckController.Add(deck);
            Console.WriteLine("Opearation compleated sucsessfully");
        }

        public void Update()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "UPDATE DECK".Length) / 2).ToString() + "}", "UPDATE DECK"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Deck deck = deckController.Get(id);
            if (deck != null)
            {
                Console.WriteLine("Choose attribute to update:");
                Console.WriteLine("1. Wood type");
                Console.WriteLine("2. Deck shape");
                Console.WriteLine("3. Deck concave");
                Console.WriteLine("4. ALL");
                Console.WriteLine("5. CANCEL");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter wood type:");
                        deck.Wood_type = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter deck shape:");
                        deck.Deck_shape = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter deck concave:");
                        deck.Deck_concave = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter wood type:");
                        deck.Wood_type = Console.ReadLine();
                        Console.WriteLine("Enter deck shape:");
                        deck.Deck_shape = Console.ReadLine();
                        Console.WriteLine("Enter deck concave:");
                        deck.Deck_concave = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Update canceled.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }
                deckController.Update(deck);
                Console.WriteLine("Operation completed successfully.");
            }
            else
            {
                Console.WriteLine("Deck not found!");
            }
        }

        public void Find()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "FIND DECK".Length) / 2).ToString() + "}", "DIND DECK"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to find:");
            int id = int.Parse(Console.ReadLine());
            Deck deck = deckController.Get(id);
            if (deck != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + deck.Id);
                Console.WriteLine("Wood type: " + deck.Wood_type);
                Console.WriteLine("Deck shape: " + deck.Deck_shape);
                Console.WriteLine("Deck concave: " + deck.Deck_concave);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Deck not found!");
            }
        }

        public void Delete()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(string.Format("{0," + ((40 + "DELETE DECK".Length) / 2).ToString() + "}", "DELETE DECK"));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter ID to delete:");
            int id = int.Parse(Console.ReadLine());
            deckController.Delete(id);
            Console.WriteLine("Done.");
            Console.WriteLine("Opearation compleated sucsessfully");
        }
    }
}

