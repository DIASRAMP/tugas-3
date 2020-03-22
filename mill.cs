using System;
namespace LatClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            taxi.driverName     = "DIASRAMP";
            taxi.onDuty         = false;
            taxi.NumPassenger   = 69;
          
            taxi.TaxiInfo();
            Console.WriteLine("\n");
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
            Console.ReadKey();
        }
    }
}