using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment__Zoo_Management_System_
{
    public partial class FormUpdateAnimal : Form
    {
        private Animal temp = null;

        public delegate void ModifyHandler(object sender, Animal animal);
        public event ModifyHandler Modified = null;

        public FormUpdateAnimal(Animal a)
        {
            InitializeComponent();

            temp = a;

            /* Add data to combobox */
            cboGender.DataSource = Enum.GetValues(typeof(Gender._Gender));
            cboRegion.DataSource = Enum.GetValues(typeof(MyRegion.From));
            cboConservationStatus.DataSource = Enum.GetValues(typeof(Conservation.Status));
            cboCageType.DataSource = Enum.GetValues(typeof(Cage.Type));

            // Add species to combobox species
            var groupSpecies = Animal.Animals.GroupBy(g => g.Species).Select(s => new { value = s.Key });

            foreach (var s in groupSpecies)
            {
                cboSpecies.Items.Add(s.value);
            }

            // Add only care taker to combobox care taker
            foreach (Employee e in Employee.Employees)
            {
                if (e is CareTaker)
                    cboCareTaker.Items.Add(e.IDAndName);
            }

            SetSelectedData();

            // Button event
            btnUpdate.Click += BtnUpdate_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SetSelectedData();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Employee careTaker = new CareTaker();
            Animal animal = null;

            bool canUpdate = false;

            try
            {
                // Split IDAndName property and take only ID of Care Taker
                string IDAndName = cboCareTaker.Text;
                string[] caretakerID = IDAndName.Split(null);

                foreach (Employee t in Employee.Employees)
                {
                    if (t.ID == caretakerID[0])
                    {
                        careTaker = (CareTaker)t;
                        break;
                    }
                }

                var tID = MyString.FirstLetterToUpper(txtID.Text);
                var tName = MyString.FirstLetterToUpper(txtName.Text);
                var tGender = (Gender._Gender)cboGender.SelectedItem;
                var tAge = new Age() { Year = int.Parse(txtAgeYear.Text), Month = int.Parse(cboAgeMonth.Text) };
                var tWeight = double.Parse(txtWeight.Text);
                var tTypeOfFood = MyString.FirstLetterToUpper(txtTypeOfFood.Text);
                var tRegion = (MyRegion.From)cboRegion.SelectedItem;
                var tCageType = (Cage.Type)cboCageType.SelectedItem;
                var tCareTaker = (CareTaker)careTaker;
                var tConservationStatus = (Conservation.Status)cboConservationStatus.SelectedIndex;

                canUpdate = true;

                if (cboSpecies.Text == "Lion")
                    animal = new Lion();

                if (cboSpecies.Text == "Tiger")
                    animal = new Tiger();

                if (cboSpecies.Text == "Elephant")
                    animal = new Elephant();

                if (cboSpecies.Text == "Penguin")
                    animal = new Penguin();

                if (cboSpecies.Text == "Peocock")
                    animal = new Peocock();

                if (cboSpecies.Text == "Cichild")
                    animal = new Cichild();

                animal.ID = tID;
                animal.Name = tName;
                animal.Gender = tGender;
                animal._Age = tAge;
                animal._Weight = tWeight;
                animal.TypeOfFood = tTypeOfFood;
                animal.ConservationStatus = tConservationStatus;
                animal._Region = tRegion;
                animal.CageType = tCageType;
                animal.CareTaker = tCareTaker;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (canUpdate)
            {
                if (Modified != null)
                    Modified(this, animal);

                MessageBox.Show("Record Updated");
            }
        }

        private void SetSelectedData()
        {
            // Set selected item in combobox
            cboCareTaker.SelectedItem = temp.CareTaker.IDAndName;
            cboSpecies.SelectedItem = temp.Species;
            cboCageType.SelectedItem = temp.CageType;
            cboConservationStatus.SelectedItem = temp.ConservationStatus;
            cboGender.SelectedItem = temp.Gender;
            cboRegion.SelectedItem = temp._Region;

            string[] ageMonth = temp.Age.Split(null);
            string[] weight = temp.Weight.Split(null);

            cboAgeMonth.SelectedItem = ageMonth[3];

            // Set data to textbox
            txtID.Text = temp.ID;
            txtName.Text = temp.Name;
            txtAgeYear.Text = ageMonth[0];
            txtWeight.Text = weight[0];
            txtTypeOfFood.Text = temp.TypeOfFood;
        }
    }
}
