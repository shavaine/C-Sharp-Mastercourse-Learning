

/*string[] firstNames = new string[5];

firstNames[0] = "Shavaine";
firstNames[1] = "Sue";
firstNames[2] = "Bob";

Console.WriteLine($"The fistName in position 0 is {firstNames[0]}");*/

// single quote identifies a char
// double quotes identifies a string

string data = "Tim,Sue,Bob,Jane,Frank";
string[] firstNames = data.Split(',');

Console.WriteLine(firstNames[1]);

Console.WriteLine(firstNames.Length);

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };