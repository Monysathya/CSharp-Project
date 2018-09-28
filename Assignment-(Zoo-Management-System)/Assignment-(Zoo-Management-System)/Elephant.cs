using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    class Elephant : Mammal
    {
        public override bool IsDangerous
        {
            get
            {
                return false;
            }
        }

        public override string Species
        {
            get
            {
                return "Elephant";
            }
        }
    }
}
