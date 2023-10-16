

List<string> firstNames = new List<string>();

firstNames.Add("Tim");
firstNames.Add("John");
firstNames.Add("Bob");
firstNames.Add("Jane");
firstNames.Add("Cathy");

// .Count is equivalent to .Length

Console.WriteLine(firstNames.Count - 1);

// List<T> - generic (you can choose the type you pass in)

string data = "Corey,Smith,Jones";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");