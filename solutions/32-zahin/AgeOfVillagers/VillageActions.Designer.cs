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
            this.ConfirmSaveVillage = new System.Windows.Forms.SaveFileDialog();
            this.ConfirmOpenVillage = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.OpenVIllage = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.tree = new System.Windows.Forms.Button();
            this.Water = new System.Windows.Forms.Button();
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.Water);
            this.panel2.Controls.Add(this.tree);
            this.panel2.Controls.Add(this.House);
            this.panel2.Controls.Add(this.OpenVIllage);
            this.panel2.Controls.Add(this.SaveVillage);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Location = new System.Drawing.Point(545, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 402);
            this.panel2.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(87, 305);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(143, 40);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "New Village";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(87, 259);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(143, 40);
            this.SaveVillage.TabIndex = 3;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenVIllage
            // 
            this.OpenVIllage.Location = new System.Drawing.Point(87, 351);
            this.OpenVIllage.Name = "OpenVIllage";
            this.OpenVIllage.Size = new System.Drawing.Size(143, 40);
            this.OpenVIllage.TabIndex = 4;
            this.OpenVIllage.Text = "Open Village";
            this.OpenVIllage.UseVisualStyleBackColor = true;
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(128, 152);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(67, 31);
            this.House.TabIndex = 5;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(40, 152);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(62, 31);
            this.tree.TabIndex = 6;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = true;
            // 
            // Water
            // 
            this.Water.Location = new System.Drawing.Point(219, 152);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(73, 31);
            this.Water.TabIndex = 7;
            this.Water.Text = "Water";
            this.Water.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog ConfirmSaveVillage;
        private System.Windows.Forms.OpenFileDialog ConfirmOpenVillage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OpenVIllage;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button tree;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button Water;
    }
}

