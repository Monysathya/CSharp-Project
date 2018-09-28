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
        public FormMain()
        {
            InitializeComponent();

            btnViewAllAnimals.Click += BtnViewAllAnimals_Click;
        }

        private void BtnViewAllAnimals_Click(object sender, EventArgs e)
        {
            FormViewAnimal formViewAnimal = new FormViewAnimal();

            formViewAnimal.Show();
        }
    }
}
