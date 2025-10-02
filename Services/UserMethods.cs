namespace Kodanalys.Services
{
    public class UserMethods
    {
        public static void AddUser(string[] userList, ref int userCount)
        {
            Console.Write("Ange namn: ");
            string user = Console.ReadLine()!;
            if (userCount < userList.Length)
            {
                userList[userCount] = user;
                userCount++;
                Console.WriteLine($"Lade till ny användare: {user}");
            }
            else
            {
                Console.WriteLine("Listan är full!");
            }
            WaitForKeyPress();
        }

        public static void ShowAllUsers(string[] userList, int userCount)
        {
            Console.WriteLine("Användare:");
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine(userList[i]);
            }
            WaitForKeyPress();
        }

        public static void RemoveUser(string[] userList, ref int userCount)
        {
            Console.Write("Ange namn att ta bort: ");
            string userInput = Console.ReadLine()!;
            int index = FindUserIndex(userList, userCount, userInput);

            if (index != -1)
            {
                string removedUser = userList[index];
                for (int i = index; i < userCount - 1; i++)
                {
                    userList[i] = userList[i + 1];
                }
                userCount--;
                Console.WriteLine($"Tog bort {removedUser} från användarlistan.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
            WaitForKeyPress();
        }

        public static void SearchForUser(string[] userList, int userCount)
        {
            Console.Write("Ange namn att söka: ");
            string userInput = Console.ReadLine()!;
            int index = FindUserIndex(userList, userCount, userInput);

            if (index != -1)
                Console.WriteLine("Användaren finns i listan.");
            else
                Console.WriteLine("Användaren hittades inte.");

            WaitForKeyPress();
        }

        private static int FindUserIndex(string[] userList, int userCount, string userInput)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (userList[i] == userInput)
                    return i;
            }
            return -1;
        }

        private static void WaitForKeyPress()
        {
            Console.WriteLine("\n-----------\nTryck valfri tangent\n-----------");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
