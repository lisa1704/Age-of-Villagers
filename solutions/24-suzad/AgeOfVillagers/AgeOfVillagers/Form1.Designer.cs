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
            this.pnlDrawingSpace = new System.Windows.Forms.Panel();
            this.pnlToolSide = new System.Windows.Forms.Panel();
            this.lblAgeOfVillagers = new System.Windows.Forms.Label();
            this.pnlDrawingSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawingSpace
            // 
            this.pnlDrawingSpace.Controls.Add(this.pnlToolSide);
            this.pnlDrawingSpace.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawingSpace.Name = "pnlDrawingSpace";
            this.pnlDrawingSpace.Size = new System.Drawing.Size(600, 400);
            this.pnlDrawingSpace.TabIndex = 0;
            // 
            // pnlToolSide
            // 
            this.pnlToolSide.Location = new System.Drawing.Point(601, 0);
            this.pnlToolSide.Name = "pnlToolSide";
            this.pnlToolSide.Size = new System.Drawing.Size(195, 400);
            this.pnlToolSide.TabIndex = 1;
            // 
            // lblAgeOfVillagers
            // 
            this.lblAgeOfVillagers.AutoSize = true;
            this.lblAgeOfVillagers.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgeOfVillagers.Location = new System.Drawing.Point(606, 9);
            this.lblAgeOfVillagers.Name = "lblAgeOfVillagers";
            this.lblAgeOfVillagers.Size = new System.Drawing.Size(185, 20);
            this.lblAgeOfVillagers.TabIndex = 1;
            this.lblAgeOfVillagers.Text = "Age of Villagers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lblAgeOfVillagers);
            this.Controls.Add(this.pnlDrawingSpace);
            this.Name = "Form1";
            this.Text = "Age of Villagers";
            this.pnlDrawingSpace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawingSpace;
        private System.Windows.Forms.Panel pnlToolSide;
        private System.Windows.Forms.Label lblAgeOfVillagers;
    }
}

