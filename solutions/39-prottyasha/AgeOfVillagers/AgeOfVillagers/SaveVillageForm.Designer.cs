namespace AgeOfVillagers
{
    partial class SaveVillageForm
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
            this.label1savevill = new System.Windows.Forms.Label();
            this.textbox_VillageName = new System.Windows.Forms.TextBox();
            this.save_villName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1savevill
            // 
            this.label1savevill.AutoSize = true;
            this.label1savevill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1savevill.Location = new System.Drawing.Point(130, 79);
            this.label1savevill.Name = "label1savevill";
            this.label1savevill.Size = new System.Drawing.Size(313, 31);
            this.label1savevill.TabIndex = 0;
            this.label1savevill.Text = "Give a name to your village!";
            // 
            // textbox_VillageName
            // 
            this.textbox_VillageName.Location = new System.Drawing.Point(130, 145);
            this.textbox_VillageName.Name = "textbox_VillageName";
            this.textbox_VillageName.Size = new System.Drawing.Size(313, 27);
            this.textbox_VillageName.TabIndex = 1;
            this.textbox_VillageName.TextChanged += new System.EventHandler(this.textbox_VillageName_TextChanged);
            // 
            // save_villName
            // 
            this.save_villName.Location = new System.Drawing.Point(248, 188);
            this.save_villName.Name = "save_villName";
            this.save_villName.Size = new System.Drawing.Size(94, 29);
            this.save_villName.TabIndex = 2;
            this.save_villName.Text = "Save";
            this.save_villName.UseVisualStyleBackColor = true;
            // 
            // SaveVillageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.save_villName);
            this.Controls.Add(this.textbox_VillageName);
            this.Controls.Add(this.label1savevill);
            this.Name = "SaveVillageForm";
            this.Text = "SaveVillageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1savevill;
        private System.Windows.Forms.TextBox textbox_VillageName;
        private System.Windows.Forms.Button save_villName;
    }
}