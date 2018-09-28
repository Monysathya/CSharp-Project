using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    class Cichild : Animal
    {
        public override Conservation.Status ConservationStatus
        {
            get
            {
                return Conservation.Status.Some_Endangered;
            }
        }

        public override string Species
        {
            get
            {
                return "Cichild";
            }
        }

        public override Class.Type _Class
        {
            get
            {
                return Class.Type.Fish;
            }
        }
    }
}
