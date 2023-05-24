using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsolePratice_2
{
    public abstract class Vehicle
    {
        public string VehicleType { get; set; }

        public string EngineType { get; set; }

        public int MaxSpeed { get; set; }

        public Fuel Fuel { get; set; }

        public int NoWheels { get; set; }

        public int SeatCap { get; set; }

        public int Range { get; set; }
    }
}
