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
            this.MenuBar = new System.Windows.Forms.Panel();
            this.NationList = new System.Windows.Forms.ListBox();
            this.VillageText = new System.Windows.Forms.TextBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.WaterSource = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // VillageDrawing
            // 
            this.VillageDrawing.AccessibleName = "VillageDrawing";
            this.VillageDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageDrawing.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VillageDrawing.Location = new System.Drawing.Point(1, 1);
            this.VillageDrawing.Margin = new System.Windows.Forms.Padding(0);
            this.VillageDrawing.Name = "VillageDrawing";
            this.VillageDrawing.Size = new System.Drawing.Size(368, 398);
            this.VillageDrawing.TabIndex = 0;
            this.VillageDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.VillageDrawing_Paint);
            // 
            // MenuBar
            // 
            this.MenuBar.AccessibleName = "MenuBar";
            this.MenuBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuBar.Controls.Add(this.NationList);
            this.MenuBar.Controls.Add(this.VillageText);
            this.MenuBar.Controls.Add(this.GameLabel);
            this.MenuBar.Controls.Add(this.SaveVillage);
            this.MenuBar.Controls.Add(this.OpenVillage);
            this.MenuBar.Controls.Add(this.NewVillage);
            this.MenuBar.Controls.Add(this.WaterSource);
            this.MenuBar.Controls.Add(this.House);
            this.MenuBar.Controls.Add(this.Tree);
            this.MenuBar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuBar.Location = new System.Drawing.Point(369, 1);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(228, 398);
            this.MenuBar.TabIndex = 1;
            // 
            // NationList
            // 
            this.NationList.AccessibleName = "NationList";
            this.NationList.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NationList.FormattingEnabled = true;
            this.NationList.ItemHeight = 12;
            this.NationList.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Arab Bedouin",
            "Inuit Hunters"});
            this.NationList.Location = new System.Drawing.Point(50, 109);
            this.NationList.Name = "NationList";
            this.NationList.Size = new System.Drawing.Size(125, 52);
            this.NationList.TabIndex = 3;
            // 
            // VillageText
            // 
            this.VillageText.AccessibleName = "VillageText";
            this.VillageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageText.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VillageText.Location = new System.Drawing.Point(50, 67);
            this.VillageText.Name = "VillageText";
            this.VillageText.Size = new System.Drawing.Size(125, 19);
            this.VillageText.TabIndex = 2;
            this.VillageText.Text = "Village Name";
            this.VillageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameLabel
            // 
            this.GameLabel.AccessibleName = "GameLabel";
            this.GameLabel.AutoSize = true;
            this.GameLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameLabel.Location = new System.Drawing.Point(43, 20);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(136, 17);
            this.GameLabel.TabIndex = 1;
            this.GameLabel.Text = "Age of Villagers";
            this.GameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SaveVillage
            // 
            this.SaveVillage.AccessibleName = "SaveVillage";
            this.SaveVillage.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveVillage.Location = new System.Drawing.Point(66, 324);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(89, 28);
            this.SaveVillage.TabIndex = 0;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.button6_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenVillage.Location = new System.Drawing.Point(118, 358);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(89, 28);
            this.OpenVillage.TabIndex = 0;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.button5_Click);
            // 
            // NewVillage
            // 
            this.NewVillage.AccessibleName = "NewVillage";
            this.NewVillage.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewVillage.Location = new System.Drawing.Point(13, 358);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(89, 28);
            this.NewVillage.TabIndex = 0;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.button4_Click);
            // 
            // WaterSource
            // 
            this.WaterSource.AccessibleName = "WaterSource";
            this.WaterSource.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WaterSource.Location = new System.Drawing.Point(66, 245);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(89, 28);
            this.WaterSource.TabIndex = 0;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.Click += new System.EventHandler(this.button3_Click);
            // 
            // House
            // 
            this.House.AccessibleName = "House";
            this.House.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.House.Location = new System.Drawing.Point(118, 211);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(89, 28);
            this.House.TabIndex = 0;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tree
            // 
            this.Tree.AccessibleName = "Tree";
            this.Tree.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tree.Location = new System.Drawing.Point(13, 211);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(89, 28);
            this.Tree.TabIndex = 0;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.button1_Click);
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600,400);
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
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button WaterSource;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.TextBox VillageText;
        private System.Windows.Forms.ListBox NationList;
    }
}