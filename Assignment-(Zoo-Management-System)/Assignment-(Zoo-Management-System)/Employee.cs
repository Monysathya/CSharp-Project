using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    public abstract class Employee
    {
        /* Field */
        private string id;
        private string fName;
        private string lName;
        private int age;
        private Gender._Gender gender;
        private double salary;
        private string workDate;
        private static BindingList<Employee> emp = new BindingList<Employee>();
        /* End of Field */

        /* Property */
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string FirstName
        {
            private get { return this.fName; }
            set { this.fName = value; }
        }
        public string LastName
        {
            private get { return this.lName; }
            set { this.lName = value; }
        }
        public string Name
        {
            get { return string.Format(this.FirstName + " " + this.LastName); }
        }
        public Gender._Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
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
        public string WorkDate
        {
            get { return this.workDate; }
            set { this.workDate = value; }
        }
        public double _Salary
        {
            private get { return this.salary; }
            set { this.salary = value; }
        }
        public string Salary
        {
            get { return string.Format("{0:C2}", this._Salary); }
        }
        public static BindingList<Employee> Employees
        {
            get { return emp; }
            set { emp = value; }
        }
        public string IDAndName
        {
            get { return this.ID + " " + this.Name; }
        }
        
        /* End of Property */
    }
}
