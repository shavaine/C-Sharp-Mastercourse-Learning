using static AdvancedExceptions.ErrorMethods;


string name = "";
try
{
    DifferentMethod();
    Console.Write("What is your name: ");
    name = Console.ReadLine();
    ComplexMethod(name);
    SimpleMethod();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("You should not be calling these methods.");
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException)
{
    Console.WriteLine("You forgot to finish your code!!!");
}
catch (Exception ex) when (name.ToLower() == "tim")
{
    Console.WriteLine("You used Tim's name, didn't you?");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    /*Console.WriteLine(ex.Message);*/
}
finally
{
    Console.WriteLine("I always run");
}


Console.ReadLine();