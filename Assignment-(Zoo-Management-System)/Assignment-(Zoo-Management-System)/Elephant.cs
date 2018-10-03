using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    class Elephant : Animal
    {
        public override string Species
        {
            get
            {
                return "Elephant";
            }
        }

        public override Class.Type _Class
        {
            get
            {
                return Class.Type.Mammal;
            }
        }
    }
}
