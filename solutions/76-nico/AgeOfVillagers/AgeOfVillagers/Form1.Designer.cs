namespace AgeOfVillagers
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
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.Tree = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.WaterSource = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Open_Village = new System.Windows.Forms.Button();
            this.Save_Village = new System.Windows.Forms.Button();
            this.Nations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VillageName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(12, 2);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(618, 223);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(75, 23);
            this.Tree.TabIndex = 1;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(723, 223);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(75, 23);
            this.House.TabIndex = 2;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // WaterSource
            // 
            this.WaterSource.Location = new System.Drawing.Point(660, 252);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(114, 23);
            this.WaterSource.TabIndex = 3;
            this.WaterSource.Text = "WaterSource";
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.Click += new System.EventHandler(this.WaterSource_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "New_Village";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Open_Village
            // 
            this.Open_Village.Location = new System.Drawing.Point(723, 341);
            this.Open_Village.Name = "Open_Village";
            this.Open_Village.Size = new System.Drawing.Size(101, 23);
            this.Open_Village.TabIndex = 5;
            this.Open_Village.Text = "OpenVillage";
            this.Open_Village.UseVisualStyleBackColor = true;
            this.Open_Village.Click += new System.EventHandler(this.Open_Village_Click);
            // 
            // Save_Village
            // 
            this.Save_Village.Location = new System.Drawing.Point(671, 312);
            this.Save_Village.Name = "Save_Village";
            this.Save_Village.Size = new System.Drawing.Size(103, 23);
            this.Save_Village.TabIndex = 6;
            this.Save_Village.Text = "SaveVillage";
            this.Save_Village.UseVisualStyleBackColor = true;
            this.Save_Village.Click += new System.EventHandler(this.Save_Village_Click);
            // 
            // Nations
            // 
            this.Nations.FormattingEnabled = true;
            this.Nations.Items.AddRange(new object[] {
            "Bangladesh Farmers",
            "Egyptian Kings",
            "Arab Bedouin ",
            "Inuit Hunters"});
            this.Nations.Location = new System.Drawing.Point(657, 108);
            this.Nations.Name = "Nations";
            this.Nations.Size = new System.Drawing.Size(121, 24);
            this.Nations.TabIndex = 7;
            this.Nations.Text = "Nations";
            this.Nations.SelectedIndexChanged += new System.EventHandler(this.Nations_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Age Of Villagers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VillageName
            // 
            this.VillageName.AutoSize = true;
            this.VillageName.Location = new System.Drawing.Point(668, 77);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(91, 17);
            this.VillageName.TabIndex = 9;
            this.VillageName.Text = "Village Name";
            this.VillageName.Click += new System.EventHandler(this.VillageName_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(826, 469);
            this.Controls.Add(this.VillageName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nations);
            this.Controls.Add(this.Save_Village);
            this.Controls.Add(this.Open_Village);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WaterSource);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.DrawPanel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.ListBox NationList;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button WaterSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Open_Village;
        private System.Windows.Forms.Button Save_Village;
        private System.Windows.Forms.ComboBox Nations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VillageName;
    }
}

