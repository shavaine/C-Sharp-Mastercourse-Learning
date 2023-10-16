

Console.Write("What us your first name? ");
string? firstName = Console.ReadLine();

Console.Write("what is your age? ");
string? ageString = Console.ReadLine();

bool validAge = int.TryParse(ageString, out int age);

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    Console.WriteLine("Welcome Professor");
} else
{
    Console.WriteLine("Welcome Student");
}


if (validAge == false)
{
    Console.WriteLine("Age not valid. Please enter a valid age");
}
else if (validAge == true && age < 21)
{
    Console.WriteLine($"You should wait {21 - age} years to start this class");
}
else if (validAge == true && age < 21)
{
    Console.WriteLine($"Welcome to class {firstName}.");
}

//Different way

/*if (validAge == false)
{
    Console.WriteLine("Age not valid. Please enter a valid age");
    return;
}

if ((firstName.ToLower() == "bob" || firstName.ToLower() == "sue") && age > 21)
{
    Console.WriteLine($"Welcome Professor {firstName}");
} else if (age < 21)
{
    Console.WriteLine($"You should wait {21 - age} years to start this class");
} else
{
    Console.WriteLine($"Welcome to class {firstName}.");
}*/