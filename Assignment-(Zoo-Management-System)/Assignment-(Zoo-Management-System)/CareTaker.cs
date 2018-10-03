using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    public class CareTaker : Employee
    {
        private List<Animal> animals = new List<Animal>();

        public List<Animal> ListAnimals
        {
            get { return this.animals; }
            set { this.animals = value; }
        }
        public override string Position
        {
            get
            {
                return "Care Taker";
            }
        }
    }
}
