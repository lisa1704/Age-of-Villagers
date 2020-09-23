namespace empty_project
{
    partial class Form1
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
            this.SaveVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.NationBox = new System.Windows.Forms.ComboBox();
            this.GameTitle = new System.Windows.Forms.TextBox();
            this.SelectYourNation = new System.Windows.Forms.TextBox();
            this.radioButtonTree = new System.Windows.Forms.RadioButton();
            this.radioButtonHouse = new System.Windows.Forms.RadioButton();
            this.radioButtonWaterSource = new System.Windows.Forms.RadioButton();
            this.TypeVillageName = new System.Windows.Forms.TextBox();
            this.EnterText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(659, 332);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(91, 23);
            this.SaveVillage.TabIndex = 0;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // NewVillage
            // 
            this.NewVillage.Location = new System.Drawing.Point(606, 377);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(91, 23);
            this.NewVillage.TabIndex = 2;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Location = new System.Drawing.Point(703, 377);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(85, 23);
            this.OpenVillage.TabIndex = 3;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawingPanel.TabIndex = 7;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseClick);
            // 
            // NationBox
            // 
            this.NationBox.FormattingEnabled = true;
            this.NationBox.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationBox.Location = new System.Drawing.Point(640, 94);
            this.NationBox.Name = "NationBox";
            this.NationBox.Size = new System.Drawing.Size(121, 23);
            this.NationBox.TabIndex = 0;
            this.NationBox.SelectedIndexChanged += new System.EventHandler(this.NationBox_SelectedIndexChanged);
            // 
            // GameTitle
            // 
            this.GameTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.GameTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameTitle.Location = new System.Drawing.Point(616, 24);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(172, 26);
            this.GameTitle.TabIndex = 8;
            this.GameTitle.Text = "AGE OF VILLEGERS";
            this.GameTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectYourNation
            // 
            this.SelectYourNation.BackColor = System.Drawing.SystemColors.Menu;
            this.SelectYourNation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectYourNation.Location = new System.Drawing.Point(650, 72);
            this.SelectYourNation.Name = "SelectYourNation";
            this.SelectYourNation.Size = new System.Drawing.Size(100, 16);
            this.SelectYourNation.TabIndex = 9;
            this.SelectYourNation.Text = "Select your Nation";
            // 
            // radioButtonTree
            // 
            this.radioButtonTree.AutoSize = true;
            this.radioButtonTree.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonTree.Location = new System.Drawing.Point(671, 224);
            this.radioButtonTree.Name = "radioButtonTree";
            this.radioButtonTree.Size = new System.Drawing.Size(46, 19);
            this.radioButtonTree.TabIndex = 10;
            this.radioButtonTree.TabStop = true;
            this.radioButtonTree.Text = "Tree";
            this.radioButtonTree.UseVisualStyleBackColor = false;
            this.radioButtonTree.Click += new System.EventHandler(this.radioButtonTree_Click);
            // 
            // radioButtonHouse
            // 
            this.radioButtonHouse.AutoSize = true;
            this.radioButtonHouse.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonHouse.Location = new System.Drawing.Point(616, 264);
            this.radioButtonHouse.Name = "radioButtonHouse";
            this.radioButtonHouse.Size = new System.Drawing.Size(59, 19);
            this.radioButtonHouse.TabIndex = 11;
            this.radioButtonHouse.TabStop = true;
            this.radioButtonHouse.Text = "House";
            this.radioButtonHouse.UseVisualStyleBackColor = false;
            this.radioButtonHouse.Click += new System.EventHandler(this.radioButtonHouse_Click);
            // 
            // radioButtonWaterSource
            // 
            this.radioButtonWaterSource.AutoSize = true;
            this.radioButtonWaterSource.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonWaterSource.Location = new System.Drawing.Point(693, 264);
            this.radioButtonWaterSource.Name = "radioButtonWaterSource";
            this.radioButtonWaterSource.Size = new System.Drawing.Size(95, 19);
            this.radioButtonWaterSource.TabIndex = 12;
            this.radioButtonWaterSource.TabStop = true;
            this.radioButtonWaterSource.Text = "Water Source";
            this.radioButtonWaterSource.UseVisualStyleBackColor = false;
            this.radioButtonWaterSource.Click += new System.EventHandler(this.radioButtonWaterSource_Click);
            // 
            // TypeVillageName
            // 
            this.TypeVillageName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TypeVillageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeVillageName.Location = new System.Drawing.Point(640, 147);
            this.TypeVillageName.Name = "TypeVillageName";
            this.TypeVillageName.Size = new System.Drawing.Size(121, 16);
            this.TypeVillageName.TabIndex = 13;
            this.TypeVillageName.Text = "Type Village Name";
            this.TypeVillageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnterText
            // 
            this.EnterText.Location = new System.Drawing.Point(640, 169);
            this.EnterText.Name = "EnterText";
            this.EnterText.Size = new System.Drawing.Size(121, 23);
            this.EnterText.TabIndex = 14;
            this.EnterText.Click += new System.EventHandler(this.EnterText_Click);
            this.EnterText.TextChanged += new System.EventHandler(this.EnterText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterText);
            this.Controls.Add(this.TypeVillageName);
            this.Controls.Add(this.radioButtonWaterSource);
            this.Controls.Add(this.radioButtonHouse);
            this.Controls.Add(this.radioButtonTree);
            this.Controls.Add(this.SelectYourNation);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.NationBox);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.OpenVillage);
            this.Controls.Add(this.NewVillage);
            this.Controls.Add(this.SaveVillage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.ComboBox NationBox;
        private System.Windows.Forms.TextBox GameTitle;
        private System.Windows.Forms.TextBox SelectYourNation;
        private System.Windows.Forms.RadioButton radioButtonTree;
        private System.Windows.Forms.RadioButton radioButtonHouse;
        private System.Windows.Forms.RadioButton radioButtonWaterSource;
        private System.Windows.Forms.TextBox TypeVillageName;
        private System.Windows.Forms.TextBox EnterText;
    }
}

