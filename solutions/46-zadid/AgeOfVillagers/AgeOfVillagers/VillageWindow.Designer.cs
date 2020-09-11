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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.NationType = new System.Windows.Forms.ComboBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.watersource = new System.Windows.Forms.Button();
            this.tree = new System.Windows.Forms.Button();
            this.house = new System.Windows.Forms.Button();
            this.villagename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drawpanel = new System.Windows.Forms.Panel();
            this.sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sidepanel.Controls.Add(this.NationType);
            this.sidepanel.Controls.Add(this.NewButton);
            this.sidepanel.Controls.Add(this.OpenButton);
            this.sidepanel.Controls.Add(this.SaveButton);
            this.sidepanel.Controls.Add(this.watersource);
            this.sidepanel.Controls.Add(this.tree);
            this.sidepanel.Controls.Add(this.house);
            this.sidepanel.Controls.Add(this.villagename);
            this.sidepanel.Controls.Add(this.label2);
            this.sidepanel.Controls.Add(this.label1);
            this.sidepanel.Location = new System.Drawing.Point(600, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(250, 400);
            this.sidepanel.TabIndex = 0;
            this.sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Side_panel);
            // 
            // NationType
            // 
            this.NationType.FormattingEnabled = true;
            this.NationType.Items.AddRange(new String[] {
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Arab Bedouin",
            "Inuit Hunters"
            });
            this.NationType.SelectedIndex = -1;
            this.NationType.Location = new System.Drawing.Point(23, 102);
            this.NationType.Name = "NationType";
            this.NationType.Size = new System.Drawing.Size(185, 24);
            this.NationType.TabIndex = 10;
            this.NationType.Text = "Village type";
            this.NationType.SelectedIndexChanged += new System.EventHandler(this.NationtypeSelectedIndexChanged);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(53, 346);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(134, 36);
            this.NewButton.TabIndex = 8;
            this.NewButton.Text = "New Village";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new EventHandler(this.RefreshForm);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(52, 306);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(135, 34);
            this.OpenButton.TabIndex = 7;
            this.OpenButton.Text = "Open Village";
            this.OpenButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(52, 267);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(135, 33);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Village";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // watersource
            // 
            this.watersource.Location = new System.Drawing.Point(53, 218);
            this.watersource.Name = "watersource";
            this.watersource.Size = new System.Drawing.Size(135, 32);
            this.watersource.TabIndex = 5;
            this.watersource.Text = "Water Source";
            this.watersource.UseVisualStyleBackColor = true;
            this.watersource.Click += new System.EventHandler(this.Watersource_Click);
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(120, 181);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(88, 32);
            this.tree.TabIndex = 4;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = true;
            this.tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // house
            // 
            this.house.Location = new System.Drawing.Point(23, 181);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(91, 31);
            this.house.TabIndex = 3;
            this.house.Text = "House";
            this.house.UseVisualStyleBackColor = true;
            this.house.Click += new System.EventHandler(this.House_Click);
            // 
            // villagename
            // 
            this.villagename.Location = new System.Drawing.Point(23, 74);
            this.villagename.Name = "villagename";
            this.villagename.Size = new System.Drawing.Size(185, 22);
            this.villagename.TabIndex = 2;
            this.villagename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Villagename_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Village Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age Of Villagers";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // drawpanel
            // 
            this.drawpanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawpanel.Location = new System.Drawing.Point(2, 0);
            this.drawpanel.Name = "drawpanel";
            this.drawpanel.Size = new System.Drawing.Size(600, 400);
            this.drawpanel.TabIndex = 1;
            this.drawpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw_panel);
            this.drawpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawpanel_MouseClick);
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 400);
            this.Controls.Add(this.drawpanel);
            this.Controls.Add(this.sidepanel);
            this.Name = "VillageWindow";
            this.Text = "Village Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        



        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel drawpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button watersource;
        private System.Windows.Forms.Button tree;
        private System.Windows.Forms.Button house;
        private System.Windows.Forms.TextBox villagename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox NationType;
    }
}