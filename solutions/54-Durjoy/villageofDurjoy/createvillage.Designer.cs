namespace villageofDurjoy
{
    partial class createvillage
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
            
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Housebutton = new System.Windows.Forms.RadioButton();
            this.treeButton = new System.Windows.Forms.RadioButton();
            this.Watersourcebutton = new System.Windows.Forms.RadioButton();
            this.Newbutton = new System.Windows.Forms.Button();
            this.openbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
           
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(540, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            " Bangladeshi Farmers",
            " Inuit Hunters",
            " Egyptian Kings",
            " Arab Bedouin ",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(540, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Housebutton
            // 
            this.Housebutton.AutoSize = true;
            this.Housebutton.Location = new System.Drawing.Point(549, 159);
            this.Housebutton.Name = "Housebutton";
            this.Housebutton.Size = new System.Drawing.Size(70, 21);
            this.Housebutton.TabIndex = 10;
            this.Housebutton.TabStop = true;
            this.Housebutton.Text = "House";
            this.Housebutton.UseVisualStyleBackColor = true;
            this.Housebutton.CheckedChanged += new System.EventHandler(this.Housebutton_CheckedChanged);
            // 
            // treeButton
            // 
            this.treeButton.AutoSize = true;
            this.treeButton.Location = new System.Drawing.Point(540, 236);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(54, 21);
            this.treeButton.TabIndex = 6;
            this.treeButton.TabStop = true;
            this.treeButton.Text = "tree";
            this.treeButton.UseVisualStyleBackColor = true;
            this.treeButton.CheckedChanged += new System.EventHandler(this.treeButton_CheckedChanged);
            // 
            // Watersourcebutton
            // 
            this.Watersourcebutton.AutoSize = true;
            this.Watersourcebutton.Location = new System.Drawing.Point(540, 199);
            this.Watersourcebutton.Name = "Watersourcebutton";
            this.Watersourcebutton.Size = new System.Drawing.Size(110, 21);
            this.Watersourcebutton.TabIndex = 5;
            this.Watersourcebutton.TabStop = true;
            this.Watersourcebutton.Text = "Watersource";
            this.Watersourcebutton.UseVisualStyleBackColor = true;
            this.Watersourcebutton.CheckedChanged += new System.EventHandler(this.Watersourcebutton_CheckedChanged);
            // 

            // Newbutton
            // 
            this.Newbutton.Location = new System.Drawing.Point(476, 328);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(75, 23);
            this.Newbutton.TabIndex = 7;
            this.Newbutton.Text = "New";
            this.Newbutton.UseVisualStyleBackColor = true;
            this.Newbutton.Click += new System.EventHandler(this.Newbutton_Click);
            // 
            // openbutton
            // 
            this.openbutton.Location = new System.Drawing.Point(619, 328);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(75, 23);
            this.openbutton.TabIndex = 8;
            this.openbutton.Text = "open";
            this.openbutton.UseVisualStyleBackColor = true;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(730, 328);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 9;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // createvillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 413);
            this.Controls.Add(this.Housebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.openbutton);
            this.Controls.Add(this.Newbutton);
            this.Controls.Add(this.treeButton);
            this.Controls.Add(this.Watersourcebutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "createvillage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton Watersourcebutton;
        private System.Windows.Forms.RadioButton treeButton;
        private System.Windows.Forms.Button Newbutton;
        private System.Windows.Forms.Button openbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.RadioButton Housebutton;
    }
}

