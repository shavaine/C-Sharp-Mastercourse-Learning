DateTime today = DateTime.Now;


DateOnly birthday = DateOnly.Parse("6/11/1995");

DateTime TestDate = DateTime.Parse("2023-10-11 3:00");

Console.WriteLine(birthday.ToString("MMMM dd, yy"));

Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");
Console.WriteLine($"Test Date: {TestDate}");

// .Parse to convert a String to a datetime object

// .ToString to convert a DateTime Object to a String