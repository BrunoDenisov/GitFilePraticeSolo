using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice_2
{
    public class Fuel
    {
        public string FuelType { get; set; }

        public int AvgFuelConsuption { get; set; }

        public virtual double AvgMoneySpent()
        {
            double petrolPrice = 1.22;
            double diselPrice = 1.45;
            double kerosinePrice = 2.31;
            if (FuelType == "Disel")
            {
                return (diselPrice * AvgFuelConsuption);
            }
            else if (FuelType =="petrol")
            {
                return (petrolPrice * AvgFuelConsuption);
            }
            else if(FuelType =="Kerosine")
            {
                return (kerosinePrice * AvgFuelConsuption);
            }
            else
            {
                return 0;
            }
        }
    }
}
