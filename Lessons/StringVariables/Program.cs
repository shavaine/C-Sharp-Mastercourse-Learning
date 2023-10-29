//If you dont know the value
string firstName = string.Empty;
string lastName = "Brown";
string filePath = string.Empty;


firstName = "Shavaine";
// Escape the escape variable \
// filePath = "C:\\Temp\\Demo";

// No escape characters
filePath = @"C:\\Temp\\Demo";

// example of both literal and escaped string
string testString = $@"The file for {firstName} is at C:\SampleFiles";


// String Interpolation
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine(filePath);


// Notes CNTL . to rename variable everywhere