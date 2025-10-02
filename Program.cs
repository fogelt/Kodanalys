using System;
using Kodanalys.UI;
using Kodanalys.Services;
using Kodanalys.Models;

namespace Kodanalys
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programHalted = true;
            while (programHalted)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");

                MenuChoice choice = GetMenuChoice();

                switch (choice)
                {
                    case MenuChoice.AddUser:
                        UserMethods.AddUser();
                        break;
                    case MenuChoice.ShowAllUsers:
                        UserMethods.ShowAllUsers();
                        break;
                    case MenuChoice.RemoveUser
                        UserMethods.RemoveUser();
                        break;
                    case MenuChoice.SearchForUser
                        UserMethods.SearchForUser();
                        break;
                    case MenuChoice.Invalid:
                        break;
                    default:
                        break;
                }

            }
        }
        private static MenuChoice GetMenuChoice()
        {
            string? input = Console.ReadLine();
            if (input != null && int.TryParse(input, out int choice)
                && Enum.IsDefined(typeof(MenuChoice), choice))
            {
                return (MenuChoice)choice;
            }
            return MenuChoice.Invalid;
        }
    }
}
