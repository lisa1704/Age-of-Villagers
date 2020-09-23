namespace AoV
{
    partial class MainWindow
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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnWater = new System.Windows.Forms.RadioButton();
            this.btnTree = new System.Windows.Forms.RadioButton();
            this.btnHouse = new System.Windows.Forms.RadioButton();
            this.SaveState = new System.Windows.Forms.Button();
            this.LoadState = new System.Windows.Forms.Button();
            this.NewState = new System.Windows.Forms.Button();
            this.NationList = new System.Windows.Forms.ListBox();
            this.VillageNameText = new System.Windows.Forms.TextBox();
            this.aovLabel = new System.Windows.Forms.Label();
            this.nationLabel = new System.Windows.Forms.Label();
            this.villageLabel = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawingPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DrawingPanel.Location = new System.Drawing.Point(16, 15);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DrawingPanel.MinimumSize = new System.Drawing.Size(800, 492);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(800, 492);
            this.DrawingPanel.TabIndex = 0;
            ///this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            ///this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            ///this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SidePanel.Controls.Add(this.btnWater);
            this.SidePanel.Controls.Add(this.btnTree);
            this.SidePanel.Controls.Add(this.btnHouse);
            this.SidePanel.Controls.Add(this.SaveState);
            this.SidePanel.Controls.Add(this.LoadState);
            this.SidePanel.Controls.Add(this.NewState);
            this.SidePanel.Controls.Add(this.NationList);
            this.SidePanel.Controls.Add(this.VillageNameText);
            this.SidePanel.Controls.Add(this.aovLabel);
            this.SidePanel.Controls.Add(this.nationLabel);
            this.SidePanel.Controls.Add(this.villageLabel);
            this.SidePanel.Location = new System.Drawing.Point(824, 15);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.MinimumSize = new System.Drawing.Size(279, 492);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(296, 492);
            this.SidePanel.TabIndex = 0;
            // 
            // btnWater
            // 
            this.btnWater.AutoSize = true;
            this.btnWater.Location = new System.Drawing.Point(48, 281);
            this.btnWater.Margin = new System.Windows.Forms.Padding(4);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(116, 21);
            this.btnWater.TabIndex = 9;
            this.btnWater.TabStop = true;
            this.btnWater.Text = "Water Source";
            this.btnWater.UseVisualStyleBackColor = true;
            // 
            // btnTree
            // 
            this.btnTree.AutoSize = true;
            this.btnTree.Location = new System.Drawing.Point(48, 235);
            this.btnTree.Margin = new System.Windows.Forms.Padding(4);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(59, 21);
            this.btnTree.TabIndex = 8;
            this.btnTree.TabStop = true;
            this.btnTree.Text = "Tree";
            this.btnTree.UseVisualStyleBackColor = true;
            // 
            // btnHouse
            // 
            this.btnHouse.AutoSize = true;
            this.btnHouse.Location = new System.Drawing.Point(48, 191);
            this.btnHouse.Margin = new System.Windows.Forms.Padding(4);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Size = new System.Drawing.Size(70, 21);
            this.btnHouse.TabIndex = 7;
            this.btnHouse.TabStop = true;
            this.btnHouse.Text = "House";
            this.btnHouse.UseVisualStyleBackColor = true;
            // 
            // SaveState
            // 
            this.SaveState.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveState.Location = new System.Drawing.Point(100, 388);
            this.SaveState.Margin = new System.Windows.Forms.Padding(4);
            this.SaveState.Name = "SaveState";
            this.SaveState.Size = new System.Drawing.Size(100, 28);
            this.SaveState.TabIndex = 6;
            this.SaveState.Text = "Save Village";
            this.SaveState.UseVisualStyleBackColor = true;
            // 
            // LoadState
            // 
            this.LoadState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadState.Location = new System.Drawing.Point(179, 441);
            this.LoadState.Margin = new System.Windows.Forms.Padding(4);
            this.LoadState.Name = "LoadState";
            this.LoadState.Size = new System.Drawing.Size(100, 28);
            this.LoadState.TabIndex = 5;
            this.LoadState.Text = "Open Village";
            this.LoadState.UseVisualStyleBackColor = true;
            // 
            // NewState
            // 
            this.NewState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewState.Location = new System.Drawing.Point(25, 441);
            this.NewState.Margin = new System.Windows.Forms.Padding(4);
            this.NewState.Name = "NewState";
            this.NewState.Size = new System.Drawing.Size(100, 28);
            this.NewState.TabIndex = 1;
            this.NewState.Text = "New Village";
            this.NewState.UseVisualStyleBackColor = true;
            // 
            // NationList
            // 
            this.NationList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NationList.FormattingEnabled = true;
            this.NationList.ItemHeight = 16;
            this.NationList.Items.AddRange(new object[] {
            "- None -",
            "Arab Bedouin",
            "Bangladeshi Farmaers",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationList.Location = new System.Drawing.Point(112, 128);
            this.NationList.Margin = new System.Windows.Forms.Padding(4);
            this.NationList.Name = "NationList";
            this.NationList.Size = new System.Drawing.Size(165, 20);
            this.NationList.TabIndex = 4;
            // 
            // VillageNameText
            // 
            this.VillageNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VillageNameText.Location = new System.Drawing.Point(112, 92);
            this.VillageNameText.Margin = new System.Windows.Forms.Padding(4);
            this.VillageNameText.Name = "VillageNameText";
            this.VillageNameText.Size = new System.Drawing.Size(165, 22);
            this.VillageNameText.TabIndex = 3;
            // 
            // aovLabel
            // 
            this.aovLabel.AutoSize = true;
            this.aovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aovLabel.Location = new System.Drawing.Point(16, 11);
            this.aovLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aovLabel.Name = "aovLabel";
            this.aovLabel.Size = new System.Drawing.Size(242, 36);
            this.aovLabel.TabIndex = 2;
            this.aovLabel.Text = "Age of Villagers";
            this.aovLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nationLabel
            // 
            this.nationLabel.AutoSize = true;
            this.nationLabel.Location = new System.Drawing.Point(5, 132);
            this.nationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nationLabel.Name = "nationLabel";
            this.nationLabel.Size = new System.Drawing.Size(97, 17);
            this.nationLabel.TabIndex = 1;
            this.nationLabel.Text = "Nation           :";
            // 
            // villageLabel
            // 
            this.villageLabel.AutoSize = true;
            this.villageLabel.Location = new System.Drawing.Point(5, 96);
            this.villageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.villageLabel.Name = "villageLabel";
            this.villageLabel.Size = new System.Drawing.Size(99, 17);
            this.villageLabel.TabIndex = 0;
            this.villageLabel.Text = "Village Name :";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 522);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.DrawingPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1151, 559);
            this.Name = "MainWindow";
            this.Text = "Age of Villagers";
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label aovLabel;
        private System.Windows.Forms.Label nationLabel;
        private System.Windows.Forms.Label villageLabel;
        private System.Windows.Forms.ListBox NationList;
        private System.Windows.Forms.TextBox VillageNameText;
        private System.Windows.Forms.RadioButton btnWater;
        private System.Windows.Forms.RadioButton btnTree;
        private System.Windows.Forms.RadioButton btnHouse;
        private System.Windows.Forms.Button SaveState;
        private System.Windows.Forms.Button LoadState;
        private System.Windows.Forms.Button NewState;
    }
}

