using Kodanalys.UI;
using Kodanalys.Services;

namespace Kodanalys
{
    class Program
    {
        readonly static List<string> Users = new List<string>();

        static void Main(string[] args)
        {
            Console.Clear();

            while (true)
            {
                PrintMenu();
                MenuChoice choice = GetMenuChoice();
                Console.Clear();

                switch (choice)
                {
                    case MenuChoice.AddUser:
                        UserMethods.AddUser(Users);
                        break;
                    case MenuChoice.ShowAllUsers:
                        UserMethods.ShowAllUsers(Users);
                        break;
                    case MenuChoice.RemoveUser:
                        UserMethods.RemoveUser(Users);
                        break;
                    case MenuChoice.SearchForUser:
                        UserMethods.SearchForUser(Users);
                        break;
                    case MenuChoice.Exit:
                        return;
                    case MenuChoice.Invalid:
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Visa alla användare");
            Console.WriteLine("3. Ta bort användare");
            Console.WriteLine("4. Sök användare");
            Console.WriteLine("5. Avsluta");
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
