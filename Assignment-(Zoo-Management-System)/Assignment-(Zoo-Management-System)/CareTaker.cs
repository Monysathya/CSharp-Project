using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    public class CareTaker : Employee
    { 
        public override string Position
        {
            get
            {
                return "Care Taker";
            }
        }

        public static explicit operator CareTaker(string v)
        {
            throw new NotImplementedException();
        }
    }
}
