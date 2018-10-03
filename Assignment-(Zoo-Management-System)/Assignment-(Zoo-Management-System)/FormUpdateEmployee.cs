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
    public partial class FormUpdateEmployee : Form
    {
        private Employee temp = null;

        public delegate void ModifyHandler(object sender, Employee employee);
        public event ModifyHandler Modified = null;

        public FormUpdateEmployee(Employee e)
        {
            InitializeComponent();

            temp = e;

            /* Add data to combobox */
            cboGender.DataSource = Enum.GetValues(typeof(Gender._Gender));

            // Add position of employee to cboPosition
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

            /* End of add data to combobox */

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
            Employee employee = null;
            bool canUpdate = false;

            string workdate = cboDay.Text + " " + cboMonth.Text + " " + cboYear.Text;

            try
            {
                var tID = txtID.Text;
                var tFirstName = MyString.FirstLetterToUpper(txtFirstName.Text);
                var tLastName = MyString.FirstLetterToUpper(txtLastName.Text);
                var tGender = (Gender._Gender)cboGender.SelectedItem;
                var tAge = int.Parse(txtAge.Text);
                var tSalary = double.Parse(txtSalary.Text);
                var tWorkDate = workdate;

                foreach (Employee emp in Employee.Employees)
                {
                    // If user want to update last Care Taker record to Security record
                    if (temp.Position == "Care Taker"
                        && Employee.Employees.Where(x => x.Position == "Care Taker").Count() <= 1
                        && cboPosition.Text != "Care Taker")
                        throw new Exception("Cannot change position of this employee. " +
                            "Please add another Care Taker if you want to change position of this employee");


                    canUpdate = true;

                    if (cboPosition.Text == "Care Taker")
                        employee = new CareTaker();

                    if (cboPosition.Text == "Security")
                        employee = new Security();

                    employee.ID = tID;
                    employee.FirstName = tFirstName;
                    employee.LastName = tLastName;
                    employee.Gender = tGender;
                    employee.Age = tAge;
                    employee._Salary = tSalary;
                    employee.WorkDate = tWorkDate;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (canUpdate)
            {
                if (Modified != null)
                    Modified(this, employee);
            }
        }

        private void SetSelectedData()
        {
            // Set data in combobox
            cboPosition.SelectedItem = temp.Position;
            cboGender.SelectedItem = temp.Gender;

            string[] _workDate = temp.WorkDate.Split(null);

            cboDay.Text = _workDate[0];
            cboMonth.SelectedItem = _workDate[1];
            cboYear.Text = _workDate[2];

            // Set data in textbox
            txtID.Text = temp.ID;
            txtAge.Text = temp.Age.ToString();

            string[] fullName = temp.Name.Split(null);
            string[] salary = temp.Salary.Split('$');

            txtFirstName.Text = fullName[0];
            txtLastName.Text = fullName[1];
            txtSalary.Text = salary[1];
        }
    }
}
