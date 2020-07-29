namespace Age_of_Villagers
{
    partial class VillageWindow
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
            this.villagePanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.gameLabel = new System.Windows.Forms.Label();
            this.nationList = new System.Windows.Forms.ListBox();
            this.openButton = new System.Windows.Forms.Button();
            this.waterfallButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.treeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.houseBotton = new System.Windows.Forms.Button();
            this.villageNameBox = new System.Windows.Forms.TextBox();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // villagePanel
            // 
            this.villagePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.villagePanel.Location = new System.Drawing.Point(12, 12);
            this.villagePanel.Name = "villagePanel";
            this.villagePanel.Size = new System.Drawing.Size(600, 400);
            this.villagePanel.TabIndex = 12;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuPanel.Controls.Add(this.gameLabel);
            this.menuPanel.Controls.Add(this.nationList);
            this.menuPanel.Controls.Add(this.openButton);
            this.menuPanel.Controls.Add(this.waterfallButton);
            this.menuPanel.Controls.Add(this.newButton);
            this.menuPanel.Controls.Add(this.treeButton);
            this.menuPanel.Controls.Add(this.saveButton);
            this.menuPanel.Controls.Add(this.houseBotton);
            this.menuPanel.Controls.Add(this.villageNameBox);
            this.menuPanel.Location = new System.Drawing.Point(618, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(254, 439);
            this.menuPanel.TabIndex = 13;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.Location = new System.Drawing.Point(55, 48);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(160, 24);
            this.gameLabel.TabIndex = 4;
            this.gameLabel.Text = "Age Of Villagers";
            // 
            // nationList
            // 
            this.nationList.FormattingEnabled = true;
            this.nationList.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.nationList.Location = new System.Drawing.Point(42, 135);
            this.nationList.Name = "nationList";
            this.nationList.Size = new System.Drawing.Size(173, 56);
            this.nationList.TabIndex = 5;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openButton.Location = new System.Drawing.Point(140, 346);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 30);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open Village";
            this.openButton.UseVisualStyleBackColor = false;
            // 
            // waterfallButton
            // 
            this.waterfallButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.waterfallButton.Location = new System.Drawing.Point(85, 238);
            this.waterfallButton.Name = "waterfallButton";
            this.waterfallButton.Size = new System.Drawing.Size(75, 23);
            this.waterfallButton.TabIndex = 3;
            this.waterfallButton.Text = "Water Source";
            this.waterfallButton.UseVisualStyleBackColor = false;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newButton.Location = new System.Drawing.Point(35, 346);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 30);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "New Village";
            this.newButton.UseVisualStyleBackColor = false;
            // 
            // treeButton
            // 
            this.treeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.treeButton.Location = new System.Drawing.Point(35, 209);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(75, 23);
            this.treeButton.TabIndex = 1;
            this.treeButton.Text = "Tree";
            this.treeButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveButton.Location = new System.Drawing.Point(85, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save Village";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // houseBotton
            // 
            this.houseBotton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.houseBotton.Location = new System.Drawing.Point(140, 209);
            this.houseBotton.Name = "houseBotton";
            this.houseBotton.Size = new System.Drawing.Size(75, 23);
            this.houseBotton.TabIndex = 2;
            this.houseBotton.Text = "House";
            this.houseBotton.UseVisualStyleBackColor = false;
            // 
            // villageNameBox
            // 
            this.villageNameBox.Location = new System.Drawing.Point(42, 90);
            this.villageNameBox.Name = "villageNameBox";
            this.villageNameBox.Size = new System.Drawing.Size(173, 20);
            this.villageNameBox.TabIndex = 6;
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(872, 426);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.villagePanel);
            this.Name = "VillageWindow";
            this.Text = "VillageWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel villagePanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.ListBox nationList;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button waterfallButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button treeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button houseBotton;
        private System.Windows.Forms.TextBox villageNameBox;
    }
}

