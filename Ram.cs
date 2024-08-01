namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you! Rrrrummbbbbllle");

        }
    }
}