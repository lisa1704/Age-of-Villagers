namespace Villagedetails
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
            this.Tree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.House = new System.Windows.Forms.Button();
            this.Watersource = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Savevillage = new System.Windows.Forms.Button();
            this.Newvillage = new System.Windows.Forms.Button();
            this.Openvillage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(713, 175);
            this.Tree.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(75, 23);
            this.Tree.TabIndex = 0;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age of villagers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(625, 175);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(75, 23);
            this.House.TabIndex = 2;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            // 
            // Watersource
            // 
            this.Watersource.Location = new System.Drawing.Point(657, 221);
            this.Watersource.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.Watersource.Name = "Watersource";
            this.Watersource.Size = new System.Drawing.Size(109, 23);
            this.Watersource.TabIndex = 3;
            this.Watersource.Text = "Watersource";
            this.Watersource.UseVisualStyleBackColor = true;
            this.Watersource.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Savevillage
            // 
            this.Savevillage.Location = new System.Drawing.Point(646, 285);
            this.Savevillage.Name = "Savevillage";
            this.Savevillage.Size = new System.Drawing.Size(130, 23);
            this.Savevillage.TabIndex = 5;
            this.Savevillage.Text = "Save Village";
            this.Savevillage.UseVisualStyleBackColor = true;
            // 
            // Newvillage
            // 
            this.Newvillage.Location = new System.Drawing.Point(548, 348);
            this.Newvillage.Name = "Newvillage";
            this.Newvillage.Size = new System.Drawing.Size(126, 23);
            this.Newvillage.TabIndex = 6;
            this.Newvillage.Text = "New village";
            this.Newvillage.UseVisualStyleBackColor = true;
            // 
            // Openvillage
            // 
            this.Openvillage.Location = new System.Drawing.Point(704, 347);
            this.Openvillage.Name = "Openvillage";
            this.Openvillage.Size = new System.Drawing.Size(128, 24);
            this.Openvillage.TabIndex = 7;
            this.Openvillage.Text = "Open village";
            this.Openvillage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 753);
            this.Controls.Add(this.Openvillage);
            this.Controls.Add(this.Newvillage);
            this.Controls.Add(this.Savevillage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Watersource);
            this.Controls.Add(this.House);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tree);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button Watersource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Savevillage;
        private System.Windows.Forms.Button Newvillage;
        private System.Windows.Forms.Button Openvillage;
    }
}

