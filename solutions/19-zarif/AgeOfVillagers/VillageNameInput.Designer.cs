namespace AgeOfVillagers
{
    partial class VillageNameInput
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
            this.nametextbx = new System.Windows.Forms.TextBox();
            this.vlgdemoname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nametextbx
            // 
            this.nametextbx.Location = new System.Drawing.Point(115, 13);
            this.nametextbx.Name = "nametextbx";
            this.nametextbx.Size = new System.Drawing.Size(244, 23);
            this.nametextbx.TabIndex = 0;
            this.nametextbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vlgdemoname
            // 
            this.vlgdemoname.AutoSize = true;
            this.vlgdemoname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vlgdemoname.Location = new System.Drawing.Point(13, 13);
            this.vlgdemoname.Name = "vlgdemoname";
            this.vlgdemoname.Size = new System.Drawing.Size(96, 19);
            this.vlgdemoname.TabIndex = 1;
            this.vlgdemoname.Text = "Village Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nation Name : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arab Bedouin",
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.comboBox1.Location = new System.Drawing.Point(115, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmButton.Location = new System.Drawing.Point(283, 90);
            this.ConfirmButton.MaximumSize = new System.Drawing.Size(75, 29);
            this.ConfirmButton.MinimumSize = new System.Drawing.Size(75, 29);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 29);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // VillageNameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 131);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vlgdemoname);
            this.Controls.Add(this.nametextbx);
            this.MaximumSize = new System.Drawing.Size(395, 170);
            this.MinimumSize = new System.Drawing.Size(395, 170);
            this.Name = "VillageNameInput";
            this.Text = "VillageNameInput";
            this.Load += new System.EventHandler(this.VillageNameInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametextbx;
        private System.Windows.Forms.Label vlgdemoname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ConfirmButton;
    }
}