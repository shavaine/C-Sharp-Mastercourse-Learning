using AccessModifiersLibrary;

namespace Accessmodifiers

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
{
    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }
}
