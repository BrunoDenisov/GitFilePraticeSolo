using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice_2
{
    internal class Program
    {
        public class InCar: Car { }
        public class InBoat: Boat { }
        public class InHelicopter: Helicopter { }

        BetterTittle tittle = new BetterTittle();
        static void Main(string[] args)
        {
            BetterTittle tittle = new BetterTittle();
            tittle.TWrite();
            Fuel fuel = new Fuel();
            InCar car = new InCar();
            InBoat boat = new InBoat();
            InHelicopter helicopter = new InHelicopter();
            Console.WriteLine($"Please input the type of vehicle:\n");
            string vehicleType = Console.ReadLine();
            switch (vehicleType)
            {
                case "Car":
                    car.VehicleType = vehicleType;
                    Console.WriteLine($"\nPlease input the type of engine in your car:\n");
                    car.EngineType=Console.ReadLine();
                    Console.WriteLine($"\nPlease input the max speed of your car:\n");
                    car.MaxSpeed=Convert.ToInt32( Console.ReadLine() );
                    Console.WriteLine($"\nPlease input the Number of wheels your car has:\n");
                    car.NoWheels=Convert.ToInt32( Console.ReadLine() );
                    Console.WriteLine($"\nPlease input the Seat capacity of your car:\n");
                    car.SeatCap=Convert.ToInt32( Console.ReadLine() );
                    Console.WriteLine($"\nPlease input the the range of your vehicle on a full tnak of fuel in km:\n");
                    car.Range=Convert.ToInt32( Console.ReadLine() );
                    Console.WriteLine($"\nPlease input the licence plate number:\n");
                    car.RegistrationNum=Console.ReadLine();
                    Console.WriteLine($"\nPlease input the date of regestration of the Car:\n");
                    car.RegDate=Convert.ToDateTime( Console.ReadLine() );
                    Console.WriteLine($"\nPleas input the color of your car:\n");
                    car.Color=Console.ReadLine();
                    break;

                case "Boat":
                    boat.VehicleType = vehicleType;
                    Console.WriteLine($"\nPlease input the type of engine in your boat:\n");
                    boat.EngineType = Console.ReadLine();
                    Console.WriteLine($"\nPlease input the max speed of your boat:\n");
                    boat.MaxSpeed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nPlease input the Seat capacity of your boat:\n");
                    boat.SeatCap = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nPlease input the the range of your vehicle on a full tnak of fuel in km:\n");
                    boat.Range = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nPlease input the Boat Registration Number:\n");
                    boat.BRN = Console.ReadLine();
                    Console.WriteLine($"\nPlease input the date of regestration of the boat:\n");
                    boat.RegDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine($"\nPleas input the type class of your boat:\n");
                    boat.TClass = Console.ReadLine();
                    break;

                case "Helicopter":
                    helicopter.VehicleType = vehicleType;
                    Console.WriteLine($"\nPlease input the type of engine in your helicopter:\n");
                    helicopter.EngineType = Console.ReadLine();
                    Console.WriteLine($"\nPlease input the max speed of your helicopter:\n");
                    helicopter.MaxSpeed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nPlease input the Number of wheels your helicopter has:\n");
                    helicopter.NoWheels = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nPlease input the Seat capacity of your helicopter:\n");
                    helicopter.SeatCap = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nPlease input the the range of your vehicle on a full tnak of fuel in km:\n");
                    helicopter.Range = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nPlease input the licence plate number:\n");
                    helicopter.ARN = Console.ReadLine();
                    Console.WriteLine($"\nPlease input the date of regestration of the helicopter:\n");
                    helicopter.RegDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine($"\nPleas input the type rating of your helicopter:\n");
                    helicopter.TypeRating = Console.ReadLine();
                    break;

            }
            Console.WriteLine($"\n Do you wish to calculate the money you will spend on average on you vehicle? y/n\n");
            string choice;
            choice = Console.ReadLine();
            if ( choice == "y")
            {
                Console.WriteLine($"\n Please input your average fuel consuption:\n");
                fuel.AvgFuelConsuption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\n Please input your fuel type that your vehicle is using:\n");
                fuel.FuelType = Console.ReadLine();
                fuel.AvgMoneySpent();
                Console.WriteLine($"For the averegu use of your vehicle you will spend{fuel.AvgMoneySpent()}");
                Console.ReadLine();
            }
            else 
            {
               Console.WriteLine($"No problem have a wonderfull day!");
               Console.ReadLine();
            }
           
        }
      
    }
}
