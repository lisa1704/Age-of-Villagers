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
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.NationList = new System.Windows.Forms.ComboBox();
            this.AgeofVillagers = new System.Windows.Forms.Label();
            this.VillageNametextBox = new System.Windows.Forms.TextBox();
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
            this.Tree.Location = new System.Drawing.Point(636, 209);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(75, 23);
            this.Tree.TabIndex = 6;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(759, 209);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(75, 23);
            this.House.TabIndex = 7;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // WaterSource
            // 
            this.WaterSource.Location = new System.Drawing.Point(675, 238);
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
            this.VillageName.Location = new System.Drawing.Point(697, 139);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(69, 13);
            this.VillageName.TabIndex = 11;
            this.VillageName.Text = "Village Name";
            this.VillageName.Click += new System.EventHandler(this.VillageName_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Location = new System.Drawing.Point(25, 12);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(605, 400);
            this.DrawPanel.TabIndex = 13;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel);
            // 
            // NationList
            // 
            this.NationList.FormattingEnabled = true;
            this.NationList.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egytian Kings",
            "Iunit Hunters"});
            this.NationList.Location = new System.Drawing.Point(675, 167);
            this.NationList.Name = "NationList";
            this.NationList.Size = new System.Drawing.Size(121, 21);
            this.NationList.TabIndex = 0;
            this.NationList.Text = "Nation";
            this.NationList.SelectedIndexChanged += new System.EventHandler(this.NationList_SelectedIndexChanged);
            // 
            // AgeofVillagers
            // 
            this.AgeofVillagers.AutoSize = true;
            this.AgeofVillagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeofVillagers.Location = new System.Drawing.Point(676, 63);
            this.AgeofVillagers.Name = "AgeofVillagers";
            this.AgeofVillagers.Size = new System.Drawing.Size(120, 20);
            this.AgeofVillagers.TabIndex = 14;
            this.AgeofVillagers.Text = "Age of Villagers";
            this.AgeofVillagers.Click += new System.EventHandler(this.AgeofVillagers_Click);
            // 
            // VillageNametextBox
            // 
            this.VillageNametextBox.Location = new System.Drawing.Point(680, 107);
            this.VillageNametextBox.Name = "VillageNametextBox";
            this.VillageNametextBox.Size = new System.Drawing.Size(100, 20);
            this.VillageNametextBox.TabIndex = 0;
            this.VillageNametextBox.TextChanged += new System.EventHandler(this.VillageNametextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 435);
            this.Controls.Add(this.VillageNametextBox);
            this.Controls.Add(this.AgeofVillagers);
            this.Controls.Add(this.NationList);
            this.Controls.Add(this.DrawPanel);
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
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.ComboBox NationList;
        private System.Windows.Forms.Label AgeofVillagers;
        private System.Windows.Forms.TextBox VillageNametextBox;
    }
}

