namespace Age_of_Villagers
{
    partial class SelectVillage
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
            this.NationNameCombo = new System.Windows.Forms.ComboBox();
            this.SelectNationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NationNameCombo
            // 
            this.NationNameCombo.AccessibleName = "NationNameCombo";
            this.NationNameCombo.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NationNameCombo.FormattingEnabled = true;
            this.NationNameCombo.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationNameCombo.Location = new System.Drawing.Point(125, 125);
            this.NationNameCombo.Name = "NationNameCombo";
            this.NationNameCombo.Size = new System.Drawing.Size(150, 24);
            this.NationNameCombo.TabIndex = 0;
            this.NationNameCombo.Text = "Select Nation Name";
            this.NationNameCombo.SelectedIndexChanged += new System.EventHandler(this.NationNameCombo_SelectedIndexChanged);
            // 
            // SelectNationButton
            // 
            this.SelectNationButton.AccessibleName = "SelectNationButton";
            this.SelectNationButton.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectNationButton.Location = new System.Drawing.Point(125, 244);
            this.SelectNationButton.Name = "SelectNationButton";
            this.SelectNationButton.Size = new System.Drawing.Size(150, 29);
            this.SelectNationButton.TabIndex = 1;
            this.SelectNationButton.Text = "Select This Nation!";
            this.SelectNationButton.UseVisualStyleBackColor = true;
            this.SelectNationButton.Click += new System.EventHandler(this.SelectNationButton_Click);
            // 
            // SelectVillage
            // 
            this.AccessibleName = "SelectVillage";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.SelectNationButton);
            this.Controls.Add(this.NationNameCombo);
            this.Name = "SelectVillage";
            this.Text = "Select Village";
            this.Load += new System.EventHandler(this.SelectVillage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox NationNameCombo;
        private System.Windows.Forms.Button SelectNationButton;
    }
}