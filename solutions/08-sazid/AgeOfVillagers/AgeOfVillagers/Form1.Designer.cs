namespace AgeOfVillagers
{
    partial class Form1
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
            this.treeButton = new System.Windows.Forms.Button();
            this.houseButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.newVillageButton = new System.Windows.Forms.Button();
            this.openVillageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeButton
            // 
            this.treeButton.Location = new System.Drawing.Point(639, 209);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(75, 23);
            this.treeButton.TabIndex = 0;
            this.treeButton.Text = "Tree";
            this.treeButton.UseVisualStyleBackColor = true;
            this.treeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // houseButton
            // 
            this.houseButton.Location = new System.Drawing.Point(760, 209);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(75, 23);
            this.houseButton.TabIndex = 1;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            // 
            // waterButton
            // 
            this.waterButton.Location = new System.Drawing.Point(699, 262);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(91, 23);
            this.waterButton.TabIndex = 2;
            this.waterButton.Text = "Water Source";
            this.waterButton.UseVisualStyleBackColor = true;
            // 
            // newVillageButton
            // 
            this.newVillageButton.Location = new System.Drawing.Point(639, 405);
            this.newVillageButton.Name = "newVillageButton";
            this.newVillageButton.Size = new System.Drawing.Size(75, 23);
            this.newVillageButton.TabIndex = 3;
            this.newVillageButton.Text = "New Village";
            this.newVillageButton.UseVisualStyleBackColor = true;
            // 
            // openVillageButton
            // 
            this.openVillageButton.Location = new System.Drawing.Point(760, 405);
            this.openVillageButton.Name = "openVillageButton";
            this.openVillageButton.Size = new System.Drawing.Size(75, 23);
            this.openVillageButton.TabIndex = 4;
            this.openVillageButton.Text = "Open Village";
            this.openVillageButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(699, 376);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Village";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.MinimumSize = new System.Drawing.Size(600, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 497);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openVillageButton);
            this.Controls.Add(this.newVillageButton);
            this.Controls.Add(this.waterButton);
            this.Controls.Add(this.houseButton);
            this.Controls.Add(this.treeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button treeButton;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.Button newVillageButton;
        private System.Windows.Forms.Button openVillageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel1;
    }
}

