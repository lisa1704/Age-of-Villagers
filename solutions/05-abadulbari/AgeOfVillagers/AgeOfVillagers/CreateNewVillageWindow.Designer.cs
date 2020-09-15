namespace AgeOfVillagers
{
    partial class CreateNewVillageWindow
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nationLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nationBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(150, 324);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 34);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(327, 324);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(112, 34);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(86, 77);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(127, 27);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Village Name :";
            // 
            // nationLabel
            // 
            this.nationLabel.AutoSize = true;
            this.nationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nationLabel.Location = new System.Drawing.Point(89, 160);
            this.nationLabel.Name = "nationLabel";
            this.nationLabel.Size = new System.Drawing.Size(118, 27);
            this.nationLabel.TabIndex = 1;
            this.nationLabel.Text = "Nation Type :";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(258, 77);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(181, 31);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // nationBox
            // 
            this.nationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationBox.FormattingEnabled = true;
            this.nationBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nationBox.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.nationBox.Location = new System.Drawing.Point(258, 160);
            this.nationBox.Name = "nationBox";
            this.nationBox.Size = new System.Drawing.Size(182, 33);
            this.nationBox.TabIndex = 3;
            this.nationBox.SelectedIndexChanged += new System.EventHandler(this.nationBox_SelectedIndexChanged);
            // 
            // CreateNewVillageWindow
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.nationBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nationLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "CreateNewVillageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new Village";
            this.Load += new System.EventHandler(this.CreateVillageWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox nationBox;
        private System.Windows.Forms.Label nationLabel;
        private System.Windows.Forms.Button createButton;
    }
}

