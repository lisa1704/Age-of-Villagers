namespace age_of_villagers
{
    partial class villageEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveVillageButton = new System.Windows.Forms.Button();
            this.openVillageButton = new System.Windows.Forms.Button();
            this.newVillageButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nationNameTextBox = new System.Windows.Forms.TextBox();
            this.villageNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.nationNameTextBox);
            this.panel2.Controls.Add(this.villageNameTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(612, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 389);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveVillageButton);
            this.groupBox2.Controls.Add(this.openVillageButton);
            this.groupBox2.Controls.Add(this.newVillageButton);
            this.groupBox2.Location = new System.Drawing.Point(21, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Village Edit";
            // 
            // saveVillageButton
            // 
            this.saveVillageButton.AutoEllipsis = true;
            this.saveVillageButton.Location = new System.Drawing.Point(53, 26);
            this.saveVillageButton.Name = "saveVillageButton";
            this.saveVillageButton.Size = new System.Drawing.Size(106, 29);
            this.saveVillageButton.TabIndex = 0;
            this.saveVillageButton.Text = "Save Village";
            this.saveVillageButton.UseVisualStyleBackColor = true;
            this.saveVillageButton.Click += new System.EventHandler(this.saveVillageButton_Click);
            // 
            // openVillageButton
            // 
            this.openVillageButton.Location = new System.Drawing.Point(112, 63);
            this.openVillageButton.Name = "openVillageButton";
            this.openVillageButton.Size = new System.Drawing.Size(106, 29);
            this.openVillageButton.TabIndex = 0;
            this.openVillageButton.Text = "Open Village";
            this.openVillageButton.UseVisualStyleBackColor = true;
            this.openVillageButton.Click += new System.EventHandler(this.openVillageButton_Click);
            // 
            // newVillageButton
            // 
            this.newVillageButton.Location = new System.Drawing.Point(0, 63);
            this.newVillageButton.Name = "newVillageButton";
            this.newVillageButton.Size = new System.Drawing.Size(106, 29);
            this.newVillageButton.TabIndex = 0;
            this.newVillageButton.Text = "New Village";
            this.newVillageButton.UseVisualStyleBackColor = true;
            this.newVillageButton.Click += new System.EventHandler(this.newVillageButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(18, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "Water Source";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "House";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tree";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nationNameTextBox
            // 
            this.nationNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nationNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nationNameTextBox.Location = new System.Drawing.Point(18, 111);
            this.nationNameTextBox.Name = "nationNameTextBox";
            this.nationNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.nationNameTextBox.TabIndex = 2;
            this.nationNameTextBox.Text = "Enter Nation Name";
            this.nationNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nationNameTextBox.Enter += new System.EventHandler(this.nationNameTextBox_enter);
            this.nationNameTextBox.Leave += new System.EventHandler(this.nationNameTextBox_leave);
            // 
            // villageNameTextBox
            // 
            this.villageNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.villageNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.villageNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.villageNameTextBox.Location = new System.Drawing.Point(18, 63);
            this.villageNameTextBox.Name = "villageNameTextBox";
            this.villageNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.villageNameTextBox.TabIndex = 1;
            this.villageNameTextBox.Text = "Enter Village Name";
            this.villageNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.villageNameTextBox.Enter += new System.EventHandler(this.villageNameTextBox_enter);
            this.villageNameTextBox.Leave += new System.EventHandler(this.villageNameTextBox_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age Of Villagers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // villageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "villageEditor";
            this.Text = "Village Editor";
            this.Load += new System.EventHandler(this.villageEditor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nationNameTextBox;
        private System.Windows.Forms.TextBox villageNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveVillageButton;
        private System.Windows.Forms.Button openVillageButton;
        private System.Windows.Forms.Button newVillageButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

