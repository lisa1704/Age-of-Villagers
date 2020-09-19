﻿namespace AgeOfVillagers
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
            this.UserVillageName = new System.Windows.Forms.Label();
            this.NationList = new System.Windows.Forms.ComboBox();
            this.VillageNameBox = new System.Windows.Forms.TextBox();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.WaterSource = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.NewVbutton = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UserVillageName);
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
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 400);
            this.panel1.TabIndex = 0;
            // 
            // UserVillageName
            // 
            this.UserVillageName.AutoSize = true;
            this.UserVillageName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserVillageName.Location = new System.Drawing.Point(56, 99);
            this.UserVillageName.Name = "UserVillageName";
            this.UserVillageName.Size = new System.Drawing.Size(134, 20);
            this.UserVillageName.TabIndex = 18;
            this.UserVillageName.Text = "UserVillageName";
            this.UserVillageName.Click += new System.EventHandler(this.UserVillageName_Click);
            // 
            // NationList
            // 
            this.NationList.FormattingEnabled = true;
            this.NationList.Items.AddRange(new object[] {
            "BangladeshiFarmers",
            "ArabBedouin",
            "EgyptianKings",
            "InuitHunters"});
            this.NationList.Location = new System.Drawing.Point(56, 142);
            this.NationList.Name = "NationList";
            this.NationList.Size = new System.Drawing.Size(121, 24);
            this.NationList.TabIndex = 17;
            this.NationList.Text = "Nation List";
            this.NationList.SelectedIndexChanged += new System.EventHandler(this.NationList_SelectedIndexChanged_1);
            // 
            // VillageNameBox
            // 
            this.VillageNameBox.Location = new System.Drawing.Point(59, 60);
            this.VillageNameBox.Name = "VillageNameBox";
            this.VillageNameBox.Size = new System.Drawing.Size(100, 22);
            this.VillageNameBox.TabIndex = 16;
            this.VillageNameBox.TextChanged += new System.EventHandler(this.VillageNameBox_TextChanged);
            // 
            // OpenVillage
            // 
            this.OpenVillage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenVillage.Location = new System.Drawing.Point(29, 351);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(148, 32);
            this.OpenVillage.TabIndex = 15;
            this.OpenVillage.Text = "OPEN VILLAGE";
            this.OpenVillage.UseVisualStyleBackColor = false;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // SaveVillage
            // 
            this.SaveVillage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveVillage.Location = new System.Drawing.Point(29, 270);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(148, 32);
            this.SaveVillage.TabIndex = 14;
            this.SaveVillage.Text = "SAVE VILLAGE";
            this.SaveVillage.UseVisualStyleBackColor = false;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // WaterSource
            // 
            this.WaterSource.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WaterSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WaterSource.Location = new System.Drawing.Point(125, 231);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(103, 23);
            this.WaterSource.TabIndex = 13;
            this.WaterSource.Text = "WaterSource";
            this.WaterSource.UseVisualStyleBackColor = false;
            this.WaterSource.Click += new System.EventHandler(this.WaterSource_Click);
            // 
            // Tree
            // 
            this.Tree.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tree.Location = new System.Drawing.Point(16, 231);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(103, 23);
            this.Tree.TabIndex = 12;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = false;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // House
            // 
            this.House.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.House.Location = new System.Drawing.Point(59, 192);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(103, 23);
            this.House.TabIndex = 11;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = false;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // NewVbutton
            // 
            this.NewVbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewVbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVbutton.Location = new System.Drawing.Point(29, 308);
            this.NewVbutton.Name = "NewVbutton";
            this.NewVbutton.Size = new System.Drawing.Size(148, 26);
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
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DrawPanel.Location = new System.Drawing.Point(11, 0);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawPanel.TabIndex = 1;
            this.DrawPanel.BackColorChanged += new System.EventHandler(this.NationList_SelectedIndexChanged_1);
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.draw_panelMouseClick);
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(841, 396);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.TextBox VillageNameBox;
        private System.Windows.Forms.ComboBox NationList;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Label UserVillageName;
    }
}