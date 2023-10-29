using System;

namespace MethodOveriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            { FirstName = "Shavaine", LastName = "Brown", Email = "Shavaine@msn.com" };

            Console.WriteLine(person);

        }
    }
}
