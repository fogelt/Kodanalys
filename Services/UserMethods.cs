using System;
using System.Collections.Generic;

namespace Kodanalys.Services
{
    public class UserMethods
    {
        public static void AddUser(List<string> users)
        {
            Console.Write("Ange namn: ");
            string user = Console.ReadLine()!;

            if (!string.IsNullOrWhiteSpace(user))
            {
                users.Add(user);
                Console.WriteLine($"Lade till ny användare: {user}");
            }
            else
            {
                Console.WriteLine("Ogiltigt namn.");
            }

            WaitForKeyPress();
        }

        public static void ShowAllUsers(List<string> users)
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Inga användare i listan.");
            }
            else
            {
                Console.WriteLine("Användare:");
                foreach (var user in users)
                {
                    Console.WriteLine(user);
                }
            }

            WaitForKeyPress();
        }

        public static void RemoveUser(List<string> users)
        {
            Console.Write("Ange namn att ta bort: ");
            string input = Console.ReadLine()!;

            if (users.Remove(input))
            {
                Console.WriteLine($"Tog bort {input} från användarlistan.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }

            WaitForKeyPress();
        }

        public static void SearchForUser(List<string> users)
        {
            Console.Write("Ange namn att söka: ");
            string input = Console.ReadLine()!;

            if (users.Contains(input))
            {
                Console.WriteLine("Användaren finns i listan.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }

            WaitForKeyPress();
        }

        private static void WaitForKeyPress()
        {
            Console.WriteLine("\n-----------\nTryck valfri tangent\n-----------");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
