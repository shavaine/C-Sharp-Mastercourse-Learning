namespace Interfaces
{
    public class BatteryPoweredGameController: GameController, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }
}
