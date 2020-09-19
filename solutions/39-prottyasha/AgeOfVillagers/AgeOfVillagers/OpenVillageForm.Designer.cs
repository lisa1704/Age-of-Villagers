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
            this.SavedVillageList = new System.Windows.Forms.ComboBox();
            this.openvillagelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SavedVillageList
            // 
            this.SavedVillageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SavedVillageList.FormattingEnabled = true;
            this.SavedVillageList.Location = new System.Drawing.Point(107, 146);
            this.SavedVillageList.Name = "SavedVillageList";
            this.SavedVillageList.Size = new System.Drawing.Size(355, 28);
            this.SavedVillageList.TabIndex = 0;
            // 
            // openvillagelabel
            // 
            this.openvillagelabel.AutoSize = true;
            this.openvillagelabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openvillagelabel.Location = new System.Drawing.Point(156, 78);
            this.openvillagelabel.Name = "openvillagelabel";
            this.openvillagelabel.Size = new System.Drawing.Size(270, 31);
            this.openvillagelabel.TabIndex = 1;
            this.openvillagelabel.Text = "Select a village to open!";
            // 
            // OpenVillageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.openvillagelabel);
            this.Controls.Add(this.SavedVillageList);
            this.Name = "OpenVillageForm";
            this.Text = "OpenVillageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SavedVillageList;
        private System.Windows.Forms.Label openvillagelabel;
    }
}