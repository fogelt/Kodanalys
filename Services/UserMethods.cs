using System.Runtime.InteropServices;

namespace Kodanalys.Services
{
    public class UserMethods
    {
        public static void AddUser(string[] userList, ref int userCount)
        {
            Console.Write("Ange namn: ");
            string User = Console.ReadLine()!;
            if (userCount < userList.Length)
            {
                userList[userCount] = User;
                userCount++;
            }
            else
            {
                Console.WriteLine("Listan är full!");
            }
        }

        public static void ShowAllUsers(string[] userList, ref int userCount)
        {
            Console.WriteLine("Användare:");
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine(userList[i]);
            }
        }

        public static void RemoveUser(string[] userList, ref int userCount)
        {
            Console.Write("Ange namn att ta bort: ");
            string userInput = Console.ReadLine()!;
            int userToRemove = -1;
            for (int i = 0; i < userCount; i++)
            {
                if (userList[i] == userInput)
                {
                    userToRemove = i;
                    break;
                }
            }

            if (userToRemove != -1)
            {
                for (int i = userToRemove; i < userCount - 1; i++)
                {
                    userList[i] = userList[i + 1];
                }
                userCount--;
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }

        }
        public static void SearchForUser(string[] userList, ref int userCount)
        {
            Console.Write("Ange namn att söka: ");
            string userInput = Console.ReadLine()!;
            bool userFoundInList = false;
            for (int i = 0; i < userCount; i++)
            {
                if (userList[i] == userInput)
                {
                    userFoundInList = true;
                    break;
                }
            }
            if (userFoundInList)
            {
                Console.WriteLine("Användaren finns i listan.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }
    }
}