/* Ask the user for a comma-separted list of first names (no spaces). Split the string into a string array
 * Loop through the array and print "Hello <name> to the console for each person */

Console.WriteLine("Please enter a list of first names (seperated by comma, and no space):");
List<string> firstNames = Console.ReadLine().Split(',').ToList();

for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}");
}
