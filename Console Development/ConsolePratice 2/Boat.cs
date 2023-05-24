using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice_2
{
    internal class Boat:Vehicle
    {
        protected Guid ID {  get; set; }

        public string BRN { get; set; }

        public DateTime RegDate { get; set; }

        public string TClass { get; set; }

        public virtual bool RegCheck()
        {
            //Date test code
            //Date test code
            //date test code
            return false;
        }

    }
}
