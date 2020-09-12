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
            this.Tree = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.WaterSource = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.AgeOfVillagers = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.VillageName = new System.Windows.Forms.Label();
            this.Nation = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 353);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.Nation);
            this.panel2.Controls.Add(this.VillageName);
            this.panel2.Controls.Add(this.textBox1);
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
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(22, 145);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(98, 33);
            this.Tree.TabIndex = 0;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(143, 145);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(97, 33);
            this.House.TabIndex = 1;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            // 
            // WaterSource
            // 
            this.WaterSource.Location = new System.Drawing.Point(55, 184);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(140, 35);
            this.WaterSource.TabIndex = 2;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(55, 255);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(146, 30);
            this.SaveVillage.TabIndex = 3;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            // 
            // NewVillage
            // 
            this.NewVillage.Location = new System.Drawing.Point(22, 301);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(98, 40);
            this.NewVillage.TabIndex = 4;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.button5_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Location = new System.Drawing.Point(152, 301);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(101, 40);
            this.OpenVillage.TabIndex = 5;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            // 
            // AgeOfVillagers
            // 
            this.AgeOfVillagers.AutoSize = true;
            this.AgeOfVillagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeOfVillagers.Location = new System.Drawing.Point(9, 9);
            this.AgeOfVillagers.Name = "AgeOfVillagers";
            this.AgeOfVillagers.Size = new System.Drawing.Size(170, 25);
            this.AgeOfVillagers.TabIndex = 6;
            this.AgeOfVillagers.Text = "Age Of Villagers";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 10;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label VillageName;
        private System.Windows.Forms.Label Nation;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

