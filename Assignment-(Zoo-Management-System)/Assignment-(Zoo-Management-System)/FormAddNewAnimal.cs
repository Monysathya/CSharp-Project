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
        public FormAddNewAnimal()
        {
            InitializeComponent();

            // Set datasource to combobox
            cboGender.DataSource = Enum.GetValues(typeof(Gender._Gender));
            cboClass.DataSource = Enum.GetValues(typeof(Class.Type));
            cboSpecies.DataSource = Animal.Animals;
            cboSpecies.DisplayMember = "Species"; 
            cboRegion.DataSource = Enum.GetValues(typeof(MyRegion.From));
            cboConservationStatus.DataSource = Enum.GetValues(typeof(Conservation.Status));
            cboCageType.DataSource = Enum.GetValues(typeof(Cage.Type));
            cboCareTaker.DataSource = Employee.Employees;
            cboCareTaker.DisplayMember = "IDAndName";

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
            throw new NotImplementedException();
        }
    }
}
