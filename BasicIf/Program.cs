/*
bool isComplete = true;

if (isComplete)
{
    Console.WriteLine("The statement was true");
} else
{
    Console.WriteLine("The state was false");
}*/


Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "shavaine")
{
    Console.WriteLine("Hello Mr.Brown");
} else
{
    Console.WriteLine($"Hello {firstName}");
}

Console.WriteLine("End of program");
