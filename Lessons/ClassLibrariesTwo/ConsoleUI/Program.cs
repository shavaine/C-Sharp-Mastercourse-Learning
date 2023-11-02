// using FrameworkLibrary;
using CoreLibrary;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generators generators = new Generators();
            PersonModel person = new PersonModel { Prefix="Mr.", FirstName="Shavaine", LastName="Brown" };

            string message = generators.WelcomeMessage(person.Prefix, person.LastName);

            Console.WriteLine(message);
        }
    }
}
