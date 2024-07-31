using System.Collections.ObjectModel;
using System.Drawing;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Red",
                MaximumOccupancy = 2,
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Blue",
                MaximumOccupancy = 4,
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = 1,
            };
            Ram kt456 = new Ram()
            {
                MainColor = "Black",
                MaximumOccupancy = 4,
            };

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            
            kt456.Stop();
            kt456.Drive();
            kt456.Turn();


        }
    }
}