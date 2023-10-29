using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryItem book = new Book();

            book.ProductName = "A Tale of Two Cities";

            Car car = new Car();

        }
    }

    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car: Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;
    }
}

