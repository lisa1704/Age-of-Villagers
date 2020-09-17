namespace AgeOfVillagers
{
    partial class VillageWindow
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.openButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.waterRadioBtn = new System.Windows.Forms.RadioButton();
            this.houseRadioBtn = new System.Windows.Forms.RadioButton();
            this.treeRadioBtn = new System.Windows.Forms.RadioButton();
            this.nationLabel = new System.Windows.Forms.Label();
            this.villageLabel = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.drawingPanel.Location = new System.Drawing.Point(0, 0);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(600, 400);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseClick);
            // 
            // toolPanel
            // 
            this.toolPanel.AllowDrop = true;
            this.toolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toolPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolPanel.Controls.Add(this.openButton);
            this.toolPanel.Controls.Add(this.newButton);
            this.toolPanel.Controls.Add(this.saveButton);
            this.toolPanel.Controls.Add(this.waterRadioBtn);
            this.toolPanel.Controls.Add(this.houseRadioBtn);
            this.toolPanel.Controls.Add(this.treeRadioBtn);
            this.toolPanel.Controls.Add(this.nationLabel);
            this.toolPanel.Controls.Add(this.villageLabel);
            this.toolPanel.Controls.Add(this.gameLabel);
            this.toolPanel.Location = new System.Drawing.Point(600, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(200, 400);
            this.toolPanel.TabIndex = 1;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.openButton.Location = new System.Drawing.Point(38, 354);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(133, 34);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open Village";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newButton.Location = new System.Drawing.Point(39, 314);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(132, 34);
            this.newButton.TabIndex = 4;
            this.newButton.Text = "New Village";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.Location = new System.Drawing.Point(38, 274);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 34);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Village";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // waterRadioBtn
            // 
            this.waterRadioBtn.AutoSize = true;
            this.waterRadioBtn.Location = new System.Drawing.Point(38, 215);
            this.waterRadioBtn.Name = "waterRadioBtn";
            this.waterRadioBtn.Size = new System.Drawing.Size(142, 29);
            this.waterRadioBtn.TabIndex = 3;
            this.waterRadioBtn.TabStop = true;
            this.waterRadioBtn.Text = "Water Source";
            this.waterRadioBtn.UseVisualStyleBackColor = true;
            this.waterRadioBtn.CheckedChanged += new System.EventHandler(this.waterRadioBtn_CheckedChanged);
            // 
            // houseRadioBtn
            // 
            this.houseRadioBtn.AutoSize = true;
            this.houseRadioBtn.Location = new System.Drawing.Point(38, 180);
            this.houseRadioBtn.Name = "houseRadioBtn";
            this.houseRadioBtn.Size = new System.Drawing.Size(88, 29);
            this.houseRadioBtn.TabIndex = 3;
            this.houseRadioBtn.TabStop = true;
            this.houseRadioBtn.Text = "House";
            this.houseRadioBtn.UseVisualStyleBackColor = true;
            this.houseRadioBtn.CheckedChanged += new System.EventHandler(this.houseRadioBtn_CheckedChanged);
            // 
            // treeRadioBtn
            // 
            this.treeRadioBtn.AutoSize = true;
            this.treeRadioBtn.Location = new System.Drawing.Point(38, 145);
            this.treeRadioBtn.Name = "treeRadioBtn";
            this.treeRadioBtn.Size = new System.Drawing.Size(68, 29);
            this.treeRadioBtn.TabIndex = 3;
            this.treeRadioBtn.TabStop = true;
            this.treeRadioBtn.Text = "Tree";
            this.treeRadioBtn.UseVisualStyleBackColor = true;
            this.treeRadioBtn.CheckedChanged += new System.EventHandler(this.treeRadioBtn_CheckedChanged);
            // 
            // nationLabel
            // 
            this.nationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nationLabel.Location = new System.Drawing.Point(2, 88);
            this.nationLabel.Name = "nationLabel";
            this.nationLabel.Size = new System.Drawing.Size(196, 28);
            this.nationLabel.TabIndex = 2;
            this.nationLabel.Text = "Nation Name";
            this.nationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nationLabel.Click += new System.EventHandler(this.nationLabel_Click);
            // 
            // villageLabel
            // 
            this.villageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.villageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.villageLabel.Location = new System.Drawing.Point(2, 45);
            this.villageLabel.Name = "villageLabel";
            this.villageLabel.Size = new System.Drawing.Size(196, 28);
            this.villageLabel.TabIndex = 1;
            this.villageLabel.Text = "Village Name";
            this.villageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.villageLabel.Click += new System.EventHandler(this.villageLabel_Click);
            // 
            // gameLabel
            // 
            this.gameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameLabel.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameLabel.Location = new System.Drawing.Point(2, 9);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(196, 30);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.Text = "Age Of Villagers";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameLabel.Click += new System.EventHandler(this.gameLabel_Click);
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.drawingPanel);
            this.Name = "VillageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age of Villagers";
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Label gameLabel;
        public System.Windows.Forms.Label nationLabel;
        public System.Windows.Forms.Label villageLabel;
        private System.Windows.Forms.RadioButton waterButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton treeButton;
        private System.Windows.Forms.RadioButton houseButton;
        private System.Windows.Forms.RadioButton treeRadioBtn;
        private System.Windows.Forms.RadioButton houseRadioBtn;
        private System.Windows.Forms.RadioButton waterRadioBtn;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
    }
}

