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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.HouseButton = new System.Windows.Forms.Button();
            this.TreeButton = new System.Windows.Forms.Button();
            this.WaterButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.WaterButton);
            this.panel2.Controls.Add(this.TreeButton);
            this.panel2.Controls.Add(this.HouseButton);
            this.panel2.Controls.Add(this.OpenButton);
            this.panel2.Controls.Add(this.NewButton);
            this.panel2.Controls.Add(this.SaveButton2);
            this.panel2.Location = new System.Drawing.Point(545, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 402);
            this.panel2.TabIndex = 1;
            // 
            // SaveButton2
            // 
            this.SaveButton2.Location = new System.Drawing.Point(87, 259);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(143, 40);
            this.SaveButton2.TabIndex = 2;
            this.SaveButton2.Text = "SaveVillage";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(87, 305);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(143, 40);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "New Village";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(87, 351);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(143, 40);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Open Village";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenVIllage_Click);
            // 
            // HouseButton
            // 
            this.HouseButton.Location = new System.Drawing.Point(128, 152);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(67, 31);
            this.HouseButton.TabIndex = 5;
            this.HouseButton.Text = "House";
            this.HouseButton.UseVisualStyleBackColor = true;
            this.HouseButton.Click += new System.EventHandler(this.House_Click);
            // 
            // TreeButton
            // 
            this.TreeButton.Location = new System.Drawing.Point(40, 152);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(62, 31);
            this.TreeButton.TabIndex = 6;
            this.TreeButton.Text = "Tree";
            this.TreeButton.UseVisualStyleBackColor = true;
            this.TreeButton.Click += new System.EventHandler(this.tree_Click);
            // 
            // WaterButton
            // 
            this.WaterButton.Location = new System.Drawing.Point(219, 152);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(73, 31);
            this.WaterButton.TabIndex = 7;
            this.WaterButton.Text = "Water";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.Water_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.textBox1.Location = new System.Drawing.Point(87, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 34);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Enter Village Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Text = "VillageBoard";
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
    }
}

