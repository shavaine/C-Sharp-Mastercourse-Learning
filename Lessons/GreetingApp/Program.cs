/* 
 1. Welcome User To App
 2. Ask for First Name
 3. Greet user by name 
*/

// Welcome User To App
Console.WriteLine("Welcome to the Greeting Application");
Console.WriteLine("This application was built by Shavaine Brown");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Ask for First Name
Console.Write("What is your First Name: ");
string firstName = Console.ReadLine();

// Greet user by name
Console.WriteLine();
Console.WriteLine("Hello " +  firstName);

Console.WriteLine("Thank you for using my application.");
Console.ReadLine();