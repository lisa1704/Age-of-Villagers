namespace AgeOfVillagers
{
    partial class CreateNewVillage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewVillage));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Open_Village = new System.Windows.Forms.Button();
            this.New_Village = new System.Windows.Forms.Button();
            this.Save_Village = new System.Windows.Forms.Button();
            this.Draw_Panel = new System.Windows.Forms.Panel();
            this.Village_Name = new System.Windows.Forms.TextBox();
            this.Age_Of_Villagers = new System.Windows.Forms.Label();
            this.Select_Nation = new System.Windows.Forms.ComboBox();
            this.Tree = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.Water_Source = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Open_Village
            // 
            this.Open_Village.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Open_Village.Location = new System.Drawing.Point(701, 362);
            this.Open_Village.Name = "Open_Village";
            this.Open_Village.Size = new System.Drawing.Size(96, 35);
            this.Open_Village.TabIndex = 0;
            this.Open_Village.Text = "Open Village";
            this.Open_Village.UseVisualStyleBackColor = true;
            this.Open_Village.Click += new System.EventHandler(this.Open_Village_Click);
            // 
            // New_Village
            // 
            this.New_Village.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.New_Village.Location = new System.Drawing.Point(606, 362);
            this.New_Village.Name = "New_Village";
            this.New_Village.Size = new System.Drawing.Size(89, 32);
            this.New_Village.TabIndex = 1;
            this.New_Village.Text = "New Vilage";
            this.New_Village.UseVisualStyleBackColor = true;
            this.New_Village.Click += new System.EventHandler(this.New_Village_Click);
            // 
            // Save_Village
            // 
            this.Save_Village.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Save_Village.Location = new System.Drawing.Point(648, 322);
            this.Save_Village.Name = "Save_Village";
            this.Save_Village.Size = new System.Drawing.Size(104, 34);
            this.Save_Village.TabIndex = 2;
            this.Save_Village.Text = "Save Village";
            this.Save_Village.UseVisualStyleBackColor = true;
            this.Save_Village.Click += new System.EventHandler(this.Save_Village_Click);
            // 
            // Draw_Panel
            // 
            this.Draw_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Draw_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Draw_Panel.Location = new System.Drawing.Point(0, 0);
            this.Draw_Panel.Name = "Draw_Panel";
            this.Draw_Panel.Size = new System.Drawing.Size(600, 400);
            this.Draw_Panel.TabIndex = 3;
            // 
            // Village_Name
            // 
            this.Village_Name.BackColor = System.Drawing.SystemColors.Control;
            this.Village_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Village_Name.Location = new System.Drawing.Point(638, 72);
            this.Village_Name.Name = "Village_Name";
            this.Village_Name.Size = new System.Drawing.Size(141, 19);
            this.Village_Name.TabIndex = 4;
            this.Village_Name.Text = "\r\nEnter Village Name";
            this.Village_Name.TextChanged += new System.EventHandler(this.Village_Name_TextChanged);
            // 
            // Age_Of_Villagers
            // 
            this.Age_Of_Villagers.AutoSize = true;
            this.Age_Of_Villagers.BackColor = System.Drawing.SystemColors.Control;
            this.Age_Of_Villagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Age_Of_Villagers.ForeColor = System.Drawing.Color.CadetBlue;
            this.Age_Of_Villagers.Location = new System.Drawing.Point(622, 28);
            this.Age_Of_Villagers.Name = "Age_Of_Villagers";
            this.Age_Of_Villagers.Size = new System.Drawing.Size(165, 25);
            this.Age_Of_Villagers.TabIndex = 5;
            this.Age_Of_Villagers.Text = "Age of Villagers";
            // 
            // Select_Nation
            // 
            this.Select_Nation.AllowDrop = true;
            this.Select_Nation.BackColor = System.Drawing.SystemColors.Menu;
            this.Select_Nation.FormattingEnabled = true;
            this.Select_Nation.Items.AddRange(new object[] {
            "Arab Bedouin",
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.Select_Nation.Location = new System.Drawing.Point(638, 117);
            this.Select_Nation.Name = "Select_Nation";
            this.Select_Nation.Size = new System.Drawing.Size(132, 28);
            this.Select_Nation.TabIndex = 6;
            this.Select_Nation.Tag = "";
            this.Select_Nation.Text = "Select Nation";
            this.Select_Nation.SelectedIndexChanged += new System.EventHandler(this.Select_Nation_SelectedIndexChanged);
            // 
            // Tree
            // 
            this.Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Tree.Location = new System.Drawing.Point(627, 180);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(79, 31);
            this.Tree.TabIndex = 7;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // House
            // 
            this.House.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.House.Location = new System.Drawing.Point(712, 180);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(76, 31);
            this.House.TabIndex = 8;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // Water_Source
            // 
            this.Water_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Water_Source.Location = new System.Drawing.Point(638, 217);
            this.Water_Source.Name = "Water_Source";
            this.Water_Source.Size = new System.Drawing.Size(132, 37);
            this.Water_Source.TabIndex = 9;
            this.Water_Source.Text = "Water Source";
            this.Water_Source.UseVisualStyleBackColor = true;
            this.Water_Source.Click += new System.EventHandler(this.Water_Source_Click);
            // 
            // CreateNewVillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.Water_Source);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Select_Nation);
            this.Controls.Add(this.Age_Of_Villagers);
            this.Controls.Add(this.Village_Name);
            this.Controls.Add(this.Draw_Panel);
            this.Controls.Add(this.Save_Village);
            this.Controls.Add(this.New_Village);
            this.Controls.Add(this.Open_Village);
            this.Name = "CreateNewVillage";
            this.Text = "Age Of Villagers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button Open_Village;
        private System.Windows.Forms.Button Save_Village;
        private System.Windows.Forms.Panel Draw_Panel;
        private System.Windows.Forms.TextBox Village_Name;
        private System.Windows.Forms.Label Age_Of_Villagers;
        private System.Windows.Forms.ComboBox Select_Nation;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button Water_Source;
        private System.Windows.Forms.Button New_Village;
    }
}