namespace AgeOfVillagers
{
    partial class VillageActions
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.VillageNation = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WaterButton = new System.Windows.Forms.Button();
            this.TreeButton = new System.Windows.Forms.Button();
            this.HouseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 402);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.VillageNation);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.WaterButton);
            this.panel2.Controls.Add(this.TreeButton);
            this.panel2.Controls.Add(this.HouseButton);
            this.panel2.Controls.Add(this.OpenButton);
            this.panel2.Controls.Add(this.NewButton);
            this.panel2.Controls.Add(this.SaveButton2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(545, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 402);
            this.panel2.TabIndex = 1;
            this.panel2.UseWaitCursor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(49, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 36);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "AGE OF VILLAGERS";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseWaitCursor = true;
            // 
            // VillageNation
            // 
            this.VillageNation.DisplayMember = "Enter Type";
            this.VillageNation.Font = new System.Drawing.Font("Arial", 8.5F);
            this.VillageNation.FormattingEnabled = true;
            this.VillageNation.Items.AddRange(new object[] {
            "Arab Bedouin",
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.VillageNation.Location = new System.Drawing.Point(87, 111);
            this.VillageNation.Name = "VillageNation";
            this.VillageNation.Size = new System.Drawing.Size(143, 24);
            this.VillageNation.TabIndex = 9;
            this.VillageNation.Text = "Enter Nation";
            this.VillageNation.UseWaitCursor = true;
            this.VillageNation.ValueMember = "Arab Bedouin";
            this.VillageNation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.VillageNation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 8.5F);
            this.textBox1.Location = new System.Drawing.Point(87, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Enter Village Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // WaterButton
            // 
            this.WaterButton.Location = new System.Drawing.Point(219, 152);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(73, 31);
            this.WaterButton.TabIndex = 7;
            this.WaterButton.Text = "Water";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.UseWaitCursor = true;
            this.WaterButton.Click += new System.EventHandler(this.Water_Click);
            // 
            // TreeButton
            // 
            this.TreeButton.Location = new System.Drawing.Point(130, 152);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(62, 31);
            this.TreeButton.TabIndex = 6;
            this.TreeButton.Text = "Tree";
            this.TreeButton.UseVisualStyleBackColor = true;
            this.TreeButton.UseWaitCursor = true;
            this.TreeButton.Click += new System.EventHandler(this.tree_Click);
            // 
            // HouseButton
            // 
            this.HouseButton.Location = new System.Drawing.Point(37, 152);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(67, 31);
            this.HouseButton.TabIndex = 5;
            this.HouseButton.Text = "House";
            this.HouseButton.UseVisualStyleBackColor = true;
            this.HouseButton.UseWaitCursor = true;
            this.HouseButton.Click += new System.EventHandler(this.House_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(87, 351);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(143, 40);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Open Village";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.UseWaitCursor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenVIllage_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(87, 305);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(143, 40);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "New Village";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.UseWaitCursor = true;
            this.NewButton.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // SaveButton2
            // 
            this.SaveButton2.Location = new System.Drawing.Point(87, 259);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(143, 40);
            this.SaveButton2.TabIndex = 2;
            this.SaveButton2.Text = "Save Village";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.UseWaitCursor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // VillageActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F);
            this.Name = "VillageActions";
            this.Text = "g";
            this.Load += new System.EventHandler(this.VillageActions_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton2;
        private System.Windows.Forms.Button TreeButton;
        private System.Windows.Forms.Button HouseButton;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox VillageNation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

