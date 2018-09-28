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
        private Cage.Type cageType;
        private CareTaker careTaker;
        private Gender._Gender gender;
        private string typeOfFood;
        private MyRegion.From region;
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
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public Cage.Type CageType
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
        public MyRegion.From _Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        /* Abstract method */
        public abstract Class.Type _Class
        {
            get;
        }
        public abstract string Species
        {
            get;
        }
        public abstract Conservation.Status ConservationStatus
        {
            get;
        }
        /*End of abstract method */
        /* End of Property */
    }
}
