using Age_of_Villagers.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    partial class VillageEditorWindow : Form
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
            this.VillageEditorPanel = new System.Windows.Forms.Panel();
            this.GameTitle = new System.Windows.Forms.Label();
            this.VillageTitle = new System.Windows.Forms.Label();
            this.NationTitle = new System.Windows.Forms.Label();
            this.TreeButton = new System.Windows.Forms.Button();
            this.HouseButton = new System.Windows.Forms.Button();
            this.WaterSourceButton = new System.Windows.Forms.Button();
            this.NewVillageButton = new System.Windows.Forms.Button();
            this.OpenVillageButton = new System.Windows.Forms.Button();
            this.SaveVillageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VillageEditorPanel
            // 
            this.VillageEditorPanel.Location = new System.Drawing.Point(12, 12);
            this.VillageEditorPanel.Name = "VillageEditorPanel";
            this.VillageEditorPanel.Size = new System.Drawing.Size(600, 400);
            this.VillageEditorPanel.TabIndex = 1;
            this.VillageEditorPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VillageEditorPanel_Click);
            this.VillageEditorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.VillageEditorPanel_Paint);
            
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameTitle.Location = new System.Drawing.Point(645, 32);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(207, 37);
            this.GameTitle.TabIndex = 2;
            this.GameTitle.Text = "Age of Villagers";
            // 
            // VillageTitle
            // 
            this.VillageTitle.AutoSize = true;
            this.VillageTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VillageTitle.Location = new System.Drawing.Point(691, 88);
            this.VillageTitle.Name = "VillageTitle";
            this.VillageTitle.Size = new System.Drawing.Size(104, 23);
            this.VillageTitle.TabIndex = 3;
            this.VillageTitle.Text = "Add Village";
            this.VillageTitle.Click += new System.EventHandler(this.VillageTitle_Click);
            // 
            // NationTitle
            // 
            this.NationTitle.AutoSize = true;
            this.NationTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NationTitle.Location = new System.Drawing.Point(691, 128);
            this.NationTitle.Name = "NationTitle";
            this.NationTitle.Size = new System.Drawing.Size(103, 23);
            this.NationTitle.TabIndex = 4;
            this.NationTitle.Text = "Add Nation";
            this.NationTitle.Click += new System.EventHandler(this.NationTitle_Click);
            // 
            // TreeButton
            // 
            this.TreeButton.Location = new System.Drawing.Point(645, 188);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(106, 29);
            this.TreeButton.TabIndex = 5;
            this.TreeButton.Text = "Tree";
            this.TreeButton.UseVisualStyleBackColor = true;
            this.TreeButton.Click += new System.EventHandler(this.TreeButton_Click);
            // 
            // HouseButton
            // 
            this.HouseButton.Location = new System.Drawing.Point(757, 188);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(113, 29);
            this.HouseButton.TabIndex = 6;
            this.HouseButton.Text = "House";
            this.HouseButton.UseVisualStyleBackColor = true;
            this.HouseButton.Click += new System.EventHandler(this.HouseButton_Click);
            // 
            // WaterSourceButton
            // 
            this.WaterSourceButton.Location = new System.Drawing.Point(691, 223);
            this.WaterSourceButton.Name = "WaterSourceButton";
            this.WaterSourceButton.Size = new System.Drawing.Size(122, 29);
            this.WaterSourceButton.TabIndex = 7;
            this.WaterSourceButton.Text = "Water Source";
            this.WaterSourceButton.UseVisualStyleBackColor = true;
            this.WaterSourceButton.Click += new System.EventHandler(this.WaterSourceButton_Click);
            // 
            // NewVillageButton
            // 
            this.NewVillageButton.Location = new System.Drawing.Point(645, 371);
            this.NewVillageButton.Name = "NewVillageButton";
            this.NewVillageButton.Size = new System.Drawing.Size(106, 29);
            this.NewVillageButton.TabIndex = 8;
            this.NewVillageButton.Text = "New Village";
            this.NewVillageButton.UseVisualStyleBackColor = true;
            this.NewVillageButton.Click += new System.EventHandler(this.NewVillageButton_Click);
            // 
            // OpenVillageButton
            // 
            this.OpenVillageButton.Location = new System.Drawing.Point(757, 371);
            this.OpenVillageButton.Name = "OpenVillageButton";
            this.OpenVillageButton.Size = new System.Drawing.Size(113, 29);
            this.OpenVillageButton.TabIndex = 9;
            this.OpenVillageButton.Text = "Open Village";
            this.OpenVillageButton.UseVisualStyleBackColor = true;
            this.OpenVillageButton.Click += new System.EventHandler(this.OpenVillageButton_Click);
            // 
            // SaveVillageButton
            // 
            this.SaveVillageButton.Location = new System.Drawing.Point(691, 329);
            this.SaveVillageButton.Name = "SaveVillageButton";
            this.SaveVillageButton.Size = new System.Drawing.Size(122, 29);
            this.SaveVillageButton.TabIndex = 10;
            this.SaveVillageButton.Text = "Save Village";
            this.SaveVillageButton.UseVisualStyleBackColor = true;
            this.SaveVillageButton.Click += new System.EventHandler(this.SaveVillageButton_Click);
            // 
            // VillageEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 412);
            this.Controls.Add(this.SaveVillageButton);
            this.Controls.Add(this.OpenVillageButton);
            this.Controls.Add(this.NewVillageButton);
            this.Controls.Add(this.WaterSourceButton);
            this.Controls.Add(this.HouseButton);
            this.Controls.Add(this.TreeButton);
            this.Controls.Add(this.NationTitle);
            this.Controls.Add(this.VillageTitle);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.VillageEditorPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "VillageEditorWindow";
            this.Text = "Village Editor";
            this.Load += new System.EventHandler(this.VillageEditorWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       


        #endregion
        private Panel VillageEditorPanel;
        private Label GameTitle;
        private Label VillageTitle;
        private Label NationTitle;
        private Button TreeButton;
        private Button HouseButton;
        private Button WaterSourceButton;
        private Button NewVillageButton;
        private Button OpenVillageButton;
        private Button SaveVillageButton;
    }
}

 