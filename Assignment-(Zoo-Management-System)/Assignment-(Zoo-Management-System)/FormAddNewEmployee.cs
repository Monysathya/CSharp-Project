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

            // Add item to cboDay
            for (int i = 1; i <= 31; i++)
                cboDay.Items.Add(i);

            // Add item to cboYear
            for (int i = 1990; i <= 3000; i++)
                cboYear.Items.Add(i);

            // Set first item to be selected in cboPosition
            cboPosition.SelectedIndex = 0;
            cboDay.SelectedIndex = 0;
            cboMonth.SelectedIndex = 0;
            cboYear.SelectedIndex = 0;

            // Button Event
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
            Employee employee = null;

            string workdate = cboDay.Text + " " + cboMonth.Text + " " + cboYear.Text;

            try
            {
                if (cboPosition.Text == "Care Taker")
                {
                    employee = new CareTaker()
                    {
                        ID = MyString.FirstLetterToUpper(txtID.Text),
                        FirstName = MyString.FirstLetterToUpper(txtFirstName.Text),
                        LastName = MyString.FirstLetterToUpper(txtLastName.Text),
                        Gender = (Gender._Gender)cboGender.SelectedItem,
                        Age = int.Parse(txtAge.Text),
                        _Salary = double.Parse(txtSalary.Text),
                        WorkDate = workdate
                    };
                }
                if (cboPosition.Text == "Security")
                {
                    employee = new Security()
                    {
                        ID = MyString.FirstLetterToUpper(txtID.Text),
                        FirstName = MyString.FirstLetterToUpper(txtFirstName.Text),
                        LastName = MyString.FirstLetterToUpper(txtLastName.Text),
                        Gender = (Gender._Gender)cboGender.SelectedItem,
                        Age = int.Parse(txtAge.Text),
                        _Salary = double.Parse(txtSalary.Text),
                        WorkDate = workdate
                    };
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (Create != null)
                Create(this, employee);
        }
    }
}
