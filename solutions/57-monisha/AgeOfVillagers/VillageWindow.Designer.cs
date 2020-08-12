namespace AgeOfVillagers
{
    partial class VillageWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.SAVEbutton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.OpenVbutton = new System.Windows.Forms.Button();
            this.NewVbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.NewVbutton);
            this.panel1.Controls.Add(this.OpenVbutton);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.SAVEbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.panel1.Location = new System.Drawing.Point(363, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 400);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age of Villagers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SAVEbutton
            // 
            this.SAVEbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SAVEbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SAVEbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVEbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SAVEbutton.Location = new System.Drawing.Point(41, 259);
            this.SAVEbutton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.SAVEbutton.Name = "SAVEbutton";
            this.SAVEbutton.Size = new System.Drawing.Size(130, 23);
            this.SAVEbutton.TabIndex = 1;
            this.SAVEbutton.Text = "SAVE VILLAGE";
            this.SAVEbutton.UseVisualStyleBackColor = true;
            this.SAVEbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(41, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "House";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(41, 129);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Tree";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(41, 157);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 24);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Water Source";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // OpenVbutton
            // 
            this.OpenVbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenVbutton.Location = new System.Drawing.Point(41, 328);
            this.OpenVbutton.Name = "OpenVbutton";
            this.OpenVbutton.Size = new System.Drawing.Size(130, 23);
            this.OpenVbutton.TabIndex = 6;
            this.OpenVbutton.Text = "OPEN VILLAGE";
            this.OpenVbutton.UseVisualStyleBackColor = true;
            // 
            // NewVbutton
            // 
            this.NewVbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVbutton.Location = new System.Drawing.Point(41, 290);
            this.NewVbutton.Name = "NewVbutton";
            this.NewVbutton.Size = new System.Drawing.Size(130, 23);
            this.NewVbutton.TabIndex = 7;
            this.NewVbutton.Text = "NEW VILLAGE";
            this.NewVbutton.UseVisualStyleBackColor = true;
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VillageWindow";
            this.RightToLeftLayout = true;
            this.Text = "Age Of Villagers";
            this.Load += new System.EventHandler(this.VillageWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button SAVEbutton;
        private System.Windows.Forms.Button OpenVbutton;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button NewVbutton;
    }
}