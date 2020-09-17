﻿using System;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    public partial class VillageWindow
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
            System.Windows.Forms.Label CountryName;
            this.drawingSpace = new System.Windows.Forms.Panel();
            this.titleOfGame = new System.Windows.Forms.Label();
            this.saveVillage_Button = new System.Windows.Forms.Button();
            this.newVillage_Button = new System.Windows.Forms.Button();
            this.openVillage_Button = new System.Windows.Forms.Button();
            this.treeRadioButton = new System.Windows.Forms.RadioButton();
            this.houseRadioButton = new System.Windows.Forms.RadioButton();
            this.waterRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            CountryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawingSpace
            // 
            this.drawingSpace.BackColor = System.Drawing.Color.White;
            this.drawingSpace.Location = new System.Drawing.Point(12, 45);
            this.drawingSpace.Name = "drawingSpace";
            this.drawingSpace.Size = new System.Drawing.Size(600, 400);
            this.drawingSpace.TabIndex = 0;
            this.drawingSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingSpace_Paint);
            // 
            // titleOfGame
            // 
            this.titleOfGame.AutoSize = true;
            this.titleOfGame.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleOfGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleOfGame.Location = new System.Drawing.Point(649, 28);
            this.titleOfGame.Name = "titleOfGame";
            this.titleOfGame.Size = new System.Drawing.Size(321, 54);
            this.titleOfGame.TabIndex = 1;
            this.titleOfGame.Text = "Age of Villagers";
            // 
            // saveVillage_Button
            // 
            this.saveVillage_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.saveVillage_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveVillage_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveVillage_Button.Location = new System.Drawing.Point(757, 363);
            this.saveVillage_Button.Name = "saveVillage_Button";
            this.saveVillage_Button.Size = new System.Drawing.Size(103, 44);
            this.saveVillage_Button.TabIndex = 2;
            this.saveVillage_Button.Text = "Save Village";
            this.saveVillage_Button.UseVisualStyleBackColor = false;
            this.saveVillage_Button.Click += new System.EventHandler(this.saveVillage_Button_Click);
            // 
            // newVillage_Button
            // 
            this.newVillage_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newVillage_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newVillage_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newVillage_Button.Location = new System.Drawing.Point(649, 425);
            this.newVillage_Button.Name = "newVillage_Button";
            this.newVillage_Button.Size = new System.Drawing.Size(103, 44);
            this.newVillage_Button.TabIndex = 2;
            this.newVillage_Button.Text = "New Village";
            this.newVillage_Button.UseVisualStyleBackColor = false;
            this.newVillage_Button.Click += new System.EventHandler(this.newVillage_Button_Click);
            // 
            // openVillage_Button
            // 
            this.openVillage_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.openVillage_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openVillage_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openVillage_Button.Location = new System.Drawing.Point(867, 425);
            this.openVillage_Button.Name = "openVillage_Button";
            this.openVillage_Button.Size = new System.Drawing.Size(103, 44);
            this.openVillage_Button.TabIndex = 2;
            this.openVillage_Button.Text = "Open Village";
            this.openVillage_Button.UseVisualStyleBackColor = false;
            this.openVillage_Button.Click += new System.EventHandler(this.openVillage_Button_Click);
            // 
            // treeRadioButton
            // 
            this.treeRadioButton.AutoSize = true;
            this.treeRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeRadioButton.Location = new System.Drawing.Point(687, 238);
            this.treeRadioButton.Name = "treeRadioButton";
            this.treeRadioButton.Size = new System.Drawing.Size(51, 21);
            this.treeRadioButton.TabIndex = 3;
            this.treeRadioButton.TabStop = true;
            this.treeRadioButton.Text = "Tree";
            this.treeRadioButton.UseVisualStyleBackColor = true;
            this.treeRadioButton.CheckedChanged += new System.EventHandler(this.treeRadioButton_Checked);
            // 
            // houseRadioButton
            // 
            this.houseRadioButton.AutoSize = true;
            this.houseRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.houseRadioButton.Location = new System.Drawing.Point(687, 265);
            this.houseRadioButton.Name = "houseRadioButton";
            this.houseRadioButton.Size = new System.Drawing.Size(65, 21);
            this.houseRadioButton.TabIndex = 3;
            this.houseRadioButton.TabStop = true;
            this.houseRadioButton.Text = "House";
            this.houseRadioButton.UseVisualStyleBackColor = true;
            this.houseRadioButton.Click += new System.EventHandler(this.waterRadioButton_Checked);
            // 
            // waterRadioButton
            // 
            this.waterRadioButton.AutoSize = true;
            this.waterRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waterRadioButton.Location = new System.Drawing.Point(687, 292);
            this.waterRadioButton.Name = "waterRadioButton";
            this.waterRadioButton.Size = new System.Drawing.Size(107, 21);
            this.waterRadioButton.TabIndex = 3;
            this.waterRadioButton.TabStop = true;
            this.waterRadioButton.Text = "Water Source";
            this.waterRadioButton.UseVisualStyleBackColor = true;
            // 
            // CountryName
            // 
            CountryName.AutoSize = true;
            CountryName.Font = new System.Drawing.Font("Siyam Rupali", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CountryName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            CountryName.Location = new System.Drawing.Point(719, 185);
            CountryName.Name = "CountryName";
            CountryName.Size = new System.Drawing.Size(179, 25);
            CountryName.TabIndex = 5;
            CountryName.Text = "Bangladeshi Farmers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Siyam Rupali", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(757, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Katakhali";
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(CountryName);
            this.Controls.Add(this.waterRadioButton);
            this.Controls.Add(this.houseRadioButton);
            this.Controls.Add(this.treeRadioButton);
            this.Controls.Add(this.openVillage_Button);
            this.Controls.Add(this.newVillage_Button);
            this.Controls.Add(this.saveVillage_Button);
            this.Controls.Add(this.titleOfGame);
            this.Controls.Add(this.drawingSpace);
            this.Name = "VillageWindow";
            this.Text = "Age of Villagers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        public System.Windows.Forms.Panel drawingSpace;
        private System.Windows.Forms.Label titleOfGame;
        private System.Windows.Forms.Button saveVillage_Button;
        private System.Windows.Forms.Button newVillage_Button;
        private System.Windows.Forms.Button openVillage_Button;
        private System.Windows.Forms.RadioButton treeRadioButton;
        private System.Windows.Forms.RadioButton houseRadioButton;
        private System.Windows.Forms.RadioButton waterRadioButton;
        private Label CountryName;
        private Label label2;
    }
}

