namespace AgeOfVillagers
{
    partial class OpenVillageNation
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
            this.Opencombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Opencombobox
            // 
            this.Opencombobox.FormattingEnabled = true;
            this.Opencombobox.Location = new System.Drawing.Point(13, 54);
            this.Opencombobox.Name = "Opencombobox";
            this.Opencombobox.Items.AddRange(new object[] {
            "Arab Bedouin",
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.Opencombobox.Size = new System.Drawing.Size(164, 23);
            this.Opencombobox.TabIndex = 0;
            this.Opencombobox.SelectedIndexChanged += new System.EventHandler(this.Opencomboboc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Nation For Opening";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(371, 106);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(80, 30);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(271, 106);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(80, 30);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // OpenVillageNation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 148);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Opencombobox);
            this.Name = "OpenVillageNation";
            this.Text = "OpenVillageNation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Opencombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}