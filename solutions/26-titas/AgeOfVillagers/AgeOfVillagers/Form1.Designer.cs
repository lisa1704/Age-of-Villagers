namespace AgeOfVillagers
{
    partial class Form1
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
            this.gameName = new System.Windows.Forms.Label();
            this.villageName = new System.Windows.Forms.Label();
            this.nation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameName.Location = new System.Drawing.Point(609, 22);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(184, 31);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "Age of Villagers";
            this.gameName.Click += new System.EventHandler(this.label1_Click);
            // 
            // villageName
            // 
            this.villageName.AutoSize = true;
            this.villageName.Location = new System.Drawing.Point(668, 70);
            this.villageName.Name = "villageName";
            this.villageName.Size = new System.Drawing.Size(78, 20);
            this.villageName.TabIndex = 1;
            this.villageName.Text = "Kathakhali";
            this.villageName.Click += new System.EventHandler(this.villageName_Click);
            // 
            // nation
            // 
            this.nation.AutoSize = true;
            this.nation.Location = new System.Drawing.Point(626, 112);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(149, 20);
            this.nation.TabIndex = 2;
            this.nation.Text = "Balngladeshi Farmers";
            this.nation.Click += new System.EventHandler(this.nation_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.villageName);
            this.Controls.Add(this.gameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label villageName;
        private System.Windows.Forms.Label nation;
        private System.Windows.Forms.Panel panel1;
    }
}

