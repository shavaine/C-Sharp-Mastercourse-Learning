using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMethods
{
    public static class Messages
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the application.");
        }

        public static string GetUsername() {

            Console.Write("What is your username: ");
            string username = Console.ReadLine();
            return username;

        }

        public static void GreetUser(string username)
        {
            Console.WriteLine($"Hello {username}");
        }
    }
}
