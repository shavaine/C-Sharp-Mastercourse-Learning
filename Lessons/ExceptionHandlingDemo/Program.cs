using ExceptionHandlingDemo;

try
{
	ErrorMethods.BadCall();
}
catch (Exception ex)
{

    Console.WriteLine("There was an exception thrown in our app");
    Console.WriteLine(ex.Message);
}
Console.ReadLine();