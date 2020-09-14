﻿using System;

namespace AgeOfVillagers
{
    partial class CreateNewVillage
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
            this.AgeOfVillagers = new System.Windows.Forms.Label();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.villageName = new System.Windows.Forms.Label();
            this.nation = new System.Windows.Forms.Label();
            this.saveVillagebutton = new System.Windows.Forms.Button();
            this.newVillagebutton = new System.Windows.Forms.Button();
            this.openVillagebutton = new System.Windows.Forms.Button();
            this.treeButton = new System.Windows.Forms.RadioButton();
            this.houseButton = new System.Windows.Forms.RadioButton();
            this.waterSourceButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // AgeOfVillagers
            // 
            this.AgeOfVillagers.AutoSize = true;
            this.AgeOfVillagers.Font = new System.Drawing.Font("Product Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeOfVillagers.Location = new System.Drawing.Point(672, 18);
            this.AgeOfVillagers.Name = "AgeOfVillagers";
            this.AgeOfVillagers.Size = new System.Drawing.Size(241, 32);
            this.AgeOfVillagers.TabIndex = 0;
            this.AgeOfVillagers.Text = "AGE OF VILLAGERS";
            this.AgeOfVillagers.Click += new System.EventHandler(this.AgeOfVillagers_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.SystemColors.Window;
            this.drawingPanel.ForeColor = System.Drawing.Color.DarkCyan;
            this.drawingPanel.Location = new System.Drawing.Point(3, 0);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(600, 400);
            this.drawingPanel.TabIndex = 1;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            // 
            // villageName
            // 
            this.villageName.AutoSize = true;
            this.villageName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.villageName.Location = new System.Drawing.Point(742, 59);
            this.villageName.Name = "villageName";
            this.villageName.Size = new System.Drawing.Size(99, 30);
            this.villageName.TabIndex = 2;
            this.villageName.Text = "Katakhali";
            this.villageName.Click += new System.EventHandler(this.villageName_Click);
            // 
            // nation
            // 
            this.nation.AutoSize = true;
            this.nation.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nation.Location = new System.Drawing.Point(696, 97);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(186, 23);
            this.nation.TabIndex = 3;
            this.nation.Text = "Bangladeshi Farmers";
            this.nation.Click += new System.EventHandler(this.nation_Click);
            // 
            // saveVillagebutton
            // 
            this.saveVillagebutton.Location = new System.Drawing.Point(711, 305);
            this.saveVillagebutton.Name = "saveVillagebutton";
            this.saveVillagebutton.Size = new System.Drawing.Size(160, 30);
            this.saveVillagebutton.TabIndex = 8;
            this.saveVillagebutton.Text = "Save Village";
            this.saveVillagebutton.UseVisualStyleBackColor = true;
            this.saveVillagebutton.Click += new System.EventHandler(this.saveVillagebutton_Click);
            // 
            // newVillagebutton
            // 
            this.newVillagebutton.Location = new System.Drawing.Point(623, 341);
            this.newVillagebutton.Name = "newVillagebutton";
            this.newVillagebutton.Size = new System.Drawing.Size(160, 30);
            this.newVillagebutton.TabIndex = 9;
            this.newVillagebutton.Text = "New Village";
            this.newVillagebutton.UseVisualStyleBackColor = true;
            this.newVillagebutton.Click += new System.EventHandler(this.newVillagebutton_Click);
            // 
            // openVillagebutton
            // 
            this.openVillagebutton.Location = new System.Drawing.Point(799, 341);
            this.openVillagebutton.Name = "openVillagebutton";
            this.openVillagebutton.Size = new System.Drawing.Size(160, 30);
            this.openVillagebutton.TabIndex = 10;
            this.openVillagebutton.Text = "Open Village";
            this.openVillagebutton.UseVisualStyleBackColor = true;
            this.openVillagebutton.Click += new System.EventHandler(this.openVillagebutton_Click);
            // 
            // treeButton
            // 
            this.treeButton.AutoSize = true;
            this.treeButton.Location = new System.Drawing.Point(759, 168);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(58, 24);
            this.treeButton.TabIndex = 11;
            this.treeButton.TabStop = true;
            this.treeButton.Text = "Tree";
            this.treeButton.UseVisualStyleBackColor = true;
            this.treeButton.CheckedChanged += new System.EventHandler(this.treeButton_CheckedChanged);
            // 
            // houseButton
            // 
            this.houseButton.AutoSize = true;
            this.houseButton.Location = new System.Drawing.Point(759, 198);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(72, 24);
            this.houseButton.TabIndex = 12;
            this.houseButton.TabStop = true;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.CheckedChanged += new System.EventHandler(this.houseButton_CheckedChanged);
            // 
            // waterSourceButton
            // 
            this.waterSourceButton.AutoSize = true;
            this.waterSourceButton.Location = new System.Drawing.Point(759, 228);
            this.waterSourceButton.Name = "waterSourceButton";
            this.waterSourceButton.Size = new System.Drawing.Size(118, 24);
            this.waterSourceButton.TabIndex = 13;
            this.waterSourceButton.TabStop = true;
            this.waterSourceButton.Text = "Water Source";
            this.waterSourceButton.UseVisualStyleBackColor = true;
            this.waterSourceButton.CheckedChanged += new System.EventHandler(this.waterSourceButton_CheckedChanged);
            // 
            // CreateNewVillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.waterSourceButton);
            this.Controls.Add(this.houseButton);
            this.Controls.Add(this.treeButton);
            this.Controls.Add(this.openVillagebutton);
            this.Controls.Add(this.newVillagebutton);
            this.Controls.Add(this.saveVillagebutton);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.villageName);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.AgeOfVillagers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CreateNewVillage";
            this.Text = "Age Of Villagers";
            this.Load += new System.EventHandler(this.CreateNewVillage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label AgeOfVillagers;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Label villageName;
        private System.Windows.Forms.Label nation;
        private System.Windows.Forms.Button saveVillagebutton;
        private System.Windows.Forms.Button newVillagebutton;
        private System.Windows.Forms.Button openVillagebutton;
        private System.Windows.Forms.RadioButton treeButton;
        private System.Windows.Forms.RadioButton houseButton;
        private System.Windows.Forms.RadioButton waterSourceButton;
    }
}

