using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    public abstract class Mammal : Animal
    {
        public abstract bool IsDangerous
        {
            get;
        }
        public override string Class
        {
            get
            {
                return "Mammal";
            }
        }
    }
}
