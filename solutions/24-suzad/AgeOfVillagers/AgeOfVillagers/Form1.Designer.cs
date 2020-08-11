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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.pnlDrawingSpace);
            this.Name = "Form1";
            this.Text = "Age of Villagers";
            this.pnlDrawingSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawingSpace;
        private System.Windows.Forms.Panel pnlToolSide;
    }
}

