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
            this.NewVbutton = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.House = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.Button();
            this.WaterSource = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.VillageNameBox = new System.Windows.Forms.TextBox();
            this.NationList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NationList);
            this.panel1.Controls.Add(this.VillageNameBox);
            this.panel1.Controls.Add(this.OpenVillage);
            this.panel1.Controls.Add(this.SaveVillage);
            this.panel1.Controls.Add(this.WaterSource);
            this.panel1.Controls.Add(this.Tree);
            this.panel1.Controls.Add(this.House);
            this.panel1.Controls.Add(this.NewVbutton);
            this.panel1.Controls.Add(this.gameTitle);
            this.panel1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.panel1.Location = new System.Drawing.Point(378, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 400);
            this.panel1.TabIndex = 0;
            // 
            // NewVbutton
            // 
            this.NewVbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewVbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVbutton.Location = new System.Drawing.Point(29, 308);
            this.NewVbutton.Name = "NewVbutton";
            this.NewVbutton.Size = new System.Drawing.Size(130, 23);
            this.NewVbutton.TabIndex = 7;
            this.NewVbutton.Text = "NEW VILLAGE";
            this.NewVbutton.UseVisualStyleBackColor = false;
            this.NewVbutton.Click += new System.EventHandler(this.NewVbutton_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(24, 19);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(172, 27);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "Age of Villagers";
            this.gameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // House
            // 
            this.House.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.House.Location = new System.Drawing.Point(41, 79);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(103, 23);
            this.House.TabIndex = 11;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = false;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // Tree
            // 
            this.Tree.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tree.Location = new System.Drawing.Point(41, 108);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(103, 23);
            this.Tree.TabIndex = 12;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = false;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // WaterSource
            // 
            this.WaterSource.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WaterSource.Location = new System.Drawing.Point(41, 137);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(103, 23);
            this.WaterSource.TabIndex = 13;
            this.WaterSource.Text = "WaterSource";
            this.WaterSource.UseVisualStyleBackColor = false;
            this.WaterSource.Click += new System.EventHandler(this.WaterSource_Click);
            // 
            // SaveVillage
            // 
            this.SaveVillage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveVillage.Location = new System.Drawing.Point(29, 270);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(130, 23);
            this.SaveVillage.TabIndex = 14;
            this.SaveVillage.Text = "SAVE VILLAGE";
            this.SaveVillage.UseVisualStyleBackColor = false;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenVillage.Location = new System.Drawing.Point(29, 351);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(130, 23);
            this.OpenVillage.TabIndex = 15;
            this.OpenVillage.Text = "OPEN VILLAGE";
            this.OpenVillage.UseVisualStyleBackColor = false;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // VillageNameBox
            // 
            this.VillageNameBox.Location = new System.Drawing.Point(44, 49);
            this.VillageNameBox.Name = "VillageNameBox";
            this.VillageNameBox.Size = new System.Drawing.Size(100, 22);
            this.VillageNameBox.TabIndex = 16;
            this.VillageNameBox.TextChanged += new System.EventHandler(this.VillageNameBox_TextChanged);
            // 
            // NationList
            // 
            this.NationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationList.FormattingEnabled = true;
            this.NationList.ItemHeight = 16;
            this.NationList.Location = new System.Drawing.Point(22, 177);
            this.NationList.Name = "NationList";
            this.NationList.Size = new System.Drawing.Size(103, 68);
            this.NationList.TabIndex = 17;
            this.NationList.SelectedIndexChanged += new System.EventHandler(this.NationList_SelectedIndexChanged);
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
        private System.Windows.Forms.Button NewVbutton;
        private System.Windows.Forms.Button WaterSource;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.ListBox NationList;
        private System.Windows.Forms.TextBox VillageNameBox;
    }
}