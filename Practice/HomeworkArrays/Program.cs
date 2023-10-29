string[] names = new string[] { "John", "Bob", "Tim" };
int answer;
bool isNumber;

do
{
    Console.WriteLine("Type 1 to return John, 2 to return Bob, 3 to return Tim");
    string answerString = Console.ReadLine();
    isNumber = int.TryParse(answerString, out answer); 

    // Checks if answerString is a number
    if (isNumber == false)
    {
        Console.WriteLine("Your option must be a number.");
    }

    // Checks if answer is 1, 2, or 3
    if (answer < 0 || answer > names.Length - 1)
    {
        Console.WriteLine("Your option is not valid.");
    }

} while ( isNumber == false || (answer < 0 || answer > names.Length - 1));


Console.WriteLine($"The name you selected is {names[answer - 1]}");
