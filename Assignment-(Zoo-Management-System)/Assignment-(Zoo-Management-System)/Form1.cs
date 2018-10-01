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
    public partial class FormMain : Form
    {
        FormViewAnimal formViewAnimal = new FormViewAnimal();
        FormViewEmployee formViewEmployee = new FormViewEmployee();

        public FormMain()
        {
            InitializeComponent();

            //LoadData.MyEmployees();
            LoadData.Animals();

            btnViewAllAnimals.Click += BtnViewAllAnimals_Click;
            btnViewAllEmployee.Click += BtnViewAllEmployee_Click;
        }

        private void BtnViewAllEmployee_Click(object sender, EventArgs e)
        {
            formViewEmployee.ShowDialog();
        }

        private void BtnViewAllAnimals_Click(object sender, EventArgs e)
        {
            formViewAnimal.ShowDialog();
        }
    }
}
