namespace Age_of_villagers
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
            this.Save_village = new System.Windows.Forms.Button();
            this.New_village = new System.Windows.Forms.Button();
            this.Open_village = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.House = new System.Windows.Forms.RadioButton();
            this.Water_source = new System.Windows.Forms.RadioButton();
            this.Age_of_villagers = new System.Windows.Forms.Label();
            this.VIllage_name = new System.Windows.Forms.TextBox();
            this.Nation_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Save_village
            // 
            this.Save_village.Location = new System.Drawing.Point(663, 275);
            this.Save_village.Name = "Save_village";
            this.Save_village.Size = new System.Drawing.Size(75, 23);
            this.Save_village.TabIndex = 0;
            this.Save_village.Text = "Save Village";
            this.Save_village.UseVisualStyleBackColor = true;
            this.Save_village.Click += new System.EventHandler(this.Save_village_Click);
            // 
            // New_village
            // 
            this.New_village.Location = new System.Drawing.Point(628, 304);
            this.New_village.Name = "New_village";
            this.New_village.Size = new System.Drawing.Size(75, 23);
            this.New_village.TabIndex = 1;
            this.New_village.Text = "New Village";
            this.New_village.UseVisualStyleBackColor = true;
            this.New_village.Click += new System.EventHandler(this.New_village_Click);
            // 
            // Open_village
            // 
            this.Open_village.Location = new System.Drawing.Point(709, 304);
            this.Open_village.Name = "Open_village";
            this.Open_village.Size = new System.Drawing.Size(75, 23);
            this.Open_village.TabIndex = 2;
            this.Open_village.Text = "Open Village";
            this.Open_village.UseVisualStyleBackColor = true;
            this.Open_village.Click += new System.EventHandler(this.Open_village_Click);
            // 
            // Tree
            // 
            this.Tree.AutoSize = true;
            this.Tree.Location = new System.Drawing.Point(737, 163);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(47, 17);
            this.Tree.TabIndex = 3;
            this.Tree.TabStop = true;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.CheckedChanged += new System.EventHandler(this.Tree_CheckedChanged);
            // 
            // House
            // 
            this.House.AutoSize = true;
            this.House.Location = new System.Drawing.Point(628, 163);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(56, 17);
            this.House.TabIndex = 4;
            this.House.TabStop = true;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.CheckedChanged += new System.EventHandler(this.House_CheckedChanged);
            // 
            // Water_source
            // 
            this.Water_source.AutoSize = true;
            this.Water_source.Location = new System.Drawing.Point(663, 140);
            this.Water_source.Name = "Water_source";
            this.Water_source.Size = new System.Drawing.Size(91, 17);
            this.Water_source.TabIndex = 5;
            this.Water_source.TabStop = true;
            this.Water_source.Text = "Water Source";
            this.Water_source.UseVisualStyleBackColor = true;
            this.Water_source.CheckedChanged += new System.EventHandler(this.Water_source_CheckedChanged);
            // 
            // Age_of_villagers
            // 
            this.Age_of_villagers.AutoSize = true;
            this.Age_of_villagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Age_of_villagers.Location = new System.Drawing.Point(624, 55);
            this.Age_of_villagers.Name = "Age_of_villagers";
            this.Age_of_villagers.Size = new System.Drawing.Size(158, 24);
            this.Age_of_villagers.TabIndex = 6;
            this.Age_of_villagers.Text = "Age of Villagers";
            this.Age_of_villagers.Click += new System.EventHandler(this.Age_of_villagers_Click);
            // 
            // VIllage_name
            // 
            this.VIllage_name.Location = new System.Drawing.Point(682, 82);
            this.VIllage_name.Name = "VIllage_name";
            this.VIllage_name.Size = new System.Drawing.Size(100, 20);
            this.VIllage_name.TabIndex = 7;
            this.VIllage_name.TextChanged += new System.EventHandler(this.VIllage_name_TextChanged);
            // 
            // Nation_name
            // 
            this.Nation_name.FormattingEnabled = true;
            this.Nation_name.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Beduins",
            "Inuits Hunters",
            "Egyptian Kings"});
            this.Nation_name.Location = new System.Drawing.Point(661, 108);
            this.Nation_name.Name = "Nation_name";
            this.Nation_name.Size = new System.Drawing.Size(121, 21);
            this.Nation_name.TabIndex = 8;
            this.Nation_name.SelectedIndexChanged += new System.EventHandler(this.Nation_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Village Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Main_panel
            // 
            this.Main_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(600, 400);
            this.Main_panel.TabIndex = 11;
            this.Main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_panel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nation_name);
            this.Controls.Add(this.VIllage_name);
            this.Controls.Add(this.Age_of_villagers);
            this.Controls.Add(this.Water_source);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Open_village);
            this.Controls.Add(this.New_village);
            this.Controls.Add(this.Save_village);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_village;
        private System.Windows.Forms.Button New_village;
        private System.Windows.Forms.Button Open_village;
        private System.Windows.Forms.RadioButton Tree;
        private System.Windows.Forms.RadioButton House;
        private System.Windows.Forms.RadioButton Water_source;
        private System.Windows.Forms.Label Age_of_villagers;
        private System.Windows.Forms.TextBox VIllage_name;
        private System.Windows.Forms.ComboBox Nation_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Main_panel;
    }
}

