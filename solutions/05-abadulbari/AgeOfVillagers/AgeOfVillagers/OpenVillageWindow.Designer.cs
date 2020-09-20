namespace AgeOfVillagers
{
    partial class OpenVillageWindow
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
            this.browseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.villageLabel = new System.Windows.Forms.Label();
            this.nationLabel = new System.Windows.Forms.Label();
            this.nationComBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(298, 63);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(112, 34);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(133, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 34);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(335, 260);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(112, 34);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // villageLabel
            // 
            this.villageLabel.AutoSize = true;
            this.villageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.villageLabel.Location = new System.Drawing.Point(71, 63);
            this.villageLabel.Name = "villageLabel";
            this.villageLabel.Size = new System.Drawing.Size(117, 27);
            this.villageLabel.TabIndex = 1;
            this.villageLabel.Text = "Select Village";
            this.villageLabel.Click += new System.EventHandler(this.villageLabel_Click);
            // 
            // nationLabel
            // 
            this.nationLabel.AutoSize = true;
            this.nationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nationLabel.Location = new System.Drawing.Point(71, 152);
            this.nationLabel.Name = "nationLabel";
            this.nationLabel.Size = new System.Drawing.Size(118, 27);
            this.nationLabel.TabIndex = 1;
            this.nationLabel.Text = "Select Nation";
            this.nationLabel.Click += new System.EventHandler(this.nationLabel_Click);
            // 
            // nationComBox
            // 
            this.nationComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationComBox.FormattingEnabled = true;
            this.nationComBox.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.nationComBox.Location = new System.Drawing.Point(235, 152);
            this.nationComBox.Name = "nationComBox";
            this.nationComBox.Size = new System.Drawing.Size(236, 33);
            this.nationComBox.TabIndex = 3;
            this.nationComBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OpenVillageWindow
            // 
            this.ClientSize = new System.Drawing.Size(600, 326);
            this.Controls.Add(this.nationComBox);
            this.Controls.Add(this.nationLabel);
            this.Controls.Add(this.villageLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.browseButton);
            this.Name = "OpenVillageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Village";
            this.Load += new System.EventHandler(this.OpenVillageWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button browsButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label villageLabel;
        private System.Windows.Forms.Label nationLabel;
        private System.Windows.Forms.ComboBox nationComBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button browseButton;
    }
}

