using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice_2
{
    public class Helicopter:Vehicle
    {
        protected Guid BBId {  get; set; }

        public string ARN { get; set; }

        public DateTime RegDate { get; set; }  

        public string TypeRating { get; set; }

        public virtual bool RegCheck()
        {
            //Date test code
            //Date test code
            //date test code
            return false;
        }

    }
}
