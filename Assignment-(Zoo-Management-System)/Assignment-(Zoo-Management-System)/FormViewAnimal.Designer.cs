namespace Assignment__Zoo_Management_System_
{
    partial class FormViewAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.lblConservationStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblTypeOfFood = new System.Windows.Forms.Label();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvViewAllAnimals = new System.Windows.Forms.DataGridView();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of all animals in the zoo";
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.lblConservationStatus);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.lblRegion);
            this.gbDetail.Controls.Add(this.lblTypeOfFood);
            this.gbDetail.Controls.Add(this.lblSpecie);
            this.gbDetail.Controls.Add(this.lblClass);
            this.gbDetail.Controls.Add(this.btnDelete);
            this.gbDetail.Controls.Add(this.btnUpdate);
            this.gbDetail.Controls.Add(this.btnAdd);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(16, 443);
            this.gbDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetail.Size = new System.Drawing.Size(1385, 321);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "More Detail";
            // 
            // lblConservationStatus
            // 
            this.lblConservationStatus.AutoSize = true;
            this.lblConservationStatus.Location = new System.Drawing.Point(299, 261);
            this.lblConservationStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConservationStatus.Name = "lblConservationStatus";
            this.lblConservationStatus.Size = new System.Drawing.Size(37, 29);
            this.lblConservationStatus.TabIndex = 13;
            this.lblConservationStatus.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Conservation Status: ";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(299, 208);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(37, 29);
            this.lblRegion.TabIndex = 11;
            this.lblRegion.Text = "---";
            // 
            // lblTypeOfFood
            // 
            this.lblTypeOfFood.AutoSize = true;
            this.lblTypeOfFood.Location = new System.Drawing.Point(299, 155);
            this.lblTypeOfFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeOfFood.Name = "lblTypeOfFood";
            this.lblTypeOfFood.Size = new System.Drawing.Size(37, 29);
            this.lblTypeOfFood.TabIndex = 10;
            this.lblTypeOfFood.Text = "---";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Location = new System.Drawing.Point(299, 102);
            this.lblSpecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(37, 29);
            this.lblSpecie.TabIndex = 9;
            this.lblSpecie.Text = "---";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(299, 49);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(37, 29);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "---";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1060, 96);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(317, 43);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Information";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1060, 36);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(317, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1060, 249);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(317, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add new animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Region: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type of food: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Species: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class: ";
            // 
            // dgvViewAllAnimals
            // 
            this.dgvViewAllAnimals.AllowUserToAddRows = false;
            this.dgvViewAllAnimals.AllowUserToDeleteRows = false;
            this.dgvViewAllAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewAllAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAllAnimals.Location = new System.Drawing.Point(12, 58);
            this.dgvViewAllAnimals.Name = "dgvViewAllAnimals";
            this.dgvViewAllAnimals.ReadOnly = true;
            this.dgvViewAllAnimals.RowTemplate.Height = 24;
            this.dgvViewAllAnimals.Size = new System.Drawing.Size(1381, 378);
            this.dgvViewAllAnimals.TabIndex = 14;
            // 
            // FormViewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 774);
            this.Controls.Add(this.dgvViewAllAnimals);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormViewAnimal";
            this.Text = "Viewing All Animals";
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllAnimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblTypeOfFood;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.Label lblConservationStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvViewAllAnimals;
    }
}