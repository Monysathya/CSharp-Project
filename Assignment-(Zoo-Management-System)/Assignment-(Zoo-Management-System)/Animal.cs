using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    public abstract class Animal
    {
        /* Field */
        private string id;
        private string name;
        private int age;
        private double weight;
        private Cage.CageType cageType;
        private CareTaker careTaker;
        private Gender_.Gender gender;
        private string typeOfFood;
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
        public Gender_.Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public Cage.CageType CageType
        {
            get { return this.cageType; }
            set { this.cageType = value; }
        }
        public CareTaker CareTaker
        {
            get { return this.careTaker; }
            set { this.careTaker = value; }
        }
        public string TypeOfFood
        {
            get { return this.typeOfFood; }
            set { this.typeOfFood = value; }
        }
        public string CareTakerID
        {
            get { return this.CareTaker.ID; }
        }
        public string CareTakerName
        {
            get { return this.CareTaker.Name; }
        }
        /* Abstract method */
        public abstract string _Class
        {
            get;
        }
        public abstract string Species
        {
            get;
        }

        public abstract bool canFly
        {
            get;
        }
        public abstract bool isDangerous
        {
            get;
        }
        /*End of abstract method */
        /* End of Property */
    }
}
