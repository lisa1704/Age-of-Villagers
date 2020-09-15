namespace age_of_villagers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nations = new System.Windows.Forms.ComboBox();
            this.Nation = new System.Windows.Forms.Label();
            this.VillageName = new System.Windows.Forms.Label();
            this.village = new System.Windows.Forms.TextBox();
            this.AgeOfVillagers = new System.Windows.Forms.Label();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.WaterSource = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 353);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawOnClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nations);
            this.panel2.Controls.Add(this.Nation);
            this.panel2.Controls.Add(this.VillageName);
            this.panel2.Controls.Add(this.village);
            this.panel2.Controls.Add(this.AgeOfVillagers);
            this.panel2.Controls.Add(this.OpenVillage);
            this.panel2.Controls.Add(this.NewVillage);
            this.panel2.Controls.Add(this.SaveVillage);
            this.panel2.Controls.Add(this.WaterSource);
            this.panel2.Controls.Add(this.House);
            this.panel2.Controls.Add(this.Tree);
            this.panel2.Location = new System.Drawing.Point(317, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 353);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1);
            // 
            // nations
            // 
            this.nations.FormattingEnabled = true;
            this.nations.Items.AddRange(new object[] {
            "Arab",
            "Bangladesh",
            "Egypt",
            "Inuit"});
            this.nations.Location = new System.Drawing.Point(45, 115);
            this.nations.Name = "nations";
            this.nations.Size = new System.Drawing.Size(162, 24);
            this.nations.TabIndex = 10;
            this.nations.SelectedIndexChanged += new System.EventHandler(this.nationType);
            // 
            // Nation
            // 
            this.Nation.AutoSize = true;
            this.Nation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nation.Location = new System.Drawing.Point(90, 92);
            this.Nation.Name = "Nation";
            this.Nation.Size = new System.Drawing.Size(57, 20);
            this.Nation.TabIndex = 9;
            this.Nation.Text = "Nation";
            this.Nation.Click += new System.EventHandler(this.Nation_Click);
            // 
            // VillageName
            // 
            this.VillageName.AutoSize = true;
            this.VillageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VillageName.Location = new System.Drawing.Point(63, 44);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(108, 20);
            this.VillageName.TabIndex = 8;
            this.VillageName.Text = "Village Name";
            this.VillageName.Click += new System.EventHandler(this.VillageName_Click);
            // 
            // village
            // 
            this.village.Location = new System.Drawing.Point(45, 67);
            this.village.Name = "village";
            this.village.Size = new System.Drawing.Size(162, 22);
            this.village.TabIndex = 7;
            this.village.TextChanged += new System.EventHandler(this.villageName);
            // 
            // AgeOfVillagers
            // 
            this.AgeOfVillagers.AutoSize = true;
            this.AgeOfVillagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeOfVillagers.Location = new System.Drawing.Point(40, 9);
            this.AgeOfVillagers.Name = "AgeOfVillagers";
            this.AgeOfVillagers.Size = new System.Drawing.Size(170, 25);
            this.AgeOfVillagers.TabIndex = 6;
            this.AgeOfVillagers.Text = "Age Of Villagers";
            this.AgeOfVillagers.Click += new System.EventHandler(this.AgeOfVillagers_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Location = new System.Drawing.Point(152, 301);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(101, 40);
            this.OpenVillage.TabIndex = 5;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // NewVillage
            // 
            this.NewVillage.Location = new System.Drawing.Point(22, 301);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(98, 40);
            this.NewVillage.TabIndex = 4;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(55, 255);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(146, 30);
            this.SaveVillage.TabIndex = 3;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // WaterSource
            // 
            this.WaterSource.Location = new System.Drawing.Point(55, 184);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(140, 35);
            this.WaterSource.TabIndex = 2;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.Click += new System.EventHandler(this.WaterSource_Click);
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(143, 145);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(97, 33);
            this.House.TabIndex = 1;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(22, 145);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(98, 33);
            this.Tree.TabIndex = 0;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.tree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button WaterSource;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Label AgeOfVillagers;
        private System.Windows.Forms.TextBox village;
        private System.Windows.Forms.Label VillageName;
        private System.Windows.Forms.Label Nation;
        private System.Windows.Forms.ComboBox nations;
    }
}

