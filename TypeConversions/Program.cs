

Console.Write("What is your age:");
string? ageText = Console.ReadLine();

/*int age = int.Parse(ageText);*/


bool isValidInt = int.TryParse(ageText, out int age); // int age is declared inline

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

Console.WriteLine(age + 15);


double testDouble = age;
decimal testDecimal = (decimal)testDouble;