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
            this.Houseradiobtn = new System.Windows.Forms.RadioButton();
            this.Treeradiobtn = new System.Windows.Forms.RadioButton();
            this.WaterRadiobtn = new System.Windows.Forms.RadioButton();
            this.NameOfApp = new System.Windows.Forms.Label();
            this.NewVillagebtn = new System.Windows.Forms.Button();
            this.SaveVillagebtn = new System.Windows.Forms.Button();
            this.Openvillagebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DrawPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DrawPanel.Location = new System.Drawing.Point(13, 13);
            this.DrawPanel.MaximumSize = new System.Drawing.Size(1200, 800);
            this.DrawPanel.MinimumSize = new System.Drawing.Size(600, 400);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // Houseradiobtn
            // 
            this.Houseradiobtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Houseradiobtn.Location = new System.Drawing.Point(628, 166);
            this.Houseradiobtn.Name = "Houseradiobtn";
            this.Houseradiobtn.Size = new System.Drawing.Size(95, 32);
            this.Houseradiobtn.TabIndex = 2;
            this.Houseradiobtn.TabStop = true;
            this.Houseradiobtn.Text = "House";
            this.Houseradiobtn.UseVisualStyleBackColor = true;
            this.Houseradiobtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Treeradiobtn
            // 
            this.Treeradiobtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Treeradiobtn.Location = new System.Drawing.Point(628, 204);
            this.Treeradiobtn.Name = "Treeradiobtn";
            this.Treeradiobtn.Size = new System.Drawing.Size(95, 30);
            this.Treeradiobtn.TabIndex = 3;
            this.Treeradiobtn.TabStop = true;
            this.Treeradiobtn.Text = "Tree";
            this.Treeradiobtn.UseVisualStyleBackColor = true;
            this.Treeradiobtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // WaterRadiobtn
            // 
            this.WaterRadiobtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WaterRadiobtn.Location = new System.Drawing.Point(628, 242);
            this.WaterRadiobtn.Name = "WaterRadiobtn";
            this.WaterRadiobtn.Size = new System.Drawing.Size(95, 24);
            this.WaterRadiobtn.TabIndex = 4;
            this.WaterRadiobtn.TabStop = true;
            this.WaterRadiobtn.Text = "Water Source";
            this.WaterRadiobtn.UseVisualStyleBackColor = true;
            // 
            // NameOfApp
            // 
            this.NameOfApp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameOfApp.Location = new System.Drawing.Point(656, 23);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 427);
            this.Controls.Add(this.Openvillagebtn);
            this.Controls.Add(this.SaveVillagebtn);
            this.Controls.Add(this.NewVillagebtn);
            this.Controls.Add(this.NameOfApp);
            this.Controls.Add(this.WaterRadiobtn);
            this.Controls.Add(this.Treeradiobtn);
            this.Controls.Add(this.Houseradiobtn);
            this.Controls.Add(this.DrawPanel);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(847, 466);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.RadioButton Houseradiobtn;
        private System.Windows.Forms.RadioButton Treeradiobtn;
        private System.Windows.Forms.RadioButton WaterRadiobtn;
        private System.Windows.Forms.Label NameOfApp;
        private System.Windows.Forms.Button NewVillagebtn;
        private System.Windows.Forms.Button SaveVillagebtn;
        private System.Windows.Forms.Button Openvillagebtn;
    }
}

