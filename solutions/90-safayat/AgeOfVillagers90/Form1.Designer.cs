namespace AgeOfVillagers90
{
    partial class Form1
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
            this.SaveVillage = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.WaterSource = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.VillageName = new System.Windows.Forms.Label();
            this.Nation = new System.Windows.Forms.Label();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(700, 335);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(75, 23);
            this.SaveVillage.TabIndex = 3;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(636, 174);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(75, 23);
            this.Tree.TabIndex = 6;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(759, 174);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(75, 23);
            this.House.TabIndex = 7;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // WaterSource
            // 
            this.WaterSource.Location = new System.Drawing.Point(675, 203);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(111, 23);
            this.WaterSource.TabIndex = 8;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.Click += new System.EventHandler(this.WaterSource_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Location = new System.Drawing.Point(759, 364);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(75, 23);
            this.OpenVillage.TabIndex = 9;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // NewVillage
            // 
            this.NewVillage.Location = new System.Drawing.Point(636, 364);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(75, 23);
            this.NewVillage.TabIndex = 10;
            this.NewVillage.Text = "New Village";
            this.NewVillage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // VillageName
            // 
            this.VillageName.AutoSize = true;
            this.VillageName.Location = new System.Drawing.Point(706, 92);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(69, 13);
            this.VillageName.TabIndex = 11;
            this.VillageName.Text = "Village Name";
            this.VillageName.Click += new System.EventHandler(this.VillageName_Click);
            // 
            // Nation
            // 
            this.Nation.AutoSize = true;
            this.Nation.Location = new System.Drawing.Point(718, 136);
            this.Nation.Name = "Nation";
            this.Nation.Size = new System.Drawing.Size(38, 13);
            this.Nation.TabIndex = 12;
            this.Nation.Text = "Nation";
            this.Nation.Click += new System.EventHandler(this.Nation_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(25, 12);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(605, 400);
            this.DrawPanel.TabIndex = 13;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 583);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.Nation);
            this.Controls.Add(this.VillageName);
            this.Controls.Add(this.NewVillage);
            this.Controls.Add(this.OpenVillage);
            this.Controls.Add(this.WaterSource);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.SaveVillage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button WaterSource;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Label VillageName;
        private System.Windows.Forms.Label Nation;
        private System.Windows.Forms.Panel DrawPanel;
    }
}

