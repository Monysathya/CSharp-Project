using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    public class Age
    {
        private int year;
        private int month;
        public int Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public override string ToString()
        {
            return string.Format("{0} years and {1} month", this.Year, this.Month);
        }
    }
}
