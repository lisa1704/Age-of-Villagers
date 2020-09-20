namespace age_of_villagers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ageofvillagers = new System.Windows.Forms.Label();
            this.villagenamebox = new System.Windows.Forms.TextBox();
            this.villagename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(33, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ageofvillagers
            // 
            this.ageofvillagers.AutoSize = true;
            this.ageofvillagers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ageofvillagers.Location = new System.Drawing.Point(681, 38);
            this.ageofvillagers.Name = "ageofvillagers";
            this.ageofvillagers.Size = new System.Drawing.Size(193, 32);
            this.ageofvillagers.TabIndex = 1;
            this.ageofvillagers.Text = "Age of villagers";
            this.ageofvillagers.Click += new System.EventHandler(this.ageofvillagers_Click);
            // 
            // villagenamebox
            // 
            this.villagenamebox.Location = new System.Drawing.Point(786, 100);
            this.villagenamebox.Name = "villagenamebox";
            this.villagenamebox.Size = new System.Drawing.Size(100, 23);
            this.villagenamebox.TabIndex = 2;
            this.villagenamebox.TextChanged += new System.EventHandler(this.villagenamebox_TextChanged);
            // 
            // villagename
            // 
            this.villagename.AutoSize = true;
            this.villagename.Location = new System.Drawing.Point(705, 103);
            this.villagename.Name = "villagename";
            this.villagename.Size = new System.Drawing.Size(75, 15);
            this.villagename.TabIndex = 3;
            this.villagename.Text = "Village name";
            this.villagename.Click += new System.EventHandler(this.villagename_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.villagename);
            this.Controls.Add(this.villagenamebox);
            this.Controls.Add(this.ageofvillagers);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ageofvillagers;
        private System.Windows.Forms.TextBox villagenamebox;
        private System.Windows.Forms.Label villagename;
    }
}

