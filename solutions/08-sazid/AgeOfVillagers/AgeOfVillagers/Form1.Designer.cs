namespace AgeOfVillagers
{
    partial class Form1
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
            this.treeButton = new System.Windows.Forms.Button();
            this.houseButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.newVillageButton = new System.Windows.Forms.Button();
            this.openVillageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.drawinPanel = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.nationList = new System.Windows.Forms.ComboBox();
            this.villageName = new System.Windows.Forms.Label();
            this.villageNameInput = new System.Windows.Forms.TextBox();
            this.submitName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeButton
            // 
            this.treeButton.Location = new System.Drawing.Point(639, 226);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(75, 23);
            this.treeButton.TabIndex = 0;
            this.treeButton.Text = "Tree";
            this.treeButton.UseVisualStyleBackColor = true;
            this.treeButton.Click += new System.EventHandler(this.treeButton_Click);
            // 
            // houseButton
            // 
            this.houseButton.Location = new System.Drawing.Point(760, 226);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(75, 23);
            this.houseButton.TabIndex = 1;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.Click += new System.EventHandler(this.houseButton_Click);
            // 
            // waterButton
            // 
            this.waterButton.Location = new System.Drawing.Point(699, 279);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(91, 23);
            this.waterButton.TabIndex = 2;
            this.waterButton.Text = "Water Source";
            this.waterButton.UseVisualStyleBackColor = true;
            this.waterButton.Click += new System.EventHandler(this.waterButton_Click);
            // 
            // newVillageButton
            // 
            this.newVillageButton.Location = new System.Drawing.Point(639, 405);
            this.newVillageButton.Name = "newVillageButton";
            this.newVillageButton.Size = new System.Drawing.Size(75, 23);
            this.newVillageButton.TabIndex = 3;
            this.newVillageButton.Text = "New Village";
            this.newVillageButton.UseVisualStyleBackColor = true;
            this.newVillageButton.Click += new System.EventHandler(this.newVillageButton_Click);
            // 
            // openVillageButton
            // 
            this.openVillageButton.Location = new System.Drawing.Point(760, 405);
            this.openVillageButton.Name = "openVillageButton";
            this.openVillageButton.Size = new System.Drawing.Size(75, 23);
            this.openVillageButton.TabIndex = 4;
            this.openVillageButton.Text = "Open Village";
            this.openVillageButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(699, 376);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Village";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // drawinPanel
            // 
            this.drawinPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawinPanel.Location = new System.Drawing.Point(0, -1);
            this.drawinPanel.MinimumSize = new System.Drawing.Size(600, 400);
            this.drawinPanel.Name = "drawinPanel";
            this.drawinPanel.Size = new System.Drawing.Size(633, 497);
            this.drawinPanel.TabIndex = 6;
            this.drawinPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawinPanel_Paint);
            this.drawinPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawinPanel_MouseClick);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.Location = new System.Drawing.Point(659, 28);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(163, 25);
            this.appName.TabIndex = 7;
            this.appName.Text = "Age of Villagers";
            // 
            // nationList
            // 
            this.nationList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nationList.FormattingEnabled = true;
            this.nationList.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Beduin",
            "Egyptian king",
            "Inuit Hunter"});
            this.nationList.Location = new System.Drawing.Point(678, 117);
            this.nationList.Name = "nationList";
            this.nationList.Size = new System.Drawing.Size(121, 21);
            this.nationList.TabIndex = 8;
            this.nationList.Text = "Select Nation";
            this.nationList.SelectedIndexChanged += new System.EventHandler(this.nationList_SelectedIndexChanged);
            // 
            // villageName
            // 
            this.villageName.AutoSize = true;
            this.villageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villageName.Location = new System.Drawing.Point(688, 73);
            this.villageName.Name = "villageName";
            this.villageName.Size = new System.Drawing.Size(102, 20);
            this.villageName.TabIndex = 9;
            this.villageName.Text = "Village Name";
            // 
            // villageNameInput
            // 
            this.villageNameInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.villageNameInput.Location = new System.Drawing.Point(653, 158);
            this.villageNameInput.Name = "villageNameInput";
            this.villageNameInput.Size = new System.Drawing.Size(121, 20);
            this.villageNameInput.TabIndex = 10;
            this.villageNameInput.Text = "Enter Village Name";
            this.villageNameInput.Enter += new System.EventHandler(this.villageNameInput_Enter);
            this.villageNameInput.Leave += new System.EventHandler(this.villageNameInput_Leave);
            // 
            // submitName
            // 
            this.submitName.Location = new System.Drawing.Point(789, 156);
            this.submitName.Name = "submitName";
            this.submitName.Size = new System.Drawing.Size(46, 23);
            this.submitName.TabIndex = 11;
            this.submitName.Text = "OK";
            this.submitName.UseVisualStyleBackColor = true;
            this.submitName.Click += new System.EventHandler(this.submitName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 493);
            this.Controls.Add(this.submitName);
            this.Controls.Add(this.villageNameInput);
            this.Controls.Add(this.villageName);
            this.Controls.Add(this.nationList);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.drawinPanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openVillageButton);
            this.Controls.Add(this.newVillageButton);
            this.Controls.Add(this.waterButton);
            this.Controls.Add(this.houseButton);
            this.Controls.Add(this.treeButton);
            this.Name = "Form1";
            this.Text = "Age of Villagers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button treeButton;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.Button newVillageButton;
        private System.Windows.Forms.Button openVillageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel drawinPanel;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.ComboBox nationList;
        private System.Windows.Forms.Label villageName;
        private System.Windows.Forms.TextBox villageNameInput;
        private System.Windows.Forms.Button submitName;
    }
}

