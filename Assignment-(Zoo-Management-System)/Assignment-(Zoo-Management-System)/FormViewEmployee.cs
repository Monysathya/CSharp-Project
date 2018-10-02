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
    public partial class FormViewEmployee : Form
    {
        private BindingSource bs = new BindingSource();
        public FormViewEmployee()
        {
            InitializeComponent();

            bs.DataSource = Employee.Employees;
            dgvViewAllEmployee.DataSource = bs;

            dgvViewAllEmployee.Columns["IDAndName"].Visible = false;

            cboSort.SelectedIndex = 0;

            // Button event
            btnAdd.Click += BtnAdd_Click;
            btnSort.Click += BtnSort_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // If user want to delete last record of Care Taker
                if (bs.Current is CareTaker && Employee.Employees.Where(x => x.Position == "Care Taker").Count() <= 1)
                    MessageBox.Show("You cannot delete this record. Please add another Care Taker if you want to delete this record.", "Cannot delete");
                else
                    Employee.Employees.RemoveAt(dgvViewAllEmployee.CurrentRow.Index);
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            if (cboSort.Text == "ID")
                dgvViewAllEmployee.DataSource = Employee.Employees.OrderBy(x => x.ID).ToList();
            if (cboSort.Text == "Name")
                dgvViewAllEmployee.DataSource = Employee.Employees.OrderBy(x => x.Name).ToList();
            if (cboSort.Text == "Gender")
                dgvViewAllEmployee.DataSource = Employee.Employees.OrderBy(x => x.Gender).ToList();
            if (cboSort.Text == "Age")
                dgvViewAllEmployee.DataSource = Employee.Employees.OrderBy(x => x.Age).ToList();
            if (cboSort.Text == "Position")
                dgvViewAllEmployee.DataSource = Employee.Employees.OrderBy(x => x.Position).ToList();
            if (cboSort.Text == "Salary")
                dgvViewAllEmployee.DataSource = Employee.Employees.OrderBy(x => x.Salary).ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddNewEmployee frmAddNewEmployee = new FormAddNewEmployee();

            frmAddNewEmployee.Create += FrmAddNewEmployee_Create;
            frmAddNewEmployee.ShowDialog();
        }

        private void FrmAddNewEmployee_Create(object sender, Employee employee)
        {
            Employee.Employees.Add(employee);
        }
    }
}
