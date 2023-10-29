

string data = "Tim,Sue,Bob,Jane";
List<string> firstNames = data.Split(',').ToList();

foreach (string name in firstNames)
{
    Console.WriteLine(name);
}
