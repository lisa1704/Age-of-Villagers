namespace AgeOfVillagers
{
    partial class OpenVillageForm
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
            this.btnChooseVillage = new System.Windows.Forms.Button();
            this.cmboChooseNation = new System.Windows.Forms.ComboBox();
            this.lblChooseNation = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseVillage
            // 
            this.btnChooseVillage.Location = new System.Drawing.Point(77, 144);
            this.btnChooseVillage.Name = "btnChooseVillage";
            this.btnChooseVillage.Size = new System.Drawing.Size(169, 56);
            this.btnChooseVillage.TabIndex = 0;
            this.btnChooseVillage.Text = "Choose village";
            this.btnChooseVillage.UseVisualStyleBackColor = true;
            this.btnChooseVillage.Click += new System.EventHandler(this.btnChooseVillage_Click);
            // 
            // cmboChooseNation
            // 
            this.cmboChooseNation.FormattingEnabled = true;
            this.cmboChooseNation.Items.AddRange(new object[] {
            "Bangladeshi Farmer",
            "Arab Bedouin",
            "Egyptian King",
            "Inuit Hunter"});
            this.cmboChooseNation.Location = new System.Drawing.Point(440, 159);
            this.cmboChooseNation.Name = "cmboChooseNation";
            this.cmboChooseNation.Size = new System.Drawing.Size(301, 28);
            this.cmboChooseNation.TabIndex = 1;
            // 
            // lblChooseNation
            // 
            this.lblChooseNation.AutoSize = true;
            this.lblChooseNation.Location = new System.Drawing.Point(330, 167);
            this.lblChooseNation.Name = "lblChooseNation";
            this.lblChooseNation.Size = new System.Drawing.Size(104, 20);
            this.lblChooseNation.TabIndex = 2;
            this.lblChooseNation.Text = "Choose nation";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(340, 359);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(532, 359);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 29);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openVillageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblChooseNation);
            this.Controls.Add(this.cmboChooseNation);
            this.Controls.Add(this.btnChooseVillage);
            this.Name = "openVillageForm";
            this.Text = "Open Village Form";
            this.Load += new System.EventHandler(this.openVillageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseVillage;
        private System.Windows.Forms.ComboBox cmboChooseNation;
        private System.Windows.Forms.Label lblChooseNation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOpen;
    }
}