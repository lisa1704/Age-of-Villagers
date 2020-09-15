namespace AgeOfVillagers
{
    partial class VillageEditor
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.aovLabel = new System.Windows.Forms.Label();
            this.villageName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.drawingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Controls.Add(this.toolsPanel);
            this.drawingPanel.Location = new System.Drawing.Point(1, 1);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(600, 400);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick1_drawingPanel);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Location = new System.Drawing.Point(597, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(200, 400);
            this.toolsPanel.TabIndex = 3;
            // 
            // aovLabel
            // 
            this.aovLabel.AutoSize = true;
            this.aovLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aovLabel.Location = new System.Drawing.Point(621, 25);
            this.aovLabel.Name = "aovLabel";
            this.aovLabel.Size = new System.Drawing.Size(167, 24);
            this.aovLabel.TabIndex = 1;
            this.aovLabel.Text = "Age of Villagers";
            this.aovLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // villageName
            // 
            this.villageName.Location = new System.Drawing.Point(621, 64);
            this.villageName.Name = "villageName";
            this.villageName.Size = new System.Drawing.Size(167, 23);
            this.villageName.TabIndex = 2;
            this.villageName.TextChanged += new System.EventHandler(this.villageName_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(652, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Village";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(604, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "New Village";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(704, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Open Village";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(604, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tree";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(652, 186);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 25);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Water Source";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(704, 156);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 24);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "House";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.listBox1.Location = new System.Drawing.Point(621, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 20);
            this.listBox1.TabIndex = 5;
            this.listBox1.Tag = " ";
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick_NationList);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // VillageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.villageName);
            this.Controls.Add(this.aovLabel);
            this.Name = "VillageEditor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VillageEditor_Load_1);
            this.drawingPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label aovLabel;
        private System.Windows.Forms.TextBox villageName;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

