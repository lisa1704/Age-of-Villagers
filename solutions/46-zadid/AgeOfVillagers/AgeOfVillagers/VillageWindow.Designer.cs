using System;
using System.Drawing;
using System.Windows.Forms;

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
        /// 

        //private Panel drawingPanel, toolsPanel;

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenVillageButton = new System.Windows.Forms.Button();
            this.NewVillageButton = new System.Windows.Forms.Button();
            this.SaveVillageButton = new System.Windows.Forms.Button();
            this.WaterRadioButton = new System.Windows.Forms.RadioButton();
            this.HouseRadioButton = new System.Windows.Forms.RadioButton();
            this.TreeRadioButton = new System.Windows.Forms.RadioButton();
            this.NationNameText = new System.Windows.Forms.TextBox();
            this.VillageNameText = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.OpenVillageButton);
            this.panel1.Controls.Add(this.NewVillageButton);
            this.panel1.Controls.Add(this.SaveVillageButton);
            this.panel1.Controls.Add(this.WaterRadioButton);
            this.panel1.Controls.Add(this.HouseRadioButton);
            this.panel1.Controls.Add(this.TreeRadioButton);
            this.panel1.Controls.Add(this.NationNameText);
            this.panel1.Controls.Add(this.VillageNameText);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(592, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 364);
            this.panel1.TabIndex = 0;
            // 
            // OpenVillageButton
            // 
            this.OpenVillageButton.BackColor = System.Drawing.Color.Black;
            this.OpenVillageButton.FlatAppearance.BorderSize = 0;
            this.OpenVillageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenVillageButton.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenVillageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenVillageButton.Location = new System.Drawing.Point(116, 317);
            this.OpenVillageButton.Name = "OpenVillageButton";
            this.OpenVillageButton.Size = new System.Drawing.Size(100, 25);
            this.OpenVillageButton.TabIndex = 8;
            this.OpenVillageButton.TabStop = false;
            this.OpenVillageButton.Text = "Open Village";
            this.OpenVillageButton.UseVisualStyleBackColor = false;
            this.OpenVillageButton.Click += new System.EventHandler(this.OnClickOpenVillage);
            // 
            // NewVillageButton
            // 
            this.NewVillageButton.BackColor = System.Drawing.Color.Black;
            this.NewVillageButton.FlatAppearance.BorderSize = 0;
            this.NewVillageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewVillageButton.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVillageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewVillageButton.Location = new System.Drawing.Point(13, 317);
            this.NewVillageButton.Name = "NewVillageButton";
            this.NewVillageButton.Size = new System.Drawing.Size(100, 25);
            this.NewVillageButton.TabIndex = 7;
            this.NewVillageButton.TabStop = false;
            this.NewVillageButton.Text = "New Village";
            this.NewVillageButton.UseVisualStyleBackColor = false;
            this.NewVillageButton.Click += new System.EventHandler(this.OnClickNewVillage);
            // 
            // SaveVillageButton
            // 
            this.SaveVillageButton.BackColor = System.Drawing.Color.Black;
            this.SaveVillageButton.FlatAppearance.BorderSize = 0;
            this.SaveVillageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveVillageButton.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveVillageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveVillageButton.Location = new System.Drawing.Point(65, 288);
            this.SaveVillageButton.Name = "SaveVillageButton";
            this.SaveVillageButton.Size = new System.Drawing.Size(100, 25);
            this.SaveVillageButton.TabIndex = 6;
            this.SaveVillageButton.TabStop = false;
            this.SaveVillageButton.Text = "Save Village";
            this.SaveVillageButton.UseVisualStyleBackColor = false;
            this.SaveVillageButton.Click += new System.EventHandler(this.OnClickSaveVillage);
            // 
            // WaterRadioButton
            // 
            this.WaterRadioButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterRadioButton.Location = new System.Drawing.Point(52, 215);
            this.WaterRadioButton.Name = "WaterRadioButton";
            this.WaterRadioButton.Size = new System.Drawing.Size(122, 20);
            this.WaterRadioButton.TabIndex = 5;
            this.WaterRadioButton.TabStop = true;
            this.WaterRadioButton.Text = "Water Resource";
            this.WaterRadioButton.UseVisualStyleBackColor = true;
            this.WaterRadioButton.CheckedChanged += new System.EventHandler(this.OnClickWaterRadioButton);
            // 
            // HouseRadioButton
            // 
            this.HouseRadioButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseRadioButton.Location = new System.Drawing.Point(52, 192);
            this.HouseRadioButton.Name = "HouseRadioButton";
            this.HouseRadioButton.Size = new System.Drawing.Size(122, 20);
            this.HouseRadioButton.TabIndex = 4;
            this.HouseRadioButton.TabStop = true;
            this.HouseRadioButton.Text = "House";
            this.HouseRadioButton.UseVisualStyleBackColor = true;
            this.HouseRadioButton.CheckedChanged += new System.EventHandler(this.OnClickHouseRadioButton);
            // 
            // TreeRadioButton
            // 
            this.TreeRadioButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeRadioButton.Location = new System.Drawing.Point(52, 169);
            this.TreeRadioButton.Name = "TreeRadioButton";
            this.TreeRadioButton.Size = new System.Drawing.Size(122, 20);
            this.TreeRadioButton.TabIndex = 3;
            this.TreeRadioButton.TabStop = true;
            this.TreeRadioButton.Text = "Tree";
            this.TreeRadioButton.UseVisualStyleBackColor = true;
            this.TreeRadioButton.CheckedChanged += new System.EventHandler(this.OnClickTreeRadioButton);
            // 
            // NationNameText
            // 
            this.NationNameText.BackColor = System.Drawing.Color.Gray;
            this.NationNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NationNameText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationNameText.Location = new System.Drawing.Point(18, 108);
            this.NationNameText.Name = "NationNameText";
            this.NationNameText.Size = new System.Drawing.Size(186, 20);
            this.NationNameText.TabIndex = 2;
            this.NationNameText.Text = "Name of the Nation";
            this.NationNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NationNameText.TextChanged += new System.EventHandler(this.TextNation_TextChanged);
            // 
            // VillageNameText
            // 
            this.VillageNameText.BackColor = System.Drawing.Color.Gray;
            this.VillageNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VillageNameText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VillageNameText.Location = new System.Drawing.Point(18, 86);
            this.VillageNameText.Name = "VillageNameText";
            this.VillageNameText.Size = new System.Drawing.Size(186, 20);
            this.VillageNameText.TabIndex = 1;
            this.VillageNameText.Text = "Name of the Village";
            this.VillageNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VillageNameText.TextChanged += new System.EventHandler(this.TextVillageName_TextChanged);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Gray;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(18, 22);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(186, 30);
            this.Title.TabIndex = 3;
            this.Title.TabStop = false;
            this.Title.Text = "Age of Villagers";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateEditVIllage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(819, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateEditVIllage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Of Villagers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NationNameText;
        private System.Windows.Forms.TextBox VillageNameText;
        private System.Windows.Forms.RadioButton WaterRadioButton;
        private System.Windows.Forms.RadioButton HouseRadioButton;
        private System.Windows.Forms.RadioButton TreeRadioButton;
        private System.Windows.Forms.Button OpenVillageButton;
        private System.Windows.Forms.Button NewVillageButton;
        private System.Windows.Forms.Button SaveVillageButton;
        private System.Windows.Forms.TextBox Title;
    }
}