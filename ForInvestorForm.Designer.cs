namespace Lb2_Sharp
{
    partial class ForInvestorForm
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
            this.InvestitionNumeric = new System.Windows.Forms.NumericUpDown();
            this.ListOfFactories = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.ListOfInvestmentResults = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InvestitionNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // InvestitionNumeric
            // 
            this.InvestitionNumeric.Location = new System.Drawing.Point(317, 194);
            this.InvestitionNumeric.Name = "InvestitionNumeric";
            this.InvestitionNumeric.Size = new System.Drawing.Size(177, 20);
            this.InvestitionNumeric.TabIndex = 0;
            // 
            // ListOfFactories
            // 
            this.ListOfFactories.HideSelection = false;
            this.ListOfFactories.Location = new System.Drawing.Point(59, 75);
            this.ListOfFactories.Name = "ListOfFactories";
            this.ListOfFactories.Size = new System.Drawing.Size(225, 256);
            this.ListOfFactories.TabIndex = 1;
            this.ListOfFactories.UseCompatibleStateImageBehavior = false;
            this.ListOfFactories.SelectedIndexChanged += new System.EventHandler(this.ListOfFactories_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back to main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListOfInvestmentResults
            // 
            this.ListOfInvestmentResults.HideSelection = false;
            this.ListOfInvestmentResults.Location = new System.Drawing.Point(526, 75);
            this.ListOfInvestmentResults.Name = "ListOfInvestmentResults";
            this.ListOfInvestmentResults.Size = new System.Drawing.Size(225, 256);
            this.ListOfInvestmentResults.TabIndex = 4;
            this.ListOfInvestmentResults.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of factories to invest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Money after investment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Give some coins to the withcer";
            // 
            // ForInvestorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListOfInvestmentResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListOfFactories);
            this.Controls.Add(this.InvestitionNumeric);
            this.Name = "ForInvestorForm";
            this.Text = "ForInvestorForm";
            ((System.ComponentModel.ISupportInitialize)(this.InvestitionNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown InvestitionNumeric;
        private System.Windows.Forms.ListView ListOfFactories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView ListOfInvestmentResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}