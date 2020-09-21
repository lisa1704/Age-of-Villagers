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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Nation = new System.Windows.Forms.TextBox();
            this.VillageName = new System.Windows.Forms.TextBox();
            this.OpenVillageButton = new System.Windows.Forms.Button();
            this.NewVillageButton = new System.Windows.Forms.Button();
            this.SaveVillageButton = new System.Windows.Forms.Button();
            this.WaterButton = new System.Windows.Forms.Button();
            this.HouseButton = new System.Windows.Forms.Button();
            this.TreeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Nation);
            this.panel2.Controls.Add(this.VillageName);
            this.panel2.Controls.Add(this.OpenVillageButton);
            this.panel2.Controls.Add(this.NewVillageButton);
            this.panel2.Controls.Add(this.SaveVillageButton);
            this.panel2.Controls.Add(this.WaterButton);
            this.panel2.Controls.Add(this.HouseButton);
            this.panel2.Controls.Add(this.TreeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(618, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 400);
            this.panel2.TabIndex = 1;
            // 
            // Nation
            // 
            this.Nation.Location = new System.Drawing.Point(18, 82);
            this.Nation.Name = "Nation";
            this.Nation.Size = new System.Drawing.Size(149, 26);
            this.Nation.TabIndex = 8;
            this.Nation.TextChanged += new System.EventHandler(this.Nation_TextChanged);
            // 
            // VillageName
            // 
            this.VillageName.Location = new System.Drawing.Point(18, 50);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(149, 26);
            this.VillageName.TabIndex = 7;
            this.VillageName.TextChanged += new System.EventHandler(this.VillageName_TextChanged);
            // 
            // OpenVillageButton
            // 
            this.OpenVillageButton.Location = new System.Drawing.Point(92, 340);
            this.OpenVillageButton.Name = "OpenVillageButton";
            this.OpenVillageButton.Size = new System.Drawing.Size(82, 52);
            this.OpenVillageButton.TabIndex = 6;
            this.OpenVillageButton.Text = "Open Village";
            this.OpenVillageButton.UseVisualStyleBackColor = true;
            this.OpenVillageButton.Click += new System.EventHandler(this.OpenVillageButton_Click);
            // 
            // NewVillageButton
            // 
            this.NewVillageButton.Location = new System.Drawing.Point(4, 340);
            this.NewVillageButton.Name = "NewVillageButton";
            this.NewVillageButton.Size = new System.Drawing.Size(75, 52);
            this.NewVillageButton.TabIndex = 5;
            this.NewVillageButton.Text = "New Village";
            this.NewVillageButton.UseVisualStyleBackColor = true;
            this.NewVillageButton.Click += new System.EventHandler(this.NewVillageButton_Click);
            // 
            // SaveVillageButton
            // 
            this.SaveVillageButton.Location = new System.Drawing.Point(31, 296);
            this.SaveVillageButton.Name = "SaveVillageButton";
            this.SaveVillageButton.Size = new System.Drawing.Size(119, 28);
            this.SaveVillageButton.TabIndex = 4;
            this.SaveVillageButton.Text = "Save Village";
            this.SaveVillageButton.UseVisualStyleBackColor = true;
            this.SaveVillageButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // WaterButton
            // 
            this.WaterButton.Location = new System.Drawing.Point(31, 190);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(119, 41);
            this.WaterButton.TabIndex = 3;
            this.WaterButton.Text = "Water Source";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // HouseButton
            // 
            this.HouseButton.Location = new System.Drawing.Point(92, 141);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(82, 33);
            this.HouseButton.TabIndex = 2;
            this.HouseButton.Text = "House";
            this.HouseButton.UseVisualStyleBackColor = true;
            this.HouseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TreeButton
            // 
            this.TreeButton.Location = new System.Drawing.Point(3, 141);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(76, 33);
            this.TreeButton.TabIndex = 1;
            this.TreeButton.Text = "Tree";
            this.TreeButton.UseVisualStyleBackColor = true;
            this.TreeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age Of Villagers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TreeButton;
        private System.Windows.Forms.Button HouseButton;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.Button SaveVillageButton;
        private System.Windows.Forms.Button OpenVillageButton;
        private System.Windows.Forms.Button NewVillageButton;
        private System.Windows.Forms.TextBox VillageName;
        private System.Windows.Forms.TextBox Nation;
    }
}