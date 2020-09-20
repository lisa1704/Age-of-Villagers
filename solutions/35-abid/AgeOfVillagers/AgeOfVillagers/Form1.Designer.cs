namespace AgeOfVillagers
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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.TextBox();
            this.VillageName = new System.Windows.Forms.TextBox();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.House = new System.Windows.Forms.RadioButton();
            this.WaterSource = new System.Windows.Forms.RadioButton();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.Nations = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(11, 12);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Click += new System.EventHandler(this.DrawingPanel_Click);
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseClick);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(639, 24);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(185, 23);
            this.Title.TabIndex = 1;
            this.Title.Text = "Age of Villagers";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VillageName
            // 
            this.VillageName.BackColor = System.Drawing.SystemColors.Control;
            this.VillageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VillageName.Location = new System.Drawing.Point(664, 86);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(132, 18);
            this.VillageName.TabIndex = 2;
            this.VillageName.Text = "Enter Village Name";
            this.VillageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VillageName.Click += new System.EventHandler(this.VillageName_Click);
            this.VillageName.TextChanged += new System.EventHandler(this.VillageName_TextChanged);
            // 
            // Tree
            // 
            this.Tree.AutoSize = true;
            this.Tree.Location = new System.Drawing.Point(630, 195);
            this.Tree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(58, 21);
            this.Tree.TabIndex = 4;
            this.Tree.TabStop = true;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.CheckedChanged += new System.EventHandler(this.Tree_CheckedChanged);
            // 
            // House
            // 
            this.House.AutoSize = true;
            this.House.Location = new System.Drawing.Point(751, 195);
            this.House.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(71, 21);
            this.House.TabIndex = 5;
            this.House.TabStop = true;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.CheckedChanged += new System.EventHandler(this.House_CheckedChanged);
            // 
            // WaterSource
            // 
            this.WaterSource.AutoSize = true;
            this.WaterSource.Location = new System.Drawing.Point(664, 222);
            this.WaterSource.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(119, 21);
            this.WaterSource.TabIndex = 6;
            this.WaterSource.TabStop = true;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.CheckedChanged += new System.EventHandler(this.WaterSource_CheckedChanged);
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(674, 325);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(107, 35);
            this.SaveVillage.TabIndex = 7;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // NewVillage
            // 
            this.NewVillage.Location = new System.Drawing.Point(615, 366);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(108, 36);
            this.NewVillage.TabIndex = 8;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Location = new System.Drawing.Point(729, 366);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(113, 36);
            this.OpenVillage.TabIndex = 9;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // Nations
            // 
            this.Nations.BackColor = System.Drawing.SystemColors.Control;
            this.Nations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nations.FormattingEnabled = true;
            this.Nations.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.Nations.Location = new System.Drawing.Point(655, 138);
            this.Nations.Name = "Nations";
            this.Nations.Size = new System.Drawing.Size(151, 25);
            this.Nations.TabIndex = 10;
            this.Nations.SelectedIndexChanged += new System.EventHandler(this.Nations_SelectedIndexChanged);
            this.Nations.TextChanged += new System.EventHandler(this.Nations_TextChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 431);
            this.Controls.Add(this.Nations);
            this.Controls.Add(this.OpenVillage);
            this.Controls.Add(this.NewVillage);
            this.Controls.Add(this.SaveVillage);
            this.Controls.Add(this.WaterSource);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.VillageName);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DrawingPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Create Village";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox VillageName;
        private System.Windows.Forms.RadioButton Tree;
        private System.Windows.Forms.RadioButton House;
        private System.Windows.Forms.RadioButton WaterSource;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.ComboBox Nations;
    }
}

