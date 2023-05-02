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
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 15) + "MENU" + new string(' ', 15));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all decks");
            Console.WriteLine("2. Add new deck");
            Console.WriteLine("3. Update deck");
            Console.WriteLine("4. Find deck by ID");
            Console.WriteLine("5. Delete deck by ID");
            Console.WriteLine("6. Exit");
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
            Console.WriteLine(new string(' ', 16) + "DECKS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var decks = deckController.GetAll();
            foreach (var item in decks)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Wood_type, item.Deck_shape, item.Deck_concave);
            }
        }

        public void Add()
        {
            Deck deck = new Deck();
            Console.WriteLine("Enter wood type:");
            deck.Wood_type = Console.ReadLine();
            Console.WriteLine("Enter deck shape:");
            deck.Deck_shape = Console.ReadLine();
            Console.WriteLine("Enter deck concave:");
            deck.Deck_concave = Console.ReadLine();
            deckController.Add(deck);
        }

        public void Update()
        {
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Deck deck = deckController.Get(id);
            if (deck != null)
            {
                Console.WriteLine("Enter wood type:");
                deck.Wood_type = Console.ReadLine();
                Console.WriteLine("Enter deck shape:");
                deck.Deck_shape = Console.ReadLine();
                Console.WriteLine("Enter deck concave:");
                deck.Deck_concave = Console.ReadLine();
                deckController.Update(deck);
            }
            else
            {
                Console.WriteLine("Deck not found!");
            }
        }

        public void Find()
        {
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
            Console.WriteLine("Enter ID to delete:");
            int id = int.Parse(Console.ReadLine());
            deckController.Delete(id);
            Console.WriteLine("Done.");
        }
    }
}

