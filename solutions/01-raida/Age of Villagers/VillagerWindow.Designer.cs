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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.nationList = new System.Windows.Forms.ListBox();
            this.openButton = new System.Windows.Forms.Button();
            this.watersourceButton = new System.Windows.Forms.Button();
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
            this.villagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.villagePanel.Location = new System.Drawing.Point(12, 12);
            this.villagePanel.Name = "villagePanel";
            this.villagePanel.Size = new System.Drawing.Size(600, 400);
            this.villagePanel.TabIndex = 12;
            this.villagePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.villagePanel_MouseClick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.gameLabel);
            this.menuPanel.Controls.Add(this.nationList);
            this.menuPanel.Controls.Add(this.openButton);
            this.menuPanel.Controls.Add(this.watersourceButton);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Village Name:";
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.Location = new System.Drawing.Point(45, 47);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(170, 24);
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
            this.nationList.Location = new System.Drawing.Point(42, 139);
            this.nationList.Name = "nationList";
            this.nationList.Size = new System.Drawing.Size(173, 56);
            this.nationList.TabIndex = 5;
            this.nationList.SelectedIndexChanged += new System.EventHandler(this.nationList_SelectedIndexChanged);
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
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // watersourceButton
            // 
            this.watersourceButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.watersourceButton.Location = new System.Drawing.Point(85, 240);
            this.watersourceButton.Name = "watersourceButton";
            this.watersourceButton.Size = new System.Drawing.Size(75, 38);
            this.watersourceButton.TabIndex = 3;
            this.watersourceButton.Text = "Water Source";
            this.watersourceButton.UseVisualStyleBackColor = false;
            this.watersourceButton.Click += new System.EventHandler(this.watersourceButton_Click);
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
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // treeButton
            // 
            this.treeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.treeButton.Location = new System.Drawing.Point(35, 211);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(75, 23);
            this.treeButton.TabIndex = 1;
            this.treeButton.Text = "Tree";
            this.treeButton.UseVisualStyleBackColor = false;
            this.treeButton.Click += new System.EventHandler(this.treeButton_Click);
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
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // houseBotton
            // 
            this.houseBotton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.houseBotton.Location = new System.Drawing.Point(140, 211);
            this.houseBotton.Name = "houseBotton";
            this.houseBotton.Size = new System.Drawing.Size(75, 23);
            this.houseBotton.TabIndex = 2;
            this.houseBotton.Text = "House";
            this.houseBotton.UseVisualStyleBackColor = false;
            this.houseBotton.Click += new System.EventHandler(this.houseBotton_Click);
            // 
            // villageNameBox
            // 
            this.villageNameBox.Location = new System.Drawing.Point(42, 100);
            this.villageNameBox.Name = "villageNameBox";
            this.villageNameBox.Size = new System.Drawing.Size(173, 20);
            this.villageNameBox.TabIndex = 6;
            this.villageNameBox.TextChanged += new System.EventHandler(this.villageNameBox_TextChanged);
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button watersourceButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button treeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button houseBotton;
        private System.Windows.Forms.TextBox villageNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

