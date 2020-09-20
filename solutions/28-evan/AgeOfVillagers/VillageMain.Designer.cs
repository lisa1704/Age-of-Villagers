namespace AgeOfVillagers
{
    partial class VillageMain
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
            this.house_radio = new System.Windows.Forms.RadioButton();
            this.tree_radio = new System.Windows.Forms.RadioButton();
            this.water_radio = new System.Windows.Forms.RadioButton();
            this.open_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(754, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Inuit Hunters",
            "Egyptian Kings",
            "Arab Bedouin",
            "Bangladeshi Farmers"});
            this.comboBox1.Location = new System.Drawing.Point(743, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // house_radio
            // 
            this.house_radio.AutoSize = true;
            this.house_radio.Location = new System.Drawing.Point(743, 205);
            this.house_radio.Name = "house_radio";
            this.house_radio.Size = new System.Drawing.Size(56, 17);
            this.house_radio.TabIndex = 3;
            this.house_radio.TabStop = true;
            this.house_radio.Text = "House\r\n";
            this.house_radio.UseVisualStyleBackColor = true;
            // 
            // tree_radio
            // 
            this.tree_radio.AutoSize = true;
            this.tree_radio.Location = new System.Drawing.Point(743, 242);
            this.tree_radio.Name = "tree_radio";
            this.tree_radio.Size = new System.Drawing.Size(47, 17);
            this.tree_radio.TabIndex = 4;
            this.tree_radio.TabStop = true;
            this.tree_radio.Text = "Tree";
            this.tree_radio.UseVisualStyleBackColor = true;
            // 
            // water_radio
            // 
            this.water_radio.AutoSize = true;
            this.water_radio.Location = new System.Drawing.Point(743, 282);
            this.water_radio.Name = "water_radio";
            this.water_radio.Size = new System.Drawing.Size(91, 17);
            this.water_radio.TabIndex = 5;
            this.water_radio.TabStop = true;
            this.water_radio.Text = "Water Source";
            this.water_radio.UseVisualStyleBackColor = true;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(647, 335);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(75, 23);
            this.open_btn.TabIndex = 6;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = true;
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(754, 335);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(75, 23);
            this.new_btn.TabIndex = 7;
            this.new_btn.Text = "New";
            this.new_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(859, 335);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // VillageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.water_radio);
            this.Controls.Add(this.tree_radio);
            this.Controls.Add(this.house_radio);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "VillageMain";
            this.Text = "Age Of Villagers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton house_radio;
        private System.Windows.Forms.RadioButton tree_radio;
        private System.Windows.Forms.RadioButton water_radio;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button save_btn;
    }
}

