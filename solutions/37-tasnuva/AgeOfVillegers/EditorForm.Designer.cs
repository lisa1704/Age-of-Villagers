namespace AgeOfVillegers
{
    partial class EditorForm
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
            this.save = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.VillageNameBox = new System.Windows.Forms.TextBox();
            this.Tree_btn = new System.Windows.Forms.RadioButton();
            this.House_btn = new System.Windows.Forms.RadioButton();
            this.Water_btn = new System.Windows.Forms.RadioButton();
            this.Open_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 395);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(529, 272);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(109, 24);
            this.save.TabIndex = 2;
            this.save.Text = "Save Village";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(557, 320);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(171, 23);
            this.new_btn.TabIndex = 4;
            this.new_btn.Text = "New Village";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bangladeshi Farmer",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.comboBox1.Location = new System.Drawing.Point(602, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // VillageNameBox
            // 
            this.VillageNameBox.Location = new System.Drawing.Point(601, 62);
            this.VillageNameBox.Name = "VillageNameBox";
            this.VillageNameBox.Size = new System.Drawing.Size(127, 22);
            this.VillageNameBox.TabIndex = 9;
            this.VillageNameBox.Text = "Village";
            this.VillageNameBox.TextChanged += new System.EventHandler(this.VillageNameBox_TextChanged);
            // 
            // Tree_btn
            // 
            this.Tree_btn.AutoSize = true;
            this.Tree_btn.Location = new System.Drawing.Point(601, 157);
            this.Tree_btn.Name = "Tree_btn";
            this.Tree_btn.Size = new System.Drawing.Size(59, 21);
            this.Tree_btn.TabIndex = 10;
            this.Tree_btn.TabStop = true;
            this.Tree_btn.Text = "Tree";
            this.Tree_btn.UseVisualStyleBackColor = true;
            this.Tree_btn.CheckedChanged += new System.EventHandler(this.Tree_btn_CheckedChanged);
            // 
            // House_btn
            // 
            this.House_btn.AutoSize = true;
            this.House_btn.Location = new System.Drawing.Point(602, 196);
            this.House_btn.Name = "House_btn";
            this.House_btn.Size = new System.Drawing.Size(70, 21);
            this.House_btn.TabIndex = 11;
            this.House_btn.TabStop = true;
            this.House_btn.Text = "House";
            this.House_btn.UseVisualStyleBackColor = true;
            this.House_btn.CheckedChanged += new System.EventHandler(this.House_btn_CheckedChanged);
            // 
            // Water_btn
            // 
            this.Water_btn.AutoSize = true;
            this.Water_btn.Location = new System.Drawing.Point(601, 233);
            this.Water_btn.Name = "Water_btn";
            this.Water_btn.Size = new System.Drawing.Size(116, 21);
            this.Water_btn.TabIndex = 12;
            this.Water_btn.TabStop = true;
            this.Water_btn.Text = "Water Source";
            this.Water_btn.UseVisualStyleBackColor = true;
            this.Water_btn.CheckedChanged += new System.EventHandler(this.Water_btn_CheckedChanged_1);
            // 
            // Open_btn
            // 
            this.Open_btn.Location = new System.Drawing.Point(653, 273);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(105, 23);
            this.Open_btn.TabIndex = 13;
            this.Open_btn.Text = "Open Village";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.Water_btn);
            this.Controls.Add(this.House_btn);
            this.Controls.Add(this.Tree_btn);
            this.Controls.Add(this.VillageNameBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel1);
            this.Name = "EditorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox VillageNameBox;
        private System.Windows.Forms.RadioButton Tree_btn;
        private System.Windows.Forms.RadioButton House_btn;
        private System.Windows.Forms.RadioButton Water_btn;
        private System.Windows.Forms.Button Open_btn;
    }
}

