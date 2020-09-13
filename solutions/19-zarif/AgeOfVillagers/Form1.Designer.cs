namespace AgeOfVillagers
{
    partial class Form1
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
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.Treeradiobtn = new System.Windows.Forms.RadioButton();
            this.WaterRadiobtn = new System.Windows.Forms.RadioButton();
            this.NameOfApp = new System.Windows.Forms.Label();
            this.NewVillagebtn = new System.Windows.Forms.Button();
            this.SaveVillagebtn = new System.Windows.Forms.Button();
            this.Openvillagebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VillageName = new System.Windows.Forms.Label();
            this.NationName = new System.Windows.Forms.Label();
            this.Houseradiobtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DrawPanel.Location = new System.Drawing.Point(13, 13);
            this.DrawPanel.MaximumSize = new System.Drawing.Size(1200, 800);
            this.DrawPanel.MinimumSize = new System.Drawing.Size(600, 400);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // Treeradiobtn
            // 
            this.Treeradiobtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Treeradiobtn.Location = new System.Drawing.Point(628, 204);
            this.Treeradiobtn.Name = "Treeradiobtn";
            this.Treeradiobtn.Size = new System.Drawing.Size(95, 30);
            this.Treeradiobtn.TabIndex = 3;
            this.Treeradiobtn.Text = "Tree";
            this.Treeradiobtn.UseVisualStyleBackColor = true;
            this.Treeradiobtn.CheckedChanged += new System.EventHandler(this.treeradiobtn_CheckedChanged);
            // 
            // WaterRadiobtn
            // 
            this.WaterRadiobtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WaterRadiobtn.Location = new System.Drawing.Point(628, 242);
            this.WaterRadiobtn.Name = "WaterRadiobtn";
            this.WaterRadiobtn.Size = new System.Drawing.Size(128, 24);
            this.WaterRadiobtn.TabIndex = 4;
            this.WaterRadiobtn.Text = "Water Source";
            this.WaterRadiobtn.UseVisualStyleBackColor = true;
            this.WaterRadiobtn.CheckedChanged += new System.EventHandler(this.WaterRadiobtn_CheckedChanged);
            // 
            // NameOfApp
            // 
            this.NameOfApp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameOfApp.Location = new System.Drawing.Point(656, 13);
            this.NameOfApp.Name = "NameOfApp";
            this.NameOfApp.Size = new System.Drawing.Size(147, 40);
            this.NameOfApp.TabIndex = 5;
            this.NameOfApp.Text = "Age Of Villagers";
            this.NameOfApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameOfApp.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewVillagebtn
            // 
            this.NewVillagebtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewVillagebtn.Location = new System.Drawing.Point(681, 321);
            this.NewVillagebtn.Name = "NewVillagebtn";
            this.NewVillagebtn.Size = new System.Drawing.Size(95, 30);
            this.NewVillagebtn.TabIndex = 6;
            this.NewVillagebtn.Text = "New Village";
            this.NewVillagebtn.UseVisualStyleBackColor = true;
            this.NewVillagebtn.Click += new System.EventHandler(this.NewVillagebtn_Click);
            // 
            // SaveVillagebtn
            // 
            this.SaveVillagebtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveVillagebtn.Location = new System.Drawing.Point(729, 357);
            this.SaveVillagebtn.Name = "SaveVillagebtn";
            this.SaveVillagebtn.Size = new System.Drawing.Size(95, 30);
            this.SaveVillagebtn.TabIndex = 7;
            this.SaveVillagebtn.Text = "Save Village";
            this.SaveVillagebtn.UseVisualStyleBackColor = true;
            this.SaveVillagebtn.Click += new System.EventHandler(this.SaveVillagebtn_Click);
            // 
            // Openvillagebtn
            // 
            this.Openvillagebtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Openvillagebtn.Location = new System.Drawing.Point(628, 357);
            this.Openvillagebtn.Name = "Openvillagebtn";
            this.Openvillagebtn.Size = new System.Drawing.Size(95, 30);
            this.Openvillagebtn.TabIndex = 8;
            this.Openvillagebtn.Text = "Open Village";
            this.Openvillagebtn.UseVisualStyleBackColor = true;
            this.Openvillagebtn.Click += new System.EventHandler(this.Openvillagebtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(619, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 400);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(619, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 1);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(619, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 1);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(828, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 400);
            this.label4.TabIndex = 10;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // VillageName
            // 
            this.VillageName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VillageName.Location = new System.Drawing.Point(626, 69);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(196, 25);
            this.VillageName.TabIndex = 5;
            this.VillageName.Text = "village name";
            this.VillageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VillageName.Click += new System.EventHandler(this.label1_Click);
            // 
            // NationName
            // 
            this.NationName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NationName.Location = new System.Drawing.Point(626, 94);
            this.NationName.Name = "NationName";
            this.NationName.Size = new System.Drawing.Size(196, 25);
            this.NationName.TabIndex = 5;
            this.NationName.Text = "nation name";
            this.NationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NationName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Houseradiobtn
            // 
            this.Houseradiobtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Houseradiobtn.Location = new System.Drawing.Point(628, 168);
            this.Houseradiobtn.Name = "Houseradiobtn";
            this.Houseradiobtn.Size = new System.Drawing.Size(95, 30);
            this.Houseradiobtn.TabIndex = 3;
            this.Houseradiobtn.Text = "House";
            this.Houseradiobtn.UseVisualStyleBackColor = true;
            this.Houseradiobtn.CheckedChanged += new System.EventHandler(this.houseradiobtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 427);
            this.Controls.Add(this.Houseradiobtn);
            this.Controls.Add(this.NationName);
            this.Controls.Add(this.VillageName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Openvillagebtn);
            this.Controls.Add(this.SaveVillagebtn);
            this.Controls.Add(this.NewVillagebtn);
            this.Controls.Add(this.NameOfApp);
            this.Controls.Add(this.WaterRadiobtn);
            this.Controls.Add(this.Treeradiobtn);
            this.Controls.Add(this.DrawPanel);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(854, 466);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.RadioButton Treeradiobtn;
        private System.Windows.Forms.RadioButton WaterRadiobtn;
        private System.Windows.Forms.Label NameOfApp;
        private System.Windows.Forms.Button NewVillagebtn;
        private System.Windows.Forms.Button SaveVillagebtn;
        private System.Windows.Forms.Button Openvillagebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VillageName;
        private System.Windows.Forms.Label NationName;
        private System.Windows.Forms.RadioButton Houseradiobtn;
    }
}

