namespace Age_of_Villagers
{
    partial class ConfirmName
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
            this.VillageText = new System.Windows.Forms.TextBox();
            this.NationCombo = new System.Windows.Forms.ComboBox();
            this.ConfirmVillage = new System.Windows.Forms.Button();
            this.VillageNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VillageText
            // 
            this.VillageText.AccessibleName = "VillageText";
            this.VillageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageText.Cursor = System.Windows.Forms.Cursors.No;
            this.VillageText.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VillageText.Location = new System.Drawing.Point(100, 83);
            this.VillageText.Name = "VillageText";
            this.VillageText.Size = new System.Drawing.Size(200, 23);
            this.VillageText.TabIndex = 0;
            this.VillageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NationCombo
            // 
            this.NationCombo.AccessibleName = "NationCombo";
            this.NationCombo.Cursor = System.Windows.Forms.Cursors.No;
            this.NationCombo.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NationCombo.FormattingEnabled = true;
            this.NationCombo.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationCombo.Location = new System.Drawing.Point(100, 159);
            this.NationCombo.Name = "NationCombo";
            this.NationCombo.Size = new System.Drawing.Size(200, 26);
            this.NationCombo.TabIndex = 1;
            this.NationCombo.Text = "Select Nation Name";
            this.NationCombo.SelectedIndexChanged += new System.EventHandler(this.NationCombo_SelectedIndexChanged);
            // 
            // ConfirmVillage
            // 
            this.ConfirmVillage.AccessibleName = "ConfirmVillage";
            this.ConfirmVillage.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmVillage.Location = new System.Drawing.Point(140, 235);
            this.ConfirmVillage.Name = "ConfirmVillage";
            this.ConfirmVillage.Size = new System.Drawing.Size(120, 29);
            this.ConfirmVillage.TabIndex = 2;
            this.ConfirmVillage.Text = "Confirm Village";
            this.ConfirmVillage.UseVisualStyleBackColor = true;
            this.ConfirmVillage.Click += new System.EventHandler(this.ConfirmVillage_Click);
            // 
            // VillageNameLabel
            // 
            this.VillageNameLabel.AccessibleName = "VillageNameLabel";
            this.VillageNameLabel.AutoSize = true;
            this.VillageNameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VillageNameLabel.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VillageNameLabel.Location = new System.Drawing.Point(165, 58);
            this.VillageNameLabel.Name = "VillageNameLabel";
            this.VillageNameLabel.Size = new System.Drawing.Size(97, 18);
            this.VillageNameLabel.TabIndex = 3;
            this.VillageNameLabel.Text = "Village Name";
            this.VillageNameLabel.Click += new System.EventHandler(this.VillageNameLabel_Click_);
            // 
            // ConfirmName
            // 
            this.AccessibleName = "ConfirmName";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.VillageNameLabel);
            this.Controls.Add(this.ConfirmVillage);
            this.Controls.Add(this.NationCombo);
            this.Controls.Add(this.VillageText);
            this.Name = "ConfirmName";
            this.Text = "Confirm Name";
            this.Load += new System.EventHandler(this.SaveName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VillageText;
        private System.Windows.Forms.ComboBox NationCombo;
        private System.Windows.Forms.Button ConfirmVillage;
        private System.Windows.Forms.Label VillageNameLabel;
    }
}