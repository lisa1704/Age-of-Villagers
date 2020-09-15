using System;

namespace Age_Of_Villagers
{
    partial class Village_Window
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
            this.AgeOfVillagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeOfVillagers.ForeColor = System.Drawing.Color.DarkMagenta;
            this.AgeOfVillagers.Location = new System.Drawing.Point(870, 28);
            this.AgeOfVillagers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeOfVillagers.Name = "AgeOfVillagers";
            this.AgeOfVillagers.Size = new System.Drawing.Size(247, 36);
            this.AgeOfVillagers.TabIndex = 0;
            this.AgeOfVillagers.Text = "Age Of Villagers";
            this.AgeOfVillagers.Click += new System.EventHandler(this.AgeOfVillagers_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawingPanel.ForeColor = System.Drawing.Color.DarkCyan;
            this.drawingPanel.Location = new System.Drawing.Point(4, 0);
            this.drawingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(750, 500);
            this.drawingPanel.TabIndex = 1;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseClick);
            // 
            // villageName
            // 
            this.villageName.AutoSize = true;
            this.villageName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.villageName.Location = new System.Drawing.Point(928, 74);
            this.villageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.villageName.Name = "villageName";
            this.villageName.Size = new System.Drawing.Size(118, 36);
            this.villageName.TabIndex = 2;
            this.villageName.Text = "Katakhali";
            this.villageName.Click += new System.EventHandler(this.villageName_Click);
            // 
            // nation
            // 
            this.nation.AutoSize = true;
            this.nation.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nation.Location = new System.Drawing.Point(870, 121);
            this.nation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(223, 30);
            this.nation.TabIndex = 3;
            this.nation.Text = "Bangladeshi Farmers";
            this.nation.Click += new System.EventHandler(this.nation_Click);
            // 
            // saveVillagebutton
            // 
            this.saveVillagebutton.BackColor = System.Drawing.Color.Honeydew;
            this.saveVillagebutton.Location = new System.Drawing.Point(889, 381);
            this.saveVillagebutton.Margin = new System.Windows.Forms.Padding(4);
            this.saveVillagebutton.Name = "saveVillagebutton";
            this.saveVillagebutton.Size = new System.Drawing.Size(200, 38);
            this.saveVillagebutton.TabIndex = 8;
            this.saveVillagebutton.Text = "Save Village";
            this.saveVillagebutton.UseVisualStyleBackColor = false;
            this.saveVillagebutton.Click += new System.EventHandler(this.saveVillagebutton_Click);
            // 
            // newVillagebutton
            // 
            this.newVillagebutton.BackColor = System.Drawing.Color.Honeydew;
            this.newVillagebutton.Location = new System.Drawing.Point(779, 426);
            this.newVillagebutton.Margin = new System.Windows.Forms.Padding(4);
            this.newVillagebutton.Name = "newVillagebutton";
            this.newVillagebutton.Size = new System.Drawing.Size(200, 38);
            this.newVillagebutton.TabIndex = 9;
            this.newVillagebutton.Text = "New Village";
            this.newVillagebutton.UseVisualStyleBackColor = false;
            this.newVillagebutton.Click += new System.EventHandler(this.newVillagebutton_Click);
            // 
            // openVillagebutton
            // 
            this.openVillagebutton.BackColor = System.Drawing.Color.Honeydew;
            this.openVillagebutton.Location = new System.Drawing.Point(999, 426);
            this.openVillagebutton.Margin = new System.Windows.Forms.Padding(4);
            this.openVillagebutton.Name = "openVillagebutton";
            this.openVillagebutton.Size = new System.Drawing.Size(200, 38);
            this.openVillagebutton.TabIndex = 10;
            this.openVillagebutton.Text = "Open Village";
            this.openVillagebutton.UseVisualStyleBackColor = false;
            this.openVillagebutton.Click += new System.EventHandler(this.openVillagebutton_Click);
            // 
            // treeButton
            // 
            this.treeButton.AutoSize = true;
            this.treeButton.Location = new System.Drawing.Point(949, 210);
            this.treeButton.Margin = new System.Windows.Forms.Padding(4);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(68, 29);
            this.treeButton.TabIndex = 11;
            this.treeButton.TabStop = true;
            this.treeButton.Text = "Tree";
            this.treeButton.UseVisualStyleBackColor = true;
            this.treeButton.CheckedChanged += new System.EventHandler(this.treeButton_CheckedChanged);
            // 
            // houseButton
            // 
            this.houseButton.AutoSize = true;
            this.houseButton.Location = new System.Drawing.Point(949, 248);
            this.houseButton.Margin = new System.Windows.Forms.Padding(4);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(88, 29);
            this.houseButton.TabIndex = 12;
            this.houseButton.TabStop = true;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.CheckedChanged += new System.EventHandler(this.houseButton_CheckedChanged);
            // 
            // waterSourceButton
            // 
            this.waterSourceButton.AutoSize = true;
            this.waterSourceButton.Location = new System.Drawing.Point(949, 285);
            this.waterSourceButton.Margin = new System.Windows.Forms.Padding(4);
            this.waterSourceButton.Name = "waterSourceButton";
            this.waterSourceButton.Size = new System.Drawing.Size(142, 29);
            this.waterSourceButton.TabIndex = 13;
            this.waterSourceButton.TabStop = true;
            this.waterSourceButton.Text = "Water Source";
            this.waterSourceButton.UseVisualStyleBackColor = true;
            this.waterSourceButton.CheckedChanged += new System.EventHandler(this.waterSourceButton_CheckedChanged);
            // 
            // Village_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1230, 514);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Village_Window";
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