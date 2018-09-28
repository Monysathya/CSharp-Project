using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment__Zoo_Management_System_
{
    public partial class FormViewAnimal : Form
    {
        private List<Animal> animals = new List<Animal>();
        private List<Employee> employees = new List<Employee>();

        public FormViewAnimal()
        {
            InitializeComponent();

            // Load Data of Animals and Employees
            LoadAllEmployees();
            LoadAllAnimals();

            dgvViewAllAnimals.DataSource = animals;

            dgvViewAllAnimals.Columns["CareTaker"].Visible = false;
            dgvViewAllAnimals.Columns["_Class"].Visible = false;
            dgvViewAllAnimals.Columns["Species"].Visible = false;
            dgvViewAllAnimals.Columns["CanFly"].Visible = false;
            dgvViewAllAnimals.Columns["IsDangerous"].Visible = false;
            dgvViewAllAnimals.Columns["TypeOfFood"].Visible = false;

            lblClass.DataBindings.Add("Text", animals, "_Class");
            lblSpecie.DataBindings.Add("Text", animals, "Species");
            lblTypeOfFood.DataBindings.Add("Text", animals, "TypeOfFood");
            lblIsDanger.DataBindings.Add("Text", animals, "IsDangerous");
            lblCanFly.DataBindings.Add("Text", animals, "canFly");
        }

        private void LoadAllAnimals()
        {
            animals.Add(new Lion()
            {
                ID = "A001",
                Name = "Lulu",
                Gender = Gender_.Gender.Male,
                Age = 7,
                Weight = 200,
                CageType = Cage.CageType.Metal,
                CareTaker = (CareTaker)employees[0]
            });

            animals.Add(new Tiger()
            {
                ID = "A002",
                Name = "Lili",
                Gender = Gender_.Gender.Female,
                Age = 7,
                Weight = 200,
                CageType = Cage.CageType.Metal,
                CareTaker = (CareTaker)employees[0]
            });

            animals.Add(new Elephant()
            {
                ID = "A003",
                Name = "Momo",
                Gender = Gender_.Gender.Female,
                Age = 20,
                Weight = 200,
                CageType = Cage.CageType.Wood,
                CareTaker = (CareTaker)employees[1],
                TypeOfFood = "Vegetation, grasses, small plants, bushes, fruit, .."
            });

            animals.Add(new Penguin()
            {
                ID = "A004",
                Name = "Piggi",
                Gender = Gender_.Gender.Female,
                Age = 4,
                Weight = 20,
                CageType = Cage.CageType.No_Cage,
                CareTaker = (CareTaker)employees[1],
                TypeOfFood = "Krill (a shrimp-like crustacean in the Family Euphausiidae), squids, and fishes."
            });
        }

        private void LoadAllEmployees()
        {
            employees.Add(new CareTaker()
            {
                ID = "E001",
                Name = "Sok Dara",
                Gender = Gender_.Gender.Male,
                Age = 20,
                WorkDate = "20 October 2000"
            });

            employees.Add(new CareTaker()
            {
                ID = "E002",
                Name = "Keo Thida",
                Gender = Gender_.Gender.Female,
                Age = 25,
                WorkDate = "21 September 2002"
            });
        }
    }
}
