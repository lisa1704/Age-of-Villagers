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
            this.panel1 = new System.Windows.Forms.Panel();
            this.VillageBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.House_btn = new System.Windows.Forms.RadioButton();
            this.Tree_btn = new System.Windows.Forms.RadioButton();
            this.Water_btn = new System.Windows.Forms.RadioButton();
            this.Save_btn = new System.Windows.Forms.Button();
            this.New_btn = new System.Windows.Forms.Button();
            this.Open_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(39, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 374);
            this.panel1.TabIndex = 0;
            // 
            // VillageBox
            // 
            this.VillageBox.Location = new System.Drawing.Point(513, 62);
            this.VillageBox.Name = "VillageBox";
            this.VillageBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VillageBox.Size = new System.Drawing.Size(231, 22);
            this.VillageBox.TabIndex = 1;
            this.VillageBox.Text = "Enter Village";
            this.VillageBox.TextChanged += new System.EventHandler(this.VillageBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(503, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // House_btn
            // 
            this.House_btn.AutoSize = true;
            this.House_btn.Location = new System.Drawing.Point(544, 166);
            this.House_btn.Name = "House_btn";
            this.House_btn.Size = new System.Drawing.Size(70, 21);
            this.House_btn.TabIndex = 3;
            this.House_btn.TabStop = true;
            this.House_btn.Text = "House";
            this.House_btn.UseVisualStyleBackColor = true;
            // 
            // Tree_btn
            // 
            this.Tree_btn.AutoSize = true;
            this.Tree_btn.Location = new System.Drawing.Point(544, 210);
            this.Tree_btn.Name = "Tree_btn";
            this.Tree_btn.Size = new System.Drawing.Size(59, 21);
            this.Tree_btn.TabIndex = 4;
            this.Tree_btn.TabStop = true;
            this.Tree_btn.Text = "Tree";
            this.Tree_btn.UseVisualStyleBackColor = true;
            this.Tree_btn.CheckedChanged += new System.EventHandler(this.Tree_btn_CheckedChanged);
            // 
            // Water_btn
            // 
            this.Water_btn.AutoSize = true;
            this.Water_btn.Location = new System.Drawing.Point(545, 268);
            this.Water_btn.Name = "Water_btn";
            this.Water_btn.Size = new System.Drawing.Size(116, 21);
            this.Water_btn.TabIndex = 5;
            this.Water_btn.TabStop = true;
            this.Water_btn.Text = "Water Source";
            this.Water_btn.UseVisualStyleBackColor = true;
            this.Water_btn.CheckedChanged += new System.EventHandler(this.Water_btn_CheckedChanged);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(529, 348);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // New_btn
            // 
            this.New_btn.Location = new System.Drawing.Point(653, 349);
            this.New_btn.Name = "New_btn";
            this.New_btn.Size = new System.Drawing.Size(75, 23);
            this.New_btn.TabIndex = 7;
            this.New_btn.Text = "New";
            this.New_btn.UseVisualStyleBackColor = true;
            this.New_btn.Click += new System.EventHandler(this.New_btn_Click);
            // 
            // Open_btn
            // 
            this.Open_btn.Location = new System.Drawing.Point(603, 393);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(75, 23);
            this.Open_btn.TabIndex = 8;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.New_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Water_btn);
            this.Controls.Add(this.Tree_btn);
            this.Controls.Add(this.House_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.VillageBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox VillageBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton House_btn;
        private System.Windows.Forms.RadioButton Tree_btn;
        private System.Windows.Forms.RadioButton Water_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button New_btn;
        private System.Windows.Forms.Button Open_btn;
    }
}

