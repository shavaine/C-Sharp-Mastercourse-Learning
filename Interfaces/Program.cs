using System.Collections.Generic;

namespace Interfaces
{
    // Interface is a contract
    // Classes implement interfaces
    class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredGameController battery = new BatteryPoweredGameController();
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

            controllers.Add(gameController);
            controllers.Add(keyboard);
            controllers.Add(battery);

            foreach (IComputerController controller in controllers)
            {
                if(controller is GameController gc)
                {
                    
                }

                if(controller is IBatteryPowered powered)
                {
                    controller.
                }
            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();

            powereds.Add(battery);
            powereds.Add(batteryKeyboard);
        }
    }
}
