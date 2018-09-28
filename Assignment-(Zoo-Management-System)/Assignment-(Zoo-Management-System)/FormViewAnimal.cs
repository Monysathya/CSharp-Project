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
            dgvViewAllAnimals.Columns["Class"].Visible = false;

            lblClass.DataBindings.Add("Text", animals, "Class");
            lblSpecie.DataBindings.Add("Text", animals, "Species");
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
                CageType = Cage.CageType.METAL,
                CareTaker = (CareTaker)employees[0]
            });

            animals.Add(new Tiger()
            {
                ID = "A002",
                Name = "Lili",
                Gender = Gender_.Gender.Female,
                Age = 7,
                Weight = 200,
                CageType = Cage.CageType.METAL,
                CareTaker = (CareTaker)employees[0]
            });

            animals.Add(new Elephant()
            {
                ID = "A003",
                Name = "Momo",
                Gender = Gender_.Gender.Female,
                Age = 20,
                Weight = 200,
                CageType = Cage.CageType.WOOD,
                CareTaker = (CareTaker)employees[1]
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
