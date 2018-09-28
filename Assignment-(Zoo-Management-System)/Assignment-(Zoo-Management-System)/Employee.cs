using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    public abstract class Employee
    {
        /* Field */
        private string id;
        private string name;
        private int age;
        private Gender_.Gender gender;
        private string workDate;
        /* End of Field */

        /* Property */
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public abstract string Position
        {
            get;
        }
        public Gender_.Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public string WorkDate
        {
            get { return this.workDate; }
            set { this.workDate = value; }
        }    
        /* End of Property */    
    }
}
