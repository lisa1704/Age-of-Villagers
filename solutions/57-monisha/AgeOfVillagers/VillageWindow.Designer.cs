namespace AgeOfVillagers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.WaterSource = new System.Windows.Forms.RadioButton();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.House = new System.Windows.Forms.RadioButton();
            this.NewVbutton = new System.Windows.Forms.Button();
            this.OpenVbutton = new System.Windows.Forms.Button();
            this.SAVEbutton = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.WaterSource);
            this.panel1.Controls.Add(this.Tree);
            this.panel1.Controls.Add(this.House);
            this.panel1.Controls.Add(this.NewVbutton);
            this.panel1.Controls.Add(this.OpenVbutton);
            this.panel1.Controls.Add(this.SAVEbutton);
            this.panel1.Controls.Add(this.gameTitle);
            this.panel1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.panel1.Location = new System.Drawing.Point(378, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 400);
            this.panel1.TabIndex = 0;
            // 
            // WaterSource
            // 
            this.WaterSource.AutoSize = true;
            this.WaterSource.Location = new System.Drawing.Point(41, 158);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(116, 21);
            this.WaterSource.TabIndex = 10;
            this.WaterSource.TabStop = true;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            // 
            // Tree
            // 
            this.Tree.AutoSize = true;
            this.Tree.Location = new System.Drawing.Point(41, 130);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(59, 21);
            this.Tree.TabIndex = 9;
            this.Tree.TabStop = true;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            // 
            // House
            // 
            this.House.AutoSize = true;
            this.House.Location = new System.Drawing.Point(41, 102);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(70, 21);
            this.House.TabIndex = 8;
            this.House.TabStop = true;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // NewVbutton
            // 
            this.NewVbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewVbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVbutton.Location = new System.Drawing.Point(41, 290);
            this.NewVbutton.Name = "NewVbutton";
            this.NewVbutton.Size = new System.Drawing.Size(130, 23);
            this.NewVbutton.TabIndex = 7;
            this.NewVbutton.Text = "NEW VILLAGE";
            this.NewVbutton.UseVisualStyleBackColor = false;
            // 
            // OpenVbutton
            // 
            this.OpenVbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenVbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenVbutton.Location = new System.Drawing.Point(41, 328);
            this.OpenVbutton.Name = "OpenVbutton";
            this.OpenVbutton.Size = new System.Drawing.Size(130, 23);
            this.OpenVbutton.TabIndex = 6;
            this.OpenVbutton.Text = "OPEN VILLAGE";
            this.OpenVbutton.UseVisualStyleBackColor = false;
            // 
            // SAVEbutton
            // 
            this.SAVEbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SAVEbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SAVEbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SAVEbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVEbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SAVEbutton.Location = new System.Drawing.Point(41, 259);
            this.SAVEbutton.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.SAVEbutton.Name = "SAVEbutton";
            this.SAVEbutton.Size = new System.Drawing.Size(130, 23);
            this.SAVEbutton.TabIndex = 5;
            this.SAVEbutton.Text = "SAVE VILLAGE";
            this.SAVEbutton.UseVisualStyleBackColor = false;
            this.SAVEbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(36, 38);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(172, 27);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "Age of Villagers";
            this.gameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VillageWindow";
            this.RightToLeftLayout = true;
            this.Text = "Age Of Villagers";
            this.Load += new System.EventHandler(this.VillageWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Button SAVEbutton;
        private System.Windows.Forms.Button OpenVbutton;
        private System.Windows.Forms.Button NewVbutton;
        private System.Windows.Forms.RadioButton House;
        private System.Windows.Forms.RadioButton Tree;
        private System.Windows.Forms.RadioButton WaterSource;
    }
}