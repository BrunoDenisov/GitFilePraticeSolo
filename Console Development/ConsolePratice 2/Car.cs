using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice_2
{
    public class Car:Vehicle
    {
        protected Guid VIN { get; set; }

        public string RegistrationNum { get; set; }

        public DateTime RegDate { get; set; }

        public string Color { get; set; }

       public virtual bool RegCheck()
        {
            //Date test code
            //Date test code
            //date test code
            return false;
        }
    }
}
