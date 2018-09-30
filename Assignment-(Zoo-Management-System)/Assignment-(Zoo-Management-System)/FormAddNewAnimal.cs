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
            cboSpecies.DataSource = Animal.Animals;
            cboSpecies.DisplayMember = "Species";
            cboRegion.DataSource = Enum.GetValues(typeof(MyRegion.From));
            cboConservationStatus.DataSource = Enum.GetValues(typeof(Conservation.Status));
            cboCageType.DataSource = Enum.GetValues(typeof(Cage.Type));

            foreach (Employee e in Employee.Employees)
            {
                if (e is CareTaker)
                    cboCareTaker.Items.Add(e.IDAndName);
            }

            cboCareTaker.SelectedIndex = 0;
            cboAgeMonth.SelectedIndex = 0;
            // Button event click
            btnAdd.Click += BtnAdd_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Employee careTaker = new CareTaker();
            Animal animal = null;

            string IDAndName = cboCareTaker.Text;
            string[] caretakerID = IDAndName.Split(null);  // Split IDAndName property and taker only ID

            foreach (Employee t in Employee.Employees)
            {
                if (t.ID == caretakerID[0])
                {
                    careTaker = (CareTaker)t;
                    break;
                }
            }

            if (cboSpecies.Text == "Lion")
            {               
                try
                {
                    animal = new Lion()
                    {
                        ID = MyString.FirstLetterToUpper(txtID.Text),
                        Name = MyString.FirstLetterToUpper(txtName.Text),
                        Gender = (Gender._Gender)cboGender.SelectedItem,
                        _Age = new Age() { Year = int.Parse(txtAgeYear.Text), Month = int.Parse(cboAgeMonth.Text) },
                        _Weight = double.Parse(txtWeight.Text),
                        TypeOfFood = MyString.FirstLetterToUpper(txtTypeOfFood.Text),
                        _Region = (MyRegion.From)cboRegion.SelectedItem,
                        CageType = (Cage.Type)cboCageType.SelectedItem,
                        CareTaker = (CareTaker)careTaker
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (Create != null)
                Create(this, animal);
        }
    }
}
