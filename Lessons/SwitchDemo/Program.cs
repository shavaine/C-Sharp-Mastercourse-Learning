


/*string firstName = "Tim";
int age = 43;

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("Your a child");
        break;
    default:
        Console.WriteLine("Age was not in an expected range");
        break;
}*/

/*switch (firstName.ToLower())
{
    // case "sue":
    case "tim" or "sue":
        Console.WriteLine("Hello Professor");
        break;
    case "tom":
        Console.WriteLine("Hello Tom");
        break;
    default:
        Console.WriteLine("I don't know you");
        break;
}*/

// Homework

Console.Write("What is your name? ");
string? name = Console.ReadLine();

if (name.ToLower() == "tim" || name.ToLower() == "timothy")
{
    Console.WriteLine("Welcome Professor");
} else
{
    Console.WriteLine("Welcome Student");
}