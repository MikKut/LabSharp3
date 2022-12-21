namespace Lb2_Sharp
{
    partial class UnitFactoriesForm
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
            this.IncomePerSlave = new System.Windows.Forms.Label();
            this.IncomePerMaster = new System.Windows.Forms.Label();
            this.QuantityOfSlavesLabel = new System.Windows.Forms.Label();
            this.QuantityOfMasters = new System.Windows.Forms.Label();
            this.QuantityOfWorkshops = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.Label();
            this.IncomePerMasterBox = new System.Windows.Forms.Label();
            this.IncomePerSlaveBox = new System.Windows.Forms.Label();
            this.QuantityOfWorshopsBox = new System.Windows.Forms.Label();
            this.QuantityOfMastersBox = new System.Windows.Forms.Label();
            this.QuantityOfEmployeesBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IncomePerSlave
            // 
            this.IncomePerSlave.AutoSize = true;
            this.IncomePerSlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomePerSlave.Location = new System.Drawing.Point(534, 135);
            this.IncomePerSlave.Name = "IncomePerSlave";
            this.IncomePerSlave.Size = new System.Drawing.Size(108, 13);
            this.IncomePerSlave.TabIndex = 39;
            this.IncomePerSlave.Text = "Income per employee";
            this.IncomePerSlave.Click += new System.EventHandler(this.IncomePerSlave_Click);
            // 
            // IncomePerMaster
            // 
            this.IncomePerMaster.AutoSize = true;
            this.IncomePerMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomePerMaster.Location = new System.Drawing.Point(329, 91);
            this.IncomePerMaster.Name = "IncomePerMaster";
            this.IncomePerMaster.Size = new System.Drawing.Size(125, 17);
            this.IncomePerMaster.TabIndex = 38;
            this.IncomePerMaster.Text = "Income per master";
            this.IncomePerMaster.Click += new System.EventHandler(this.IncomePerMaster_Click);
            // 
            // QuantityOfSlavesLabel
            // 
            this.QuantityOfSlavesLabel.AutoSize = true;
            this.QuantityOfSlavesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityOfSlavesLabel.Location = new System.Drawing.Point(528, 200);
            this.QuantityOfSlavesLabel.Name = "QuantityOfSlavesLabel";
            this.QuantityOfSlavesLabel.Size = new System.Drawing.Size(149, 17);
            this.QuantityOfSlavesLabel.TabIndex = 37;
            this.QuantityOfSlavesLabel.Text = "Quantity of employees";
            this.QuantityOfSlavesLabel.Click += new System.EventHandler(this.QuantityOfSlavesLabel_Click);
            // 
            // QuantityOfMasters
            // 
            this.QuantityOfMasters.AutoSize = true;
            this.QuantityOfMasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityOfMasters.Location = new System.Drawing.Point(332, 245);
            this.QuantityOfMasters.Name = "QuantityOfMasters";
            this.QuantityOfMasters.Size = new System.Drawing.Size(97, 13);
            this.QuantityOfMasters.TabIndex = 35;
            this.QuantityOfMasters.Text = "Quantity of masters";
            this.QuantityOfMasters.Click += new System.EventHandler(this.QuantityOfMasters_Click);
            // 
            // QuantityOfWorkshops
            // 
            this.QuantityOfWorkshops.AutoSize = true;
            this.QuantityOfWorkshops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityOfWorkshops.Location = new System.Drawing.Point(94, 245);
            this.QuantityOfWorkshops.Name = "QuantityOfWorkshops";
            this.QuantityOfWorkshops.Size = new System.Drawing.Size(112, 13);
            this.QuantityOfWorkshops.TabIndex = 33;
            this.QuantityOfWorkshops.Text = "Quantity of workshops";
            this.QuantityOfWorkshops.Click += new System.EventHandler(this.QuantityOfWorkshops_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Location = new System.Drawing.Point(332, 334);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(126, 39);
            this.BackToMainMenu.TabIndex = 29;
            this.BackToMainMenu.Text = "Back to main menu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Location = new System.Drawing.Point(94, 135);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(35, 13);
            this.NameBox.TabIndex = 40;
            this.NameBox.Text = "Name";
            // 
            // IncomePerMasterBox
            // 
            this.IncomePerMasterBox.AutoSize = true;
            this.IncomePerMasterBox.Location = new System.Drawing.Point(332, 135);
            this.IncomePerMasterBox.Name = "IncomePerMasterBox";
            this.IncomePerMasterBox.Size = new System.Drawing.Size(94, 13);
            this.IncomePerMasterBox.TabIndex = 41;
            this.IncomePerMasterBox.Text = "Income per master";
            this.IncomePerMasterBox.Click += new System.EventHandler(this.label3_Click);
            // 
            // IncomePerSlaveBox
            // 
            this.IncomePerSlaveBox.AutoSize = true;
            this.IncomePerSlaveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomePerSlaveBox.Location = new System.Drawing.Point(528, 91);
            this.IncomePerSlaveBox.Name = "IncomePerSlaveBox";
            this.IncomePerSlaveBox.Size = new System.Drawing.Size(143, 17);
            this.IncomePerSlaveBox.TabIndex = 42;
            this.IncomePerSlaveBox.Text = "Income per employee";
            // 
            // QuantityOfWorshopsBox
            // 
            this.QuantityOfWorshopsBox.AutoSize = true;
            this.QuantityOfWorshopsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityOfWorshopsBox.Location = new System.Drawing.Point(94, 200);
            this.QuantityOfWorshopsBox.Name = "QuantityOfWorshopsBox";
            this.QuantityOfWorshopsBox.Size = new System.Drawing.Size(148, 17);
            this.QuantityOfWorshopsBox.TabIndex = 43;
            this.QuantityOfWorshopsBox.Text = "Quantity of workshops";
            // 
            // QuantityOfMastersBox
            // 
            this.QuantityOfMastersBox.AutoSize = true;
            this.QuantityOfMastersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityOfMastersBox.Location = new System.Drawing.Point(332, 204);
            this.QuantityOfMastersBox.Name = "QuantityOfMastersBox";
            this.QuantityOfMastersBox.Size = new System.Drawing.Size(131, 17);
            this.QuantityOfMastersBox.TabIndex = 44;
            this.QuantityOfMastersBox.Text = "Quantity of masters";
            // 
            // QuantityOfEmployeesBox
            // 
            this.QuantityOfEmployeesBox.AutoSize = true;
            this.QuantityOfEmployeesBox.Location = new System.Drawing.Point(534, 245);
            this.QuantityOfEmployeesBox.Name = "QuantityOfEmployeesBox";
            this.QuantityOfEmployeesBox.Size = new System.Drawing.Size(111, 13);
            this.QuantityOfEmployeesBox.TabIndex = 45;
            this.QuantityOfEmployeesBox.Text = "Quantity of employees";
            // 
            // UnitFactoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuantityOfEmployeesBox);
            this.Controls.Add(this.QuantityOfMastersBox);
            this.Controls.Add(this.QuantityOfWorshopsBox);
            this.Controls.Add(this.IncomePerSlaveBox);
            this.Controls.Add(this.IncomePerMasterBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.IncomePerSlave);
            this.Controls.Add(this.IncomePerMaster);
            this.Controls.Add(this.QuantityOfSlavesLabel);
            this.Controls.Add(this.QuantityOfMasters);
            this.Controls.Add(this.QuantityOfWorkshops);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UnitFactoriesForm";
            this.Text = "UnitFactories";
            this.Load += new System.EventHandler(this.UnitFactoriesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IncomePerSlave;
        private System.Windows.Forms.Label IncomePerMaster;
        private System.Windows.Forms.Label QuantityOfSlavesLabel;
        private System.Windows.Forms.Label QuantityOfMasters;
        private System.Windows.Forms.Label QuantityOfWorkshops;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.Label IncomePerMasterBox;
        private System.Windows.Forms.Label IncomePerSlaveBox;
        private System.Windows.Forms.Label QuantityOfWorshopsBox;
        private System.Windows.Forms.Label QuantityOfMastersBox;
        private System.Windows.Forms.Label QuantityOfEmployeesBox;
    }
}