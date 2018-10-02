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
    public partial class FormAddNewEmployee : Form
    {
        public delegate void CreateHandler(object sender, Employee employee);
        public event CreateHandler Create = null;

        private List<string> group = new List<string>();

        public FormAddNewEmployee()
        {
            InitializeComponent();

            cboGender.DataSource = Enum.GetValues(typeof(Gender._Gender));

            // Add position of employee to combobox cboPosition
            var groupPosition = Employee.Employees.GroupBy(g => g.Position).Select(s => new { value = s.Key });

            foreach (var s in groupPosition)
            {
                cboPosition.Items.Add(s.value);
            }

            // Set first item to be selected in cboPosition
            cboPosition.SelectedIndex = 0;

            btnAdd.Click += BtnAdd_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = null;

            try
            {
                if (cboPosition.Text == "Care Taker")
                {

                }
                if (cboPosition.Text == "Security")
                {

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (Create != null)
                Create(this, employee);
        }
    }
}
