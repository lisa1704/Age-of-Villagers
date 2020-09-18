namespace Age_of_Villagers
{
    partial class VillageWindow
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
            this.VillageDrawing = new System.Windows.Forms.Panel();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // VillageDrawing
            // 
            this.VillageDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageDrawing.Location = new System.Drawing.Point(1, 0);
            this.VillageDrawing.Name = "VillageDrawing";
            this.VillageDrawing.Size = new System.Drawing.Size(450, 400);
            this.VillageDrawing.TabIndex = 0;
            // 
            // MenuBar
            // 
            this.MenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuBar.Controls.Add(this.OpenVillage);
            this.MenuBar.Controls.Add(this.NewVillage);
            this.MenuBar.Controls.Add(this.SaveVillage);
            this.MenuBar.Controls.Add(this.button3);
            this.MenuBar.Controls.Add(this.House);
            this.MenuBar.Controls.Add(this.Tree);
            this.MenuBar.Location = new System.Drawing.Point(450, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuBar.Size = new System.Drawing.Size(150, 400);
            this.MenuBar.TabIndex = 1;
            // 
            // OpenVillage
            // 
            this.OpenVillage.AccessibleName = "OpenVillage";
            this.OpenVillage.Location = new System.Drawing.Point(23, 323);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(94, 29);
            this.OpenVillage.TabIndex = 5;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            // 
            // NewVillage
            // 
            this.NewVillage.AccessibleName = "NewVillage";
            this.NewVillage.Location = new System.Drawing.Point(23, 288);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(94, 29);
            this.NewVillage.TabIndex = 4;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            // 
            // SaveVillage
            // 
            this.SaveVillage.AccessibleName = "SaveVillage";
            this.SaveVillage.Location = new System.Drawing.Point(23, 253);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(94, 29);
            this.SaveVillage.TabIndex = 3;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AccessibleName = "Water Source";
            this.button3.Location = new System.Drawing.Point(23, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Water Source";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // House
            // 
            this.House.AccessibleName = "House";
            this.House.Location = new System.Drawing.Point(23, 150);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(94, 29);
            this.House.TabIndex = 1;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            // 
            // Tree
            // 
            this.Tree.AccessibleDescription = "";
            this.Tree.AccessibleName = "Tree";
            this.Tree.Location = new System.Drawing.Point(23, 115);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(94, 29);
            this.Tree.TabIndex = 0;
            this.Tree.Text = "Tree\r\n";
            this.Tree.UseVisualStyleBackColor = true;
            // 
            // VillageWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.VillageDrawing);
            this.Name = "VillageWindow";
            this.Text = "Age of Villagers";
            this.MenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VillageDrawing;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button Tree;
    }
}

