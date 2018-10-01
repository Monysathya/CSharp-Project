﻿using System;
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
        public FormViewEmployee()
        {
            InitializeComponent();

            dgvViewAllEmployee.DataSource = Employee.Employees;

            dgvViewAllEmployee.Columns["IDAndName"].Visible = false;

            cboSort.SelectedIndex = 0;

            // Button event
            btnAdd.Click += BtnAdd_Click;
            btnSort.Click += BtnSort_Click;
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
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}