namespace Age_of_Villagers
{
    partial class VillageCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VillageCreator));
            this.NewVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.House = new System.Windows.Forms.RadioButton();
            this.WaterSource = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AgeOfVillagers = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.VillageName = new System.Windows.Forms.Label();
            this.NationName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewVillage
            // 
            resources.ApplyResources(this.NewVillage, "NewVillage");
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // OpenVillage
            // 
            resources.ApplyResources(this.OpenVillage, "OpenVillage");
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // SaveVillage
            // 
            resources.ApplyResources(this.SaveVillage, "SaveVillage");
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // Tree
            // 
            resources.ApplyResources(this.Tree, "Tree");
            this.Tree.Name = "Tree";
            this.Tree.TabStop = true;
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.CheckedChanged += new System.EventHandler(this.Tree_CheckedChanged);
            // 
            // House
            // 
            resources.ApplyResources(this.House, "House");
            this.House.Name = "House";
            this.House.TabStop = true;
            this.House.UseVisualStyleBackColor = true;
            this.House.CheckedChanged += new System.EventHandler(this.House_CheckedChanged);
            // 
            // WaterSource
            // 
            resources.ApplyResources(this.WaterSource, "WaterSource");
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.TabStop = true;
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.CheckedChanged += new System.EventHandler(this.WaterSource_CheckedChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AgeOfVillagers
            // 
            resources.ApplyResources(this.AgeOfVillagers, "AgeOfVillagers");
            this.AgeOfVillagers.Name = "AgeOfVillagers";
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Name = "comboBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // VillageName
            // 
            resources.ApplyResources(this.VillageName, "VillageName");
            this.VillageName.Name = "VillageName";
            // 
            // NationName
            // 
            resources.ApplyResources(this.NationName, "NationName");
            this.NationName.Name = "NationName";
            // 
            // VillageCreator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NationName);
            this.Controls.Add(this.VillageName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.AgeOfVillagers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WaterSource);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.SaveVillage);
            this.Controls.Add(this.OpenVillage);
            this.Controls.Add(this.NewVillage);
            this.Name = "VillageCreator";
            this.Load += new System.EventHandler(this.VillageCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.RadioButton Tree;
        private System.Windows.Forms.RadioButton House;
        private System.Windows.Forms.RadioButton WaterSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AgeOfVillagers;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label VillageName;
        private System.Windows.Forms.Label NationName;
    }
}

