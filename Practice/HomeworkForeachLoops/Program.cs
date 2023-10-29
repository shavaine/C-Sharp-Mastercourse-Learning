/* Ask the user for their first name. Continue asking for first names until there are no more. Then
 * loop through each name using foreach and tell each person hello on the Console */


bool running = true;
string? optionAnswer;
List<string> firstNames = new();

do
{
    Console.Write("Please add a first name to the list: ");
    string? name = Console.ReadLine();
    if (name != "" && name != null )
    {
        firstNames.Add(name);
    } else
    {
        Console.WriteLine("First name can not be empty");
    }
    

    do
    {
        Console.Write("Would you like to add more names? ('yes' or 'no' to exit): ");
        optionAnswer = Console.ReadLine();
        if (optionAnswer == "yes")
        {
            break;

        } else if (optionAnswer == "no")
        {
            running = false;
        } else
        {
            Console.WriteLine("Invalid option, please type 'yes' or 'no'");
        }

    } while (optionAnswer != "yes" && optionAnswer != "no");

} while (running == true);

foreach (var name in firstNames)
{
    Console.WriteLine($"Hello {name}");
}

Console.WriteLine("Thanks for adding the names");