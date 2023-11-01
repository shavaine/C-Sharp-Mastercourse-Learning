using ExtensionMethods.Models;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelRoomModel room = new HotelRoomModel();

            room.TurnOnAir().SetTemperature(72).OpenShades();

            room.TurnOffAir().CloseShades();

            "Hello World".PrintToConsole();

            Person Jim = new Person { FirstName = "Jim", LastName="Carry" };
            Jim.SetDefaultAge().PrintInfo();
        }
    }
}
