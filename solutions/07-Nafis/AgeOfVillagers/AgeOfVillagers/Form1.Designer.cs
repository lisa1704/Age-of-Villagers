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
            this.drawingAreaPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // drawingAreaPanel
            // 
            this.drawingAreaPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawingAreaPanel.Location = new System.Drawing.Point(12, 12);
            this.drawingAreaPanel.Name = "drawingAreaPanel";
            this.drawingAreaPanel.Size = new System.Drawing.Size(600, 400);
            this.drawingAreaPanel.TabIndex = 12;
            // 
            // menuPanel
            // 
            this.menuPanel.Location = new System.Drawing.Point(618, 12);
            this.menuPanel.Name = "panel1";
            this.menuPanel.Size = new System.Drawing.Size(242, 400);
            this.menuPanel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 426);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.drawingAreaPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingAreaPanel;
        private System.Windows.Forms.Panel menuPanel;
    }
}

