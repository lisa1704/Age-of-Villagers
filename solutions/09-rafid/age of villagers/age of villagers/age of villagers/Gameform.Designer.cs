namespace age_of_villagers
{
    partial class Gameform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TreeButton = new System.Windows.Forms.Button();
            this.HouseButton = new System.Windows.Forms.Button();
            this.WaterButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.VillageName = new System.Windows.Forms.TextBox();
            this.NationName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NationName);
            this.panel2.Controls.Add(this.VillageName);
            this.panel2.Controls.Add(this.OpenButton);
            this.panel2.Controls.Add(this.NewButton);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.WaterButton);
            this.panel2.Controls.Add(this.HouseButton);
            this.panel2.Controls.Add(this.TreeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(618, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 400);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "age_of_villagers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TreeButton
            // 
            this.TreeButton.Location = new System.Drawing.Point(3, 167);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(80, 37);
            this.TreeButton.TabIndex = 1;
            this.TreeButton.Text = "Tree";
            this.TreeButton.UseVisualStyleBackColor = true;
            this.TreeButton.Click += new System.EventHandler(this.TreeButton_Click);
            // 
            // HouseButton
            // 
            this.HouseButton.Location = new System.Drawing.Point(92, 167);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(75, 37);
            this.HouseButton.TabIndex = 2;
            this.HouseButton.Text = "House";
            this.HouseButton.UseVisualStyleBackColor = true;
            this.HouseButton.Click += new System.EventHandler(this.HouseButton_Click);
            // 
            // WaterButton
            // 
            this.WaterButton.Location = new System.Drawing.Point(50, 219);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(75, 23);
            this.WaterButton.TabIndex = 3;
            this.WaterButton.Text = "Water";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.WaterButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(50, 322);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "SaveVillage";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(3, 351);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "NewVillage";
            this.NewButton.UseMnemonic = false;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(84, 351);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 6;
            this.OpenButton.Text = "OpenVillage";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // VillageName
            // 
            this.VillageName.Location = new System.Drawing.Point(14, 46);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(89, 20);
            this.VillageName.TabIndex = 7;
            this.VillageName.TextChanged += new System.EventHandler(this.VillageName_TextChanged);
            // 
            // NationName
            // 
            this.NationName.Location = new System.Drawing.Point(14, 72);
            this.NationName.Name = "NationName";
            this.NationName.Size = new System.Drawing.Size(100, 20);
            this.NationName.TabIndex = 8;
            this.NationName.TextChanged += new System.EventHandler(this.NationName_TextChanged);
            // 
            // Gameform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Gameform";
            this.Text = "Gameform";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TreeButton;
        private System.Windows.Forms.Button HouseButton;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox VillageName;
        private System.Windows.Forms.TextBox NationName;
    }
}