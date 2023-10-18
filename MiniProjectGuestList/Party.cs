using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectGuestList
{
    public static class Party
    {
        public static (string name, int people) GetNameAndAmount()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            bool validPeople = false;
            int people;

            do
            {
                Console.Write("How many people are in your party: ");
                validPeople = int.TryParse(Console.ReadLine(), out people);

                if (validPeople == false)
                {
                    Console.WriteLine("The value you entered for People is invalid.");
                } else if (people < 0)
                {
                    Console.WriteLine("The amount of people can't be a negative number");
                    validPeople = false;
                }
            } while (validPeople == false);

            return (name, people);
            
        }

        public static bool CheckForGuest()
        {
            bool output = false; // return false by default
            bool validAnswer = false;
            do
            {
                Console.Write("Are there anymore guests (Type 'yes', or 'no'): ");
                string optionAnswer = Console.ReadLine();
                if (optionAnswer.ToLower() == "yes")
                {
                    validAnswer = true;
                    output = true;
                } else if (optionAnswer.ToLower() == "no") {
                    validAnswer = true;
                    output = false;
                } else if (optionAnswer != "yes" && optionAnswer != "no")
                {
                    validAnswer = false;
                }
            } while (validAnswer == false);

            return output;
        } 

        public static void PrintGuestList(Dictionary<string, int> guestList)
        {
            Console.WriteLine(); // Empty Space

            Console.WriteLine($"Guest List: ");
            foreach (string name in guestList.Keys)
            {
                Console.WriteLine($"{name} ");
            }

            Console.WriteLine(); // Empty Space

            Console.WriteLine($"Total Number of Guest: {guestList.Values.Sum()}");
        }

    }
}
