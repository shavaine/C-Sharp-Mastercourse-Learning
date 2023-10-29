using AccessModifiersLibrary;
using System;

namespace Accessmodifiers

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.SavePerson();
        }
    }
}
