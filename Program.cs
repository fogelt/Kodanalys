using Kodanalys.UI;
using Kodanalys.Services;

namespace Kodanalys
{
    class Program
    {
        readonly static string[] UserList = new string[10];
        static int UserCount = 0;
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
                        UserMethods.AddUser(UserList, ref UserCount);
                        break;
                    case MenuChoice.ShowAllUsers:
                        UserMethods.ShowAllUsers(UserList, UserCount);
                        break;
                    case MenuChoice.RemoveUser:
                        UserMethods.RemoveUser(UserList, ref UserCount);
                        break;
                    case MenuChoice.SearchForUser:
                        UserMethods.SearchForUser(UserList, UserCount);
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
