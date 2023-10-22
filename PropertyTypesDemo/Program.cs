
using PropertyTypesDemo;

PersonModel person = new PersonModel("Brown");

person.FirstName = "Shavaine";
//person.LastName = "Brown";
person.Age = 27;
person.SSN = "123-45-6789";

Console.WriteLine(person.FullName);
Console.WriteLine(person.SSN);

Console.ReadLine();