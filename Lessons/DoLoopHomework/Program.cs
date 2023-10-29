
string exit;
string? name;

do
{
    Console.Write("What is your name: ");
    name = Console.ReadLine();
    if (name.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome Proffessor {name}.");
    } else
    {
        Console.WriteLine($"Welcome student {name}.");
    }

    Console.WriteLine("To enter another name type 'yes'. To exit type 'exit'");
    exit = Console.ReadLine();

    // To handle invalid option selection
    while (exit != "yes" && exit != "exit")
    {
        Console.WriteLine("Invalid option...");
        Console.WriteLine("To enter another name type 'yes'. To exit type 'exit'");
        exit = Console.ReadLine();
    }

} while (exit != "exit");

Console.WriteLine($"Thanks for using the program {name}");