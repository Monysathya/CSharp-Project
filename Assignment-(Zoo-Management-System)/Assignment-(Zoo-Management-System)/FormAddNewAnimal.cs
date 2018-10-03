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
    public partial class FormAddNewAnimal : Form
    {
        public delegate void CreateHandler(object sender, Animal animal);
        public event CreateHandler Create = null;

        public FormAddNewAnimal()
        {
            InitializeComponent();

            // Set datasource to combobox
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

            // Set selected index of combobox to 0 (first item)
            cboCareTaker.SelectedIndex = 0;
            cboAgeMonth.SelectedIndex = 0;
            cboSpecies.SelectedIndex = 0;

            // Button event click
            btnAdd.Click += BtnAdd_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Clear all text box and set combobox selected item to first item
            ResetControl();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Employee careTaker = new CareTaker();
            Animal animal = null;

            bool canCreate = false;

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

                // If ID already have
                foreach (Animal aml in Animal.Animals)
                {
                    if (aml.ID.Equals(tID))
                        throw new Exception(string.Format("Duplicate ID: {0}", tID));
                }

                canCreate = true;

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
                animal._Region = tRegion;
                animal.CageType = tCageType;
                animal.CareTaker = tCareTaker;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (canCreate)
            {
                if (Create != null)
                    Create(this, animal);

                MessageBox.Show("Record Added");

                ResetControl();
            }
        }

        private void ResetControl()
        {
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                {
                    C.Text = "";
                }
                if (C is ComboBox)
                {
                    (C as ComboBox).SelectedIndex = 0;
                }
            }
        }
    }
}
