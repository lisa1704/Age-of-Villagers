namespace Age_of_Villagers
{
    partial class VillageWindow
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
            this.VillageDrawing = new System.Windows.Forms.Panel();
            this.NewVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.GameLabel = new System.Windows.Forms.Label();
            this.VillageNameText = new System.Windows.Forms.TextBox();
            this.HouseRB = new System.Windows.Forms.RadioButton();
            this.TreeRB = new System.Windows.Forms.RadioButton();
            this.WaterSourceRB = new System.Windows.Forms.RadioButton();
            this.NationNameCombo = new System.Windows.Forms.ComboBox();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // VillageDrawing
            // 
            this.VillageDrawing.AccessibleName = "VillageDrawing";
            this.VillageDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageDrawing.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VillageDrawing.Location = new System.Drawing.Point(2, 2);
            this.VillageDrawing.Margin = new System.Windows.Forms.Padding(0);
            this.VillageDrawing.Name = "VillageDrawing";
            this.VillageDrawing.Size = new System.Drawing.Size(600, 400);
            this.VillageDrawing.TabIndex = 0;
            this.VillageDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.VillageDrawing_Paint);
            this.VillageDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VillageDrawing_MouseDown);
            this.VillageDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VillageDrawing_MouseUp);
            // 
            // NewVillage
            // 
            this.NewVillage.AccessibleName = "NewVillage";
            this.NewVillage.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewVillage.Location = new System.Drawing.Point(31, 357);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(89, 28);
            this.NewVillage.TabIndex = 0;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillageButton_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenVillage.Location = new System.Drawing.Point(136, 357);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(89, 28);
            this.OpenVillage.TabIndex = 0;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillageButton_Click);
            // 
            // SaveVillage
            // 
            this.SaveVillage.AccessibleName = "SaveVillage";
            this.SaveVillage.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveVillage.Location = new System.Drawing.Point(84, 323);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(89, 28);
            this.SaveVillage.TabIndex = 0;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillageButton_Click);
            // 
            // GameLabel
            // 
            this.GameLabel.AccessibleName = "GameLabel";
            this.GameLabel.AutoSize = true;
            this.GameLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameLabel.Location = new System.Drawing.Point(51, 19);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(153, 20);
            this.GameLabel.TabIndex = 1;
            this.GameLabel.Text = "Age of Villagers";
            this.GameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameLabel.Click += new System.EventHandler(this.GameLabel_Click);
            // 
            // VillageNameText
            // 
            this.VillageNameText.AccessibleName = "VillageNameText";
            this.VillageNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageNameText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VillageNameText.Location = new System.Drawing.Point(31, 63);
            this.VillageNameText.Name = "VillageNameText";
            this.VillageNameText.Size = new System.Drawing.Size(194, 24);
            this.VillageNameText.TabIndex = 2;
            this.VillageNameText.Text = "Village Name";
            this.VillageNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VillageNameText.TextChanged += new System.EventHandler(this.VillageNameText_TextChanged);
            // 
            // HouseRB
            // 
            this.HouseRB.AccessibleName = "HouseRB";
            this.HouseRB.AutoSize = true;
            this.HouseRB.Location = new System.Drawing.Point(66, 199);
            this.HouseRB.Name = "HouseRB";
            this.HouseRB.Size = new System.Drawing.Size(69, 21);
            this.HouseRB.TabIndex = 4;
            this.HouseRB.TabStop = true;
            this.HouseRB.Text = "House";
            this.HouseRB.UseVisualStyleBackColor = true;
            this.HouseRB.CheckedChanged += new System.EventHandler(this.HouseRB_CheckedChanged);
            // 
            // TreeRB
            // 
            this.TreeRB.AccessibleName = "TreeRB";
            this.TreeRB.AutoSize = true;
            this.TreeRB.Location = new System.Drawing.Point(66, 235);
            this.TreeRB.Name = "TreeRB";
            this.TreeRB.Size = new System.Drawing.Size(61, 21);
            this.TreeRB.TabIndex = 4;
            this.TreeRB.TabStop = true;
            this.TreeRB.Text = "Tree";
            this.TreeRB.UseVisualStyleBackColor = true;
            this.TreeRB.CheckedChanged += new System.EventHandler(this.TreeRB_CheckedChanged);
            // 
            // WaterSourceRB
            // 
            this.WaterSourceRB.AccessibleName = "WaterSourceRB";
            this.WaterSourceRB.AutoSize = true;
            this.WaterSourceRB.Location = new System.Drawing.Point(66, 273);
            this.WaterSourceRB.Name = "WaterSourceRB";
            this.WaterSourceRB.Size = new System.Drawing.Size(125, 21);
            this.WaterSourceRB.TabIndex = 4;
            this.WaterSourceRB.TabStop = true;
            this.WaterSourceRB.Text = "Water Source";
            this.WaterSourceRB.UseVisualStyleBackColor = true;
            this.WaterSourceRB.CheckedChanged += new System.EventHandler(this.WaterSourceRB_CheckedChanged);
            // 
            // NationNameCombo
            // 
            this.NationNameCombo.AccessibleName = "NationNameCombo";
            this.NationNameCombo.FormattingEnabled = true;
            this.NationNameCombo.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationNameCombo.Location = new System.Drawing.Point(31, 103);
            this.NationNameCombo.Name = "NationNameCombo";
            this.NationNameCombo.Size = new System.Drawing.Size(194, 25);
            this.NationNameCombo.TabIndex = 5;
            this.NationNameCombo.Text = "Select Nation";
            this.NationNameCombo.SelectedIndexChanged += new System.EventHandler(this.NationNameCombo_SelectedIndexChanged);
            // 
            // MenuBar
            // 
            this.MenuBar.AccessibleName = "MenuBar";
            this.MenuBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuBar.Controls.Add(this.NationNameCombo);
            this.MenuBar.Controls.Add(this.WaterSourceRB);
            this.MenuBar.Controls.Add(this.TreeRB);
            this.MenuBar.Controls.Add(this.HouseRB);
            this.MenuBar.Controls.Add(this.VillageNameText);
            this.MenuBar.Controls.Add(this.GameLabel);
            this.MenuBar.Controls.Add(this.SaveVillage);
            this.MenuBar.Controls.Add(this.OpenVillage);
            this.MenuBar.Controls.Add(this.NewVillage);
            this.MenuBar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuBar.Location = new System.Drawing.Point(602, 2);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(250, 400);
            this.MenuBar.TabIndex = 1;
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 405);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.VillageDrawing);
            this.Name = "VillageWindow";
            this.Text = "Age of Villagers";
            this.Load += new System.EventHandler(this.VillageWindow_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VillageDrawing;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.RadioButton HouseRB;
        private System.Windows.Forms.RadioButton TreeRB;
        private System.Windows.Forms.RadioButton WaterSourceRB;
        private System.Windows.Forms.Panel MenuBar;
        public System.Windows.Forms.TextBox VillageNameText;
        public System.Windows.Forms.ComboBox NationNameCombo;
    }
}