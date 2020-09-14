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
            this.aovLabel = new System.Windows.Forms.Label();
            this.villageName = new System.Windows.Forms.TextBox();
            this.nation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(1, 1);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(600, 400);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // aovLabel
            // 
            this.aovLabel.AutoSize = true;
            this.aovLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aovLabel.Location = new System.Drawing.Point(621, 22);
            this.aovLabel.Name = "aovLabel";
            this.aovLabel.Size = new System.Drawing.Size(167, 24);
            this.aovLabel.TabIndex = 1;
            this.aovLabel.Text = "Age of Villagers";
            this.aovLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // villageName
            // 
            this.villageName.Location = new System.Drawing.Point(621, 65);
            this.villageName.Name = "villageName";
            this.villageName.Size = new System.Drawing.Size(167, 23);
            this.villageName.TabIndex = 2;
            // 
            // nation
            // 
            this.nation.Location = new System.Drawing.Point(621, 94);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(167, 23);
            this.nation.TabIndex = 2;
            // 
            // VillageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.villageName);
            this.Controls.Add(this.aovLabel);
            this.Controls.Add(this.drawingPanel);
            this.Name = "VillageEditor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label aovLabel;
        private System.Windows.Forms.TextBox villageName;
        private System.Windows.Forms.TextBox nation;
        private System.Windows.Forms.Panel drawingPanel;
    }
}

