using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment__Zoo_Management_System_
{
    public partial class FormViewAnimal : Form
    {
        public FormViewAnimal()
        {
            InitializeComponent();

            // Load Data of Animals and Employees
            LoadAllEmployees();
            LoadAllAnimals();

            dgvViewAllAnimals.DataSource = Animal.Animals;

            // Hide datagridview columns
            dgvViewAllAnimals.Columns["CareTaker"].Visible = false;
            dgvViewAllAnimals.Columns["_Class"].Visible = false;
            dgvViewAllAnimals.Columns["Species"].Visible = false;
            dgvViewAllAnimals.Columns["_Region"].Visible = false;
            dgvViewAllAnimals.Columns["ConservationStatus"].Visible = false;
            dgvViewAllAnimals.Columns["TypeOfFood"].Visible = false;

            // Bind data from animals property to label
            lblClass.DataBindings.Add("Text", Animal.Animals, "_Class");
            lblSpecie.DataBindings.Add("Text", Animal.Animals, "Species");
            lblTypeOfFood.DataBindings.Add("Text", Animal.Animals, "TypeOfFood");
            lblRegion.DataBindings.Add("Text", Animal.Animals, "_Region");
            lblConservationStatus.DataBindings.Add("Text", Animal.Animals, "ConservationStatus");

            // Event button
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            FormAddNewAnimal frmAddNewAnimal = new FormAddNewAnimal();

            frmAddNewAnimal.ShowDialog();
        }

        private void LoadAllAnimals()
        {
            Animal.Animals.Add(new Lion()
            {
                ID = "A001",
                Name = "Lulu",
                Gender = Gender._Gender.Male,
                _Age = new Age() { Year = 2, Month = 4 },
                _Weight = 200,
                CageType = Cage.Type.Metal,
                CareTaker = (CareTaker)Employee.Employees[0],
                TypeOfFood = "Meat, large-body prey, ..",
                _Region = MyRegion.From.Afica
            });

            Animal.Animals.Add(new Tiger()
            {
                ID = "A002",
                Name = "Lili",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Year = 5, Month = 7 },
                _Weight = 200,
                CageType = Cage.Type.Metal,
                CareTaker = (CareTaker)Employee.Employees[0],
                TypeOfFood = "Meat, large-body prey, ..",
                _Region = MyRegion.From.Asia
            });

            Animal.Animals.Add(new Elephant()
            {
                ID = "A003",
                Name = "Momo",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Month = 2, Year = 4 },
                _Weight = 200,
                CageType = Cage.Type.Wood,
                CareTaker = (CareTaker)Employee.Employees[1],
                TypeOfFood = "Vegetation, grasses, small plants, bushes, fruit, ..",
                _Region = MyRegion.From.Asia
            });

            Animal.Animals.Add(new Penguin()
            {
                ID = "A004",
                Name = "Piggi",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Year = 5, Month = 1 },
                _Weight = 20,
                CageType = Cage.Type.Free_Lane,
                CareTaker = (CareTaker)Employee.Employees[1],
                TypeOfFood = "Krill (a shrimp-like crustacean in the Family Euphausiidae), squids, and fishes.",
                _Region = MyRegion.From.Antarctica
            });

            Animal.Animals.Add(new Peocock()
            {
                ID = "A005",
                Name = "Nana",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Year = 5, Month = 6 },
                _Weight = 17,
                CageType = Cage.Type.Wood,
                CareTaker = (CareTaker)Employee.Employees[0],
                TypeOfFood = "Seed, insects, fruit, ..",
                _Region = MyRegion.From.Asia
            });

            Animal.Animals.Add(new Cichild()
            {
                ID = "A006",
                Name = "Sylar",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Year = 3, Month = 5 },
                _Weight = 17,
                CageType = Cage.Type.Aqurium,
                CareTaker = (CareTaker)Employee.Employees[0],
                TypeOfFood = "Small-fish, snail, some plant",
                _Region = MyRegion.From.Afica
            });
        }

        private void LoadAllEmployees()
        {
            Employee.Employees.Add(new CareTaker()
            {
                ID = "E001",
                Name = "Sok Dara",
                Gender = Gender._Gender.Male,
                Age = 20,
                WorkDate = "20 October 2000"
            });

            Employee.Employees.Add(new CareTaker()
            {
                ID = "E002",
                Name = "Keo Thida",
                Gender = Gender._Gender.Female,
                Age = 25,
                WorkDate = "21 September 2002"
            });

            Employee.Employees.Add(new Security()
            {
                ID = "E003",
                Name = "Chan Tola",
                Gender = Gender._Gender.Male,
                Age = 25,
                WorkDate = "21 December 2004"
            });
        }
    }
}
