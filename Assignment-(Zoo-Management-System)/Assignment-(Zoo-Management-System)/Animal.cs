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
        private Age age = new Age();
        private double weight;
        private Cage.Type cageType;
        private CareTaker careTaker;
        private Gender._Gender gender;
        private string typeOfFood;
        private MyRegion.From region;
        private Conservation.Status conservationStatus;
        private static BindingList<Animal> animals = new BindingList<Animal>();
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
        public string Age
        {
            get { return this._Age.ToString(); }
        }
        public Age _Age
        {
            private get { return this.age; }
            set { this.age = value; }
        }
        public double _Weight
        {
            private get { return this.weight; }
            set { this.weight = value; }
        }
        public string Weight
        {
            get { return this._Weight.ToString() + " Kg"; }
        }
        public Cage.Type CageType
        {
            get { return this.cageType; }
            set { this.cageType = value; }
        }
        public CareTaker CareTaker
        {
            get { return this.careTaker; }
            set
            {
                this.careTaker = value;

                // Add animal to list animal of care taker object
                this.CareTaker.ListAnimals.Add(this);
            }
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
        public Conservation.Status ConservationStatus
        {
            get { return this.conservationStatus; }
            set { this.conservationStatus = value; }
        }

        /* Abstract property */
        public abstract Class.Type _Class
        {
            get;
        }
        public abstract string Species
        {
            get;
        }
        /* End of abstract property */

        /* Static property */
        public static BindingList<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }
        /* End of static property */

        /* End of Property */
    }
}
