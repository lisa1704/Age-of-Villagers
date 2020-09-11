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
            System.Windows.Forms.Label MenuTopLabel;
            this.drawing_space = new System.Windows.Forms.Panel();
            this.menuBar = new System.Windows.Forms.Panel();
            MenuTopLabel = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawing_space
            // 
            this.drawing_space.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawing_space.Location = new System.Drawing.Point(12, 12);
            this.drawing_space.Name = "drawing_space";
            this.drawing_space.Padding = new System.Windows.Forms.Padding(5);
            this.drawing_space.Size = new System.Drawing.Size(600, 400);
            this.drawing_space.TabIndex = 0;
            this.drawing_space.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_space_Paint);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuBar.Controls.Add(MenuTopLabel);
            this.menuBar.Location = new System.Drawing.Point(611, 12);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(200, 400);
            this.menuBar.TabIndex = 1;
            // 
            // MenuTopLabel
            // 
            MenuTopLabel.AutoSize = true;
            MenuTopLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MenuTopLabel.Location = new System.Drawing.Point(17, 42);
            MenuTopLabel.Name = "MenuTopLabel";
            MenuTopLabel.Size = new System.Drawing.Size(167, 24);
            MenuTopLabel.TabIndex = 0;
            MenuTopLabel.Text = "Age of Villagers";
            MenuTopLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 454);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.drawing_space);
            this.Name = "VillageWindow";
            this.Text = "Village Window";
            this.Load += new System.EventHandler(this.VillageWindow_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawing_space;
        private System.Windows.Forms.Panel menuBar;
    }
}

