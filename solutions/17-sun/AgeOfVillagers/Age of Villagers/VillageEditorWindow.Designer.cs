using System.Windows.Forms;

namespace Age_of_Villagers
{
    partial class VillageEditorWindow : Form
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
            this.VillageEditorPanel = new System.Windows.Forms.Panel();
            this.GameTitle = new System.Windows.Forms.Label();
            this.VillageTitle = new System.Windows.Forms.Label();
            this.NationTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VillageEditorPanel
            // 
            this.VillageEditorPanel.Location = new System.Drawing.Point(12, 12);
            this.VillageEditorPanel.Name = "VillageEditorPanel";
            this.VillageEditorPanel.Size = new System.Drawing.Size(600, 400);
            this.VillageEditorPanel.TabIndex = 1;
            this.VillageEditorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.VillageEditorPanel_Paint);
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameTitle.Location = new System.Drawing.Point(645, 32);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(207, 37);
            this.GameTitle.TabIndex = 2;
            this.GameTitle.Text = "Age of Villagers";
            // 
            // VillageTitle
            // 
            this.VillageTitle.AutoSize = true;
            this.VillageTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VillageTitle.Location = new System.Drawing.Point(691, 88);
            this.VillageTitle.Name = "VillageTitle";
            this.VillageTitle.Size = new System.Drawing.Size(104, 23);
            this.VillageTitle.TabIndex = 3;
            this.VillageTitle.Text = "Add Village";
            this.VillageTitle.Click += new System.EventHandler(this.VillageTitle_Click);
            // 
            // NationTitle
            // 
            this.NationTitle.AutoSize = true;
            this.NationTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NationTitle.Location = new System.Drawing.Point(691, 128);
            this.NationTitle.Name = "NationTitle";
            this.NationTitle.Size = new System.Drawing.Size(103, 23);
            this.NationTitle.TabIndex = 4;
            this.NationTitle.Text = "Add Nation";
            this.NationTitle.Click += new System.EventHandler(this.NationTitle_Click);
            // 
            // VillageEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 412);
            this.Controls.Add(this.NationTitle);
            this.Controls.Add(this.VillageTitle);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.VillageEditorPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "VillageEditorWindow";
            this.Text = "Village Editor";
            this.Load += new System.EventHandler(this.VillageEditorWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Panel VillageEditorPanel;
        private Label GameTitle;
        private Label VillageTitle;
        private Label NationTitle;
    }
}

 