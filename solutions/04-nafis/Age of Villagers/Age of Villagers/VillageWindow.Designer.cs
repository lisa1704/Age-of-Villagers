namespace Age_of_Villagers
{
    partial class VillageWindow
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
            this.VillageDrawing = new System.Windows.Forms.Panel();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // VillageDrawing
            // 
            this.VillageDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageDrawing.Location = new System.Drawing.Point(1, 0);
            this.VillageDrawing.Name = "VillageDrawing";
            this.VillageDrawing.Size = new System.Drawing.Size(450, 400);
            this.VillageDrawing.TabIndex = 0;
            // 
            // MenuBar
            // 
            this.MenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuBar.Location = new System.Drawing.Point(452, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuBar.Size = new System.Drawing.Size(150, 400);
            this.MenuBar.TabIndex = 1;
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 408);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.VillageDrawing);
            this.Name = "VillageWindow";
            this.Text = "Age of Villagers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VillageDrawing;
        private System.Windows.Forms.Panel MenuBar;
    }
}

