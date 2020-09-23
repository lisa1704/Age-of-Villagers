namespace AgeOfVillagers
{
    partial class VillageForm
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
            this.drawingBoard = new System.Windows.Forms.Panel();
            this.Village = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.Nation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingBoard
            // 
            this.drawingBoard.BackColor = System.Drawing.Color.Azure;
            this.drawingBoard.Location = new System.Drawing.Point(12, 12);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(600, 400);
            this.drawingBoard.TabIndex = 0;
            this.drawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBoard_Paint);
            this.drawingBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseClick);
            // 
            // Village
            // 
            this.Village.AutoSize = true;
            this.Village.Location = new System.Drawing.Point(78, 60);
            this.Village.Name = "Village";
            this.Village.Size = new System.Drawing.Size(59, 20);
            this.Village.TabIndex = 8;
            this.Village.Text = "Village ";
            this.Village.Click += new System.EventHandler(this.villageName_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.Controls.Add(this.Nation);
            this.sidepanel.Controls.Add(this.label1);
            this.sidepanel.Controls.Add(this.button3);
            this.sidepanel.Controls.Add(this.button2);
            this.sidepanel.Controls.Add(this.button1);
            this.sidepanel.Controls.Add(this.radioButton3);
            this.sidepanel.Controls.Add(this.radioButton2);
            this.sidepanel.Controls.Add(this.radioButton1);
            this.sidepanel.Controls.Add(this.Village);
            this.sidepanel.Location = new System.Drawing.Point(621, 12);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(224, 400);
            this.sidepanel.TabIndex = 13;
            // 
            // Nation
            // 
            this.Nation.FormattingEnabled = true;
            this.Nation.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Beduins",
            "Egyptian King",
            "Inuit Hunter"});
            this.Nation.Location = new System.Drawing.Point(30, 93);
            this.Nation.Name = "Nation";
            this.Nation.Size = new System.Drawing.Size(151, 28);
            this.Nation.TabIndex = 13;
            this.Nation.Text = "Nation";
            this.Nation.SelectedIndexChanged += new System.EventHandler(this.Nation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Age Of Villagers";
            this.label1.Click += new System.EventHandler(this.header_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkKhaki;
            this.button3.Location = new System.Drawing.Point(111, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Open Village";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.open_button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(3, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "New Village";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.new_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(39, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Village";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.save_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Chocolate;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(122, 160);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 24);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "House";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.house_button_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(53, 189);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 24);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Water Source";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.water_button_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Green;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(30, 159);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tree";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.tree_changed_CheckedChanged);
            // 
            // VillageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 508);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.drawingBoard);
            this.Name = "VillageForm";
            this.Text = "Form1";
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingBoard;
        private System.Windows.Forms.Label Village;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox Nation;
    }
}

