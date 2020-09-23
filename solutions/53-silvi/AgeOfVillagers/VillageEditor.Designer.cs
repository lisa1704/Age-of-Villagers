using System;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    partial class VillageEditor
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(39, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // VillageBox
            // 
            this.VillageBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VillageBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VillageBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VillageBox.Location = new System.Drawing.Point(124, 30);
            this.VillageBox.Name = "VillageBox";
            this.VillageBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VillageBox.Size = new System.Drawing.Size(231, 30);
            this.VillageBox.TabIndex = 1;
            this.VillageBox.Text = "Enter Village";
            this.VillageBox.TextChanged += new System.EventHandler(this.VillageBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.comboBox1.Location = new System.Drawing.Point(124, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // House_btn
            // 
            this.House_btn.AutoSize = true;
            this.House_btn.Location = new System.Drawing.Point(124, 189);
            this.House_btn.Name = "House_btn";
            this.House_btn.Size = new System.Drawing.Size(70, 21);
            this.House_btn.TabIndex = 3;
            this.House_btn.TabStop = true;
            this.House_btn.Text = "House";
            this.House_btn.UseVisualStyleBackColor = true;
            this.House_btn.CheckedChanged += new System.EventHandler(this.House_btn_CheckedChanged);
            // 
            // Tree_btn
            // 
            this.Tree_btn.AutoSize = true;
            this.Tree_btn.Location = new System.Drawing.Point(241, 189);
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
            this.Water_btn.Location = new System.Drawing.Point(359, 189);
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
            this.Save_btn.Location = new System.Drawing.Point(119, 271);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // New_btn
            // 
            this.New_btn.Location = new System.Drawing.Point(198, 318);
            this.New_btn.Name = "New_btn";
            this.New_btn.Size = new System.Drawing.Size(75, 23);
            this.New_btn.TabIndex = 7;
            this.New_btn.Text = "New";
            this.New_btn.UseVisualStyleBackColor = true;
            this.New_btn.Click += new System.EventHandler(this.New_btn_Click);
            // 
            // Open_btn
            // 
            this.Open_btn.Location = new System.Drawing.Point(267, 271);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(75, 23);
            this.Open_btn.TabIndex = 8;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.New_btn);
            this.panel2.Controls.Add(this.Open_btn);
            this.panel2.Controls.Add(this.Water_btn);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.Save_btn);
            this.panel2.Controls.Add(this.Tree_btn);
            this.panel2.Controls.Add(this.House_btn);
            this.panel2.Controls.Add(this.VillageBox);
            this.panel2.Location = new System.Drawing.Point(694, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 400);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // VillageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1263, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "VillageEditor";
            this.Text = "AgeOfVillagers";
            this.Load += new System.EventHandler(this.VillageEditor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void VillageEditor_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public Label AgeOfVillagers { get; private set; }

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
        private System.Windows.Forms.Panel panel2;
    }
}

