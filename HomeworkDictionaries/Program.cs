/*Create a Dictionary list of employee ID's and the name that goes with the ID. Fill in a few records.
Then ask the user for their ID and return their name*/

Dictionary<int, string> employees = new Dictionary<int, string>();
bool running = true;
string optionAnswer;

employees.Add(1001, "John");
employees.Add(1002, "Bill");
employees.Add(1003, "Jackson");
employees.Add(1004, "Cathy");


do
{
    Console.Write("Hello User. Please type employee number to get corresponding employee (1001..., 1004): ");
    bool validEmployeeNumber = int.TryParse(Console.ReadLine(), out int employeeNumber);

    if (validEmployeeNumber && employees.ContainsKey(employeeNumber))
    {
        Console.WriteLine($"The employee you searched is {employees[employeeNumber]}");
    }
    else if (validEmployeeNumber == false)
    {
        Console.WriteLine("Invalid employee number, please try again");

    }
    else if (employees.ContainsKey(employeeNumber) == false)
    {
        Console.WriteLine("Employee number searched does not exist. Please try again");

    }


    do
    {
        Console.Write("Would you like to search another employee? (Type yes to continue, no to exit): ");
        optionAnswer = Console.ReadLine();
        if (optionAnswer == "yes")
        {
            break;
        }
        else if (optionAnswer == "no")
        {
            running = false;
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }

    while (optionAnswer != "yes" && optionAnswer != "no");


}
while (running == true);

Console.WriteLine("Thanks for using the program.");