namespace Assignment__Zoo_Management_System_
{
    partial class FormMain
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
            this.btnViewAllAnimals = new System.Windows.Forms.Button();
            this.btnViewAllEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // btnViewAllAnimals
            // 
            this.btnViewAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllAnimals.Location = new System.Drawing.Point(25, 107);
            this.btnViewAllAnimals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAllAnimals.Name = "btnViewAllAnimals";
            this.btnViewAllAnimals.Size = new System.Drawing.Size(321, 44);
            this.btnViewAllAnimals.TabIndex = 1;
            this.btnViewAllAnimals.Text = "View All Animals";
            this.btnViewAllAnimals.UseVisualStyleBackColor = true;
            // 
            // btnViewAllEmployee
            // 
            this.btnViewAllEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllEmployee.Location = new System.Drawing.Point(25, 170);
            this.btnViewAllEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAllEmployee.Name = "btnViewAllEmployee";
            this.btnViewAllEmployee.Size = new System.Drawing.Size(321, 44);
            this.btnViewAllEmployee.TabIndex = 2;
            this.btnViewAllEmployee.Text = "View All Employees";
            this.btnViewAllEmployee.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment__Zoo_Management_System_.Properties.Resources.bg_animal_in_zoo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 461);
            this.Controls.Add(this.btnViewAllEmployee);
            this.Controls.Add(this.btnViewAllAnimals);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Zoo Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAllAnimals;
        private System.Windows.Forms.Button btnViewAllEmployee;
    }
}

