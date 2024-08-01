namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
           CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
             Console.WriteLine($"The {MainColor} Tesla blazes by you! Yeeeeeeoooww");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a right turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} tesla silently stops.");
            Console.WriteLine();

        }

    }
}