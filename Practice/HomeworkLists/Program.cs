List<string> students = new List<string>();
string answer;

do
{
    Console.Write("Add Student: ");
    students.Add(Console.ReadLine());

    Console.Write("Would you like to add more students? (yes to continue, no to exit): ");
    answer = Console.ReadLine();

    while (answer != "yes" && answer != "no")
    {
        Console.WriteLine("Invalid answer...");
        Console.Write("Would you like to add more students? (yes to continue, no to exit): ");
        answer = Console.ReadLine();
    }

} while (answer == "yes");

Console.WriteLine($"Thank you! Total number of students is {students.Count}");