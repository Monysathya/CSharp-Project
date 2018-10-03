using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Assignment__Zoo_Management_System_
{
    public partial class FormViewAnimal : Form
    {
        public FormViewAnimal()
        {
            InitializeComponent();

            dgvViewAllAnimals.DataSource = Animal.Animals;

            // Hide datagridview columns
            dgvViewAllAnimals.Columns["CareTaker"].Visible = false;
            dgvViewAllAnimals.Columns["_Class"].Visible = false;
            dgvViewAllAnimals.Columns["Species"].Visible = false;
            dgvViewAllAnimals.Columns["_Region"].Visible = false;
            dgvViewAllAnimals.Columns["ConservationStatus"].Visible = false;
            dgvViewAllAnimals.Columns["TypeOfFood"].Visible = false;

            // Bind data from animals property to label
            lblClass.DataBindings.Add("Text", Animal.Animals, "_Class");
            lblSpecie.DataBindings.Add("Text", Animal.Animals, "Species");
            lblTypeOfFood.DataBindings.Add("Text", Animal.Animals, "TypeOfFood");
            lblRegion.DataBindings.Add("Text", Animal.Animals, "_Region");
            lblConservationStatus.DataBindings.Add("Text", Animal.Animals, "ConservationStatus");

            // Event button
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnUpdate.Click += BtnUpdate_Click;
        }

        private void BtnUpdate_Click(object sender, System.EventArgs e)
        {
            int index = dgvViewAllAnimals.CurrentRow.Index;

            FormUpdateAnimal frmUpdateAnimal = new FormUpdateAnimal(Animal.Animals[index]);

            frmUpdateAnimal.Modified += FrmUpdateAnimal_Modified;
            frmUpdateAnimal.ShowDialog();
        }

        private void FrmUpdateAnimal_Modified(object sender, Animal animal)
        {
            Animal.Animals[dgvViewAllAnimals.CurrentRow.Index] = animal;
        }

        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            int index = dgvViewAllAnimals.CurrentRow.Index;

            if (MessageBox.Show("Do you want to delete this record?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Remove animal from list of care taker
                foreach (Employee c in Employee.Employees)
                {
                    if (c.ID == Animal.Animals[index].CareTakerID)
                    {
                        (c as CareTaker).ListAnimals.Remove(Animal.Animals[index]);

                        break;
                    }
                }

                Animal.Animals.RemoveAt(index);

                MessageBox.Show("Record Deleted");              
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            FormAddNewAnimal frmAddNewAnimal = new FormAddNewAnimal();

            frmAddNewAnimal.Create += FrmAddNewAnimal_Create;
            frmAddNewAnimal.ShowDialog();
        }

        private void FrmAddNewAnimal_Create(object sender, Animal animal)
        {
            Animal.Animals.Add(animal);
        }

    }
}
