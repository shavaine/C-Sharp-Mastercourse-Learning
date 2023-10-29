namespace AccessModifiersLibrary
{
    public class Manager: Employee
    {
        public string GetAllNames()
        {
            return $"{FirstName},{LastName},{formerLastName}";
        }
    }
}
