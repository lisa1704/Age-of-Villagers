﻿namespace Age_of_villagers
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
            this.panel = new System.Windows.Forms.Panel();
            this.Age_of_Villagers = new System.Windows.Forms.Label();
            this.tree = new System.Windows.Forms.RadioButton();
            this.house = new System.Windows.Forms.RadioButton();
            this.water_source = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Villagename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Location = new System.Drawing.Point(3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(600, 400);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            // 
            // Age_of_Villagers
            // 
            this.Age_of_Villagers.AutoSize = true;
            this.Age_of_Villagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_of_Villagers.Location = new System.Drawing.Point(639, 28);
            this.Age_of_Villagers.Name = "Age_of_Villagers";
            this.Age_of_Villagers.Size = new System.Drawing.Size(165, 25);
            this.Age_of_Villagers.TabIndex = 1;
            this.Age_of_Villagers.Text = "Age of Villagers";
            this.Age_of_Villagers.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tree
            // 
            this.tree.AutoSize = true;
            this.tree.Location = new System.Drawing.Point(644, 208);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(59, 21);
            this.tree.TabIndex = 4;
            this.tree.TabStop = true;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = true;
            this.tree.CheckedChanged += new System.EventHandler(this.Tree_CheckedChanged);
            // 
            // house
            // 
            this.house.AutoSize = true;
            this.house.Location = new System.Drawing.Point(734, 208);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(70, 21);
            this.house.TabIndex = 5;
            this.house.TabStop = true;
            this.house.Text = "House";
            this.house.UseVisualStyleBackColor = true;
            this.house.CheckedChanged += new System.EventHandler(this.House_CheckedChanged);
            // 
            // water_source
            // 
            this.water_source.AutoSize = true;
            this.water_source.Location = new System.Drawing.Point(664, 244);
            this.water_source.Name = "water_source";
            this.water_source.Size = new System.Drawing.Size(116, 21);
            this.water_source.TabIndex = 6;
            this.water_source.TabStop = true;
            this.water_source.Text = "Water Source";
            this.water_source.UseVisualStyleBackColor = true;
            this.water_source.CheckedChanged += new System.EventHandler(this.Water_source_CheckedChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(694, 293);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Save Village";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(644, 338);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 8;
            this.New.Text = "New Village";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(734, 338);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 9;
            this.open.Text = "Open Village";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Arab Bedouin",
            "Inuit Hunters"});
            this.comboBox1.Location = new System.Drawing.Point(659, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Villagename
            // 
            this.Villagename.Location = new System.Drawing.Point(669, 74);
            this.Villagename.Name = "Villagename";
            this.Villagename.Size = new System.Drawing.Size(100, 22);
            this.Villagename.TabIndex = 11;
            this.Villagename.Text = "Village Name";
            this.Villagename.TextChanged += new System.EventHandler(this.Villagename_TextChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(949, 441);
            this.Controls.Add(this.Villagename);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.New);
            this.Controls.Add(this.save);
            this.Controls.Add(this.water_source);
            this.Controls.Add(this.house);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.Age_of_Villagers);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gamename;
        private System.Windows.Forms.RadioButton radioButtontree;
        private System.Windows.Forms.RadioButton radiobuttonhouse;
        private System.Windows.Forms.RadioButton radioButtonWaterSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAgeofvillagers;
        private System.Windows.Forms.Label labelVillagename;
        private System.Windows.Forms.Label labelNation;
        private System.Windows.Forms.RadioButton radioButtTree;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label Age_of_Villagers;
        private System.Windows.Forms.RadioButton tree;
        private System.Windows.Forms.RadioButton house;
        private System.Windows.Forms.RadioButton water_source;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Villagename;
    }
}

