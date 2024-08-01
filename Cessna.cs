namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you! Zzzzoooooommmm");
        }
              public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for mile and stops!");
        }
    }
    
}

