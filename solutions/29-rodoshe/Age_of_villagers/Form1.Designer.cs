namespace Age_of_villagers
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.house = new System.Windows.Forms.RadioButton();
            this.tree = new System.Windows.Forms.RadioButton();
            this.watersource = new System.Windows.Forms.RadioButton();
            this.open = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 330);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Inuit Hunter",
            "Egyptian King",
            "Arab Bedouin",
            "Bangladeshi Farmers"});
            this.comboBox1.Location = new System.Drawing.Point(455, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // house
            // 
            this.house.AutoSize = true;
            this.house.Location = new System.Drawing.Point(465, 174);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(68, 21);
            this.house.TabIndex = 3;
            this.house.TabStop = true;
            this.house.Text = "house";
            this.house.UseVisualStyleBackColor = true;
            // 
            // tree
            // 
            this.tree.AutoSize = true;
            this.tree.Location = new System.Drawing.Point(466, 232);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(54, 21);
            this.tree.TabIndex = 4;
            this.tree.TabStop = true;
            this.tree.Text = "tree";
            this.tree.UseVisualStyleBackColor = true;
            // 
            // watersource
            // 
            this.watersource.AutoSize = true;
            this.watersource.Location = new System.Drawing.Point(466, 285);
            this.watersource.Name = "watersource";
            this.watersource.Size = new System.Drawing.Size(106, 21);
            this.watersource.TabIndex = 5;
            this.watersource.TabStop = true;
            this.watersource.Text = "watersource";
            this.watersource.UseVisualStyleBackColor = true;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(466, 337);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 6;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "new";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(585, 337);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.open);
            this.Controls.Add(this.watersource);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.house);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton house;
        private System.Windows.Forms.RadioButton tree;
        private System.Windows.Forms.RadioButton watersource;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save;
    }
}

