
Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

Console.Write("What is your last name: ");
string? lastName = Console.ReadLine();

if (firstName.ToLower() == "shavaine" && lastName.ToLower() == "brown")
{
    Console.WriteLine("Hello Mr. Brown");

}
else if (firstName.ToLower() == "shavaine")
{
    Console.WriteLine("Nice first name");

}
else
{
    Console.WriteLine($"Hello {firstName} {lastName}.");
}