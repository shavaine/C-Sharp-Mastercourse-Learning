using AccessModifiersLibrary;

namespace Accessmodifiers

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDataAccess data = new ModifiedDataAccess();
            data.GetUnsecureConnectionInfo();

            // formerLastName = "test";
        }
    }
}
