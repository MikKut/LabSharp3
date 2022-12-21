using Lb3_CSharp.Models;
using System.Collections.Generic;

namespace Lb2_Sharp
{
    partial class GeneralForm
    {
        private int currentFactoryId = 0;
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FactoryNumberChangerButton = new System.Windows.Forms.Button();
            this.FactoryInfoChangerButton = new System.Windows.Forms.Button();
            this.UnitFactoriesButton = new System.Windows.Forms.Button();
            this.ForInvestorsButton = new System.Windows.Forms.Button();
            this.ChangeFactoryInfoTextBox = new System.Windows.Forms.TextBox();
            this.ChangeFactoryInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameForUnity1 = new System.Windows.Forms.TextBox();
            this.NameForUnity2 = new System.Windows.Forms.TextBox();
            this.FactoryInfoChangerBackground = new System.Windows.Forms.GroupBox();
            this.UnitFactoriesBackground = new System.Windows.Forms.GroupBox();
            this.SavingButton = new System.Windows.Forms.Button();
            this.FactoryInfoChangerBackground.SuspendLayout();
            this.UnitFactoriesBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // FactoryNumberChangerButton
            // 
            this.FactoryNumberChangerButton.Location = new System.Drawing.Point(85, 385);
            this.FactoryNumberChangerButton.Name = "FactoryNumberChangerButton";
            this.FactoryNumberChangerButton.Size = new System.Drawing.Size(182, 38);
            this.FactoryNumberChangerButton.TabIndex = 2;
            this.FactoryNumberChangerButton.Text = "Add/delete factories number";
            this.FactoryNumberChangerButton.UseVisualStyleBackColor = true;
            this.FactoryNumberChangerButton.Click += new System.EventHandler(this.FactoryNumberChangerButton_Click);
            // 
            // FactoryInfoChangerButton
            // 
            this.FactoryInfoChangerButton.Location = new System.Drawing.Point(646, 89);
            this.FactoryInfoChangerButton.Name = "FactoryInfoChangerButton";
            this.FactoryInfoChangerButton.Size = new System.Drawing.Size(151, 37);
            this.FactoryInfoChangerButton.TabIndex = 6;
            this.FactoryInfoChangerButton.Text = "Submit";
            this.FactoryInfoChangerButton.UseVisualStyleBackColor = true;
            this.FactoryInfoChangerButton.Click += new System.EventHandler(this.FactoryInfoChangerButton_Click);
            // 
            // UnitFactoriesButton
            // 
            this.UnitFactoriesButton.Location = new System.Drawing.Point(646, 225);
            this.UnitFactoriesButton.Name = "UnitFactoriesButton";
            this.UnitFactoriesButton.Size = new System.Drawing.Size(151, 33);
            this.UnitFactoriesButton.TabIndex = 5;
            this.UnitFactoriesButton.Text = "Go to unit factory";
            this.UnitFactoriesButton.UseVisualStyleBackColor = true;
            this.UnitFactoriesButton.Click += new System.EventHandler(this.UnitFactoriesButton_Click);
            // 
            // ForInvestorsButton
            // 
            this.ForInvestorsButton.Location = new System.Drawing.Point(605, 385);
            this.ForInvestorsButton.Name = "ForInvestorsButton";
            this.ForInvestorsButton.Size = new System.Drawing.Size(182, 38);
            this.ForInvestorsButton.TabIndex = 4;
            this.ForInvestorsButton.Text = "For investors";
            this.ForInvestorsButton.UseVisualStyleBackColor = true;
            this.ForInvestorsButton.Click += new System.EventHandler(this.ForInvestorsButton_Click);
            // 
            // ChangeFactoryInfoTextBox
            // 
            this.ChangeFactoryInfoTextBox.Location = new System.Drawing.Point(37, 25);
            this.ChangeFactoryInfoTextBox.Multiline = true;
            this.ChangeFactoryInfoTextBox.Name = "ChangeFactoryInfoTextBox";
            this.ChangeFactoryInfoTextBox.Size = new System.Drawing.Size(254, 37);
            this.ChangeFactoryInfoTextBox.TabIndex = 7;
            // 
            // ChangeFactoryInfoLabel
            // 
            this.ChangeFactoryInfoLabel.AutoSize = true;
            this.ChangeFactoryInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFactoryInfoLabel.Location = new System.Drawing.Point(29, 89);
            this.ChangeFactoryInfoLabel.Name = "ChangeFactoryInfoLabel";
            this.ChangeFactoryInfoLabel.Size = new System.Drawing.Size(218, 29);
            this.ChangeFactoryInfoLabel.TabIndex = 8;
            this.ChangeFactoryInfoLabel.Text = "Change factory info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unit factories";
            // 
            // NameForUnity1
            // 
            this.NameForUnity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameForUnity1.Location = new System.Drawing.Point(0, 21);
            this.NameForUnity1.Name = "NameForUnity1";
            this.NameForUnity1.Size = new System.Drawing.Size(160, 33);
            this.NameForUnity1.TabIndex = 10;
            this.NameForUnity1.TextChanged += new System.EventHandler(this.NameForUnity1_TextChanged);
            // 
            // NameForUnity2
            // 
            this.NameForUnity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameForUnity2.Location = new System.Drawing.Point(189, 21);
            this.NameForUnity2.Name = "NameForUnity2";
            this.NameForUnity2.Size = new System.Drawing.Size(157, 33);
            this.NameForUnity2.TabIndex = 11;
            // 
            // FactoryInfoChangerBackground
            // 
            this.FactoryInfoChangerBackground.Controls.Add(this.ChangeFactoryInfoTextBox);
            this.FactoryInfoChangerBackground.Location = new System.Drawing.Point(253, 65);
            this.FactoryInfoChangerBackground.Name = "FactoryInfoChangerBackground";
            this.FactoryInfoChangerBackground.Size = new System.Drawing.Size(361, 72);
            this.FactoryInfoChangerBackground.TabIndex = 12;
            this.FactoryInfoChangerBackground.TabStop = false;
            this.FactoryInfoChangerBackground.Text = "Set factory name and submit";
            // 
            // UnitFactoriesBackground
            // 
            this.UnitFactoriesBackground.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnitFactoriesBackground.Controls.Add(this.NameForUnity2);
            this.UnitFactoriesBackground.Controls.Add(this.NameForUnity1);
            this.UnitFactoriesBackground.Location = new System.Drawing.Point(253, 199);
            this.UnitFactoriesBackground.Name = "UnitFactoriesBackground";
            this.UnitFactoriesBackground.Size = new System.Drawing.Size(361, 73);
            this.UnitFactoriesBackground.TabIndex = 8;
            this.UnitFactoriesBackground.TabStop = false;
            this.UnitFactoriesBackground.Text = "Set names and submit";
            // 
            // SavingButton
            // 
            this.SavingButton.Location = new System.Drawing.Point(316, 385);
            this.SavingButton.Name = "SavingButton";
            this.SavingButton.Size = new System.Drawing.Size(241, 38);
            this.SavingButton.TabIndex = 13;
            this.SavingButton.Text = "Go to saving";
            this.SavingButton.UseVisualStyleBackColor = true;
            this.SavingButton.Click += new System.EventHandler(this.GoToSaving_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.SavingButton);
            this.Controls.Add(this.UnitFactoriesBackground);
            this.Controls.Add(this.FactoryInfoChangerBackground);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeFactoryInfoLabel);
            this.Controls.Add(this.ForInvestorsButton);
            this.Controls.Add(this.UnitFactoriesButton);
            this.Controls.Add(this.FactoryInfoChangerButton);
            this.Controls.Add(this.FactoryNumberChangerButton);
            this.Name = "GeneralForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FactoryInfoChangerBackground.ResumeLayout(false);
            this.FactoryInfoChangerBackground.PerformLayout();
            this.UnitFactoriesBackground.ResumeLayout(false);
            this.UnitFactoriesBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FactoryNumberChangerButton;
        private System.Windows.Forms.Button FactoryInfoChangerButton;
        private System.Windows.Forms.Button UnitFactoriesButton;
        private System.Windows.Forms.Button ForInvestorsButton;
        private System.Windows.Forms.TextBox ChangeFactoryInfoTextBox;
        private System.Windows.Forms.Label ChangeFactoryInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameForUnity1;
        private System.Windows.Forms.TextBox NameForUnity2;
        private System.Windows.Forms.GroupBox FactoryInfoChangerBackground;
        private System.Windows.Forms.GroupBox UnitFactoriesBackground;
        private System.Windows.Forms.Button SavingButton;
    }
}

