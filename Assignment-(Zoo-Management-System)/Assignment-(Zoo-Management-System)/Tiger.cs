using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    class Tiger : Animal
    {
        public override bool canFly
        {
            get
            {
                return false;
            }
        }

        public override bool isDangerous
        {
            get
            {
                return true;
            }
        }

        public override string Species
        {
            get
            {
                return "Tiger";
            }
        }

        public override string _Class
        {
            get
            {
                return Class.ClassType.Mammal.ToString();
            }
        }
    }
}
