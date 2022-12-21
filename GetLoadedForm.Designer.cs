namespace Lb2_CSharp
{
    partial class GetLoadedForm
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
            this.Serializer = new System.Windows.Forms.Button();
            this.Deserializer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Serializer
            // 
            this.Serializer.Location = new System.Drawing.Point(24, 135);
            this.Serializer.Name = "Serializer";
            this.Serializer.Size = new System.Drawing.Size(343, 89);
            this.Serializer.TabIndex = 8;
            this.Serializer.Text = "Serialize current state";
            this.Serializer.UseVisualStyleBackColor = true;
            this.Serializer.Click += new System.EventHandler(this.Serializer_Click);
            // 
            // Deserializer
            // 
            this.Deserializer.Location = new System.Drawing.Point(386, 135);
            this.Deserializer.Name = "Deserializer";
            this.Deserializer.Size = new System.Drawing.Size(309, 89);
            this.Deserializer.TabIndex = 14;
            this.Deserializer.Text = "Deserialize all";
            this.Deserializer.UseVisualStyleBackColor = true;
            this.Deserializer.Click += new System.EventHandler(this.Deserializer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back to main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetLoadedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Deserializer);
            this.Controls.Add(this.Serializer);
            this.Name = "GetLoadedForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Serializer;
        private System.Windows.Forms.Button Deserializer;
        private System.Windows.Forms.Button button1;
    }
}