namespace empty_project
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
            this.SaveVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.WaterSource = new System.Windows.Forms.Button();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.NationBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(659, 332);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(91, 23);
            this.SaveVillage.TabIndex = 0;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // NewVillage
            // 
            this.NewVillage.Location = new System.Drawing.Point(606, 377);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(91, 23);
            this.NewVillage.TabIndex = 2;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Location = new System.Drawing.Point(703, 377);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(85, 23);
            this.OpenVillage.TabIndex = 3;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(659, 177);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(83, 23);
            this.Tree.TabIndex = 4;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(606, 224);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(91, 23);
            this.House.TabIndex = 5;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // WaterSource
            // 
            this.WaterSource.Location = new System.Drawing.Point(703, 224);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(85, 23);
            this.WaterSource.TabIndex = 6;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.Click += new System.EventHandler(this.WaterSource_Click);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawingPanel.TabIndex = 7;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseClick);
            // 
            // NationBox
            // 
            this.NationBox.FormattingEnabled = true;
            this.NationBox.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationBox.Location = new System.Drawing.Point(638, 68);
            this.NationBox.Name = "NationBox";
            this.NationBox.Size = new System.Drawing.Size(121, 23);
            this.NationBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NationBox);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.WaterSource);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.OpenVillage);
            this.Controls.Add(this.NewVillage);
            this.Controls.Add(this.SaveVillage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button WaterSource;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.ComboBox NationBox;
    }
}

