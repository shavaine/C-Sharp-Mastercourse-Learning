using System;
using System.Collections.Generic;
using System.Text;

namespace InstantiatedClassDemo
{
    public static class ProcessPerson
    {
        public static void GreetPerson(PersonModel person)
        {
            Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            person.HadBeenGreeted = true;
        }
    }
}
