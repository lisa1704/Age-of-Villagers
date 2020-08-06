namespace Age_Of_Villagers
{
    partial class AgeOfVillagers
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
            this.VillageNameEditor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_AOV = new System.Windows.Forms.Label();
            this.NationSelector = new System.Windows.Forms.DomainUpDown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VillageNameEditor
            // 
            this.VillageNameEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VillageNameEditor.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VillageNameEditor.Location = new System.Drawing.Point(66, 101);
            this.VillageNameEditor.Name = "VillageNameEditor";
            this.VillageNameEditor.Size = new System.Drawing.Size(191, 29);
            this.VillageNameEditor.TabIndex = 3;
            this.VillageNameEditor.Text = " Village Name";
            this.VillageNameEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.NationSelector);
            this.panel1.Controls.Add(this.Label_AOV);
            this.panel1.Controls.Add(this.VillageNameEditor);
            this.panel1.Location = new System.Drawing.Point(819, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 655);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Label_AOV
            // 
            this.Label_AOV.AutoSize = true;
            this.Label_AOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AOV.Location = new System.Drawing.Point(61, 21);
            this.Label_AOV.Name = "Label_AOV";
            this.Label_AOV.Size = new System.Drawing.Size(203, 29);
            this.Label_AOV.TabIndex = 4;
            this.Label_AOV.Text = "Age Of Villagers";
            // 
            // NationSelector
            // 
            this.NationSelector.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationSelector.Items.Add("Bangladeshi Farmers");
            this.NationSelector.Items.Add("Arab Bedouin");
            this.NationSelector.Items.Add("Egyptian Kings");
            this.NationSelector.Items.Add("Inuit Hunters");
            this.NationSelector.Location = new System.Drawing.Point(66, 185);
            this.NationSelector.Name = "NationSelector";
            this.NationSelector.Size = new System.Drawing.Size(198, 29);
            this.NationSelector.TabIndex = 6;
            this.NationSelector.Text = "Nation";
            this.NationSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgeOfVillagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 653);
            this.Controls.Add(this.panel1);
            this.Name = "AgeOfVillagers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox VillageNameEditor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DomainUpDown NationSelector;
        private System.Windows.Forms.Label Label_AOV;
    }
}

