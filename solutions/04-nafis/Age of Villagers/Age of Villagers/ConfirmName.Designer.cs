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
            this.VillageNameText = new System.Windows.Forms.TextBox();
            this.NationNameCombo = new System.Windows.Forms.ComboBox();
            this.ConfirmVillage = new System.Windows.Forms.Button();
            this.VillageNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VillageNameText
            // 
            this.VillageNameText.AccessibleName = "VillageNameText";
            this.VillageNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageNameText.Cursor = System.Windows.Forms.Cursors.No;
            this.VillageNameText.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VillageNameText.Location = new System.Drawing.Point(100, 83);
            this.VillageNameText.Name = "VillageNameText";
            this.VillageNameText.Size = new System.Drawing.Size(200, 23);
            this.VillageNameText.TabIndex = 0;
            this.VillageNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VillageNameText.TextChanged += new System.EventHandler(this.VillageNameText_TextChanged);
            // 
            // NationNameCombo
            // 
            this.NationNameCombo.AccessibleName = "NationNameCombo";
            this.NationNameCombo.Cursor = System.Windows.Forms.Cursors.No;
            this.NationNameCombo.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NationNameCombo.FormattingEnabled = true;
            this.NationNameCombo.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationNameCombo.Location = new System.Drawing.Point(100, 159);
            this.NationNameCombo.Name = "NationNameCombo";
            this.NationNameCombo.Size = new System.Drawing.Size(200, 26);
            this.NationNameCombo.TabIndex = 1;
            this.NationNameCombo.Text = "Select Nation Name";
            this.NationNameCombo.SelectedIndexChanged += new System.EventHandler(this.NationCombo_SelectedIndexChanged);
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
            this.VillageNameLabel.Size = new System.Drawing.Size(80, 15);
            this.VillageNameLabel.TabIndex = 3;
            this.VillageNameLabel.Text = "Village Name";
            this.VillageNameLabel.Click += new System.EventHandler(this.VillageNameLabel_Click_);
            // 
            // ConfirmName
            // 
            this.AccessibleName = "ConfirmName";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400,400);
            this.Controls.Add(this.VillageNameLabel);
            this.Controls.Add(this.ConfirmVillage);
            this.Controls.Add(this.NationNameCombo);
            this.Controls.Add(this.VillageNameText);
            this.Name = "ConfirmName";
            this.Text = "Confirm Name";
            this.Load += new System.EventHandler(this.SaveName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VillageNameText;
        private System.Windows.Forms.ComboBox NationNameCombo;
        private System.Windows.Forms.Button ConfirmVillage;
        private System.Windows.Forms.Label VillageNameLabel;
    }
}