using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLIINy
{
    public class UserDialog
    {
        MenuCatalog _menuCatalog;
        public UserDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }

        Pizza GetNewPizza()
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("| Opretter Pizza       |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.Write("Indtast navn: ");
            pizzaItem.Name = Console.ReadLine();

            string input = "";
            Console.Write("Indtast pris: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.Price = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Indtast pizza nummer: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.Number = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            return pizzaItem;
        }
        int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| PIZZAMENU        |");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Muligheder:");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Indtast mulighed#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
        public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "0. Afslut program",
                "1. Opret ny pizza",
                "2. Print menuen",
                "3. Muligheder"
            };

            while (proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("Afslutter..");
                        break;
                    case 1:
                        try
                        {
                            Pizza pizza = GetNewPizza();
                            _menuCatalog.Create(pizza);
                            Console.WriteLine($"Du har oprettet {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"Ingen pizza er oprettet");
                        }
                        Console.Write("Klik på en knap for at gå videre");
                        Console.ReadKey();
                        break;
                    case 2:
                        _menuCatalog.PrintMenu();
                        Console.Write("Klik på en knap for at gå videre");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine($"Du har valgt: {mainMenulist[MenuChoice]}");
                        Console.Write("Klik på en knap for at gå videre");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Klik på en knap for at gå videre");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
    
