using System.Drawing;

namespace AgeOfVillagers
{
    partial class MainWindow
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
            this.drawingAreaPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.nationTypeCombo = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.houseButton = new System.Windows.Forms.Button();
            this.TreeButton = new System.Windows.Forms.Button();
            this.villageNameBox = new System.Windows.Forms.TextBox();
            this.gameHeaderLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingAreaPanel
            // 
            this.drawingAreaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.drawingAreaPanel.Location = new System.Drawing.Point(12, 12);
            this.drawingAreaPanel.Name = "drawingAreaPanel";
            this.drawingAreaPanel.Size = new System.Drawing.Size(600, 400);
            this.drawingAreaPanel.TabIndex = 12;
            this.drawingAreaPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingAreaPanel_MouseClick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.Window;
            this.menuPanel.Controls.Add(this.nationTypeCombo);
            this.menuPanel.Controls.Add(this.saveButton);
            this.menuPanel.Controls.Add(this.openButton);
            this.menuPanel.Controls.Add(this.newButton);
            this.menuPanel.Controls.Add(this.waterButton);
            this.menuPanel.Controls.Add(this.houseButton);
            this.menuPanel.Controls.Add(this.TreeButton);
            this.menuPanel.Controls.Add(this.villageNameBox);
            this.menuPanel.Controls.Add(this.gameHeaderLabel);
            this.menuPanel.Location = new System.Drawing.Point(612, 12);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(248, 400);
            this.menuPanel.TabIndex = 13;
            // 
            // nationTypeCombo
            // 
            this.nationTypeCombo.BackColor = System.Drawing.SystemColors.Info;
            this.nationTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationTypeCombo.FormattingEnabled = true;
            this.nationTypeCombo.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouins",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.nationTypeCombo.Location = new System.Drawing.Point(54, 112);
            this.nationTypeCombo.Name = "nationTypeCombo";
            this.nationTypeCombo.Size = new System.Drawing.Size(151, 28);
            this.nationTypeCombo.TabIndex = 4;
            this.nationTypeCombo.SelectedIndexChanged += new System.EventHandler(this.nationTypeCombo_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(76, 322);
            this.saveButton.Name = "saveButton";
            this.saveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveButton.Size = new System.Drawing.Size(107, 34);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Village";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openButton.Location = new System.Drawing.Point(131, 362);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(107, 34);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open Village";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newButton.Location = new System.Drawing.Point(18, 362);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(107, 34);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New Village";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // waterButton
            // 
            this.waterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waterButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waterButton.Location = new System.Drawing.Point(76, 218);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(107, 34);
            this.waterButton.TabIndex = 3;
            this.waterButton.Text = "Water Source";
            this.waterButton.UseVisualStyleBackColor = true;
            this.waterButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.waterButton_MouseClick);
            // 
            // houseButton
            // 
            this.houseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.houseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.houseButton.Location = new System.Drawing.Point(131, 178);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(107, 34);
            this.houseButton.TabIndex = 3;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.houseButton_MouseClick);
            // 
            // TreeButton
            // 
            this.TreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TreeButton.Location = new System.Drawing.Point(18, 178);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(107, 34);
            this.TreeButton.TabIndex = 3;
            this.TreeButton.Text = "Tree";
            this.TreeButton.UseVisualStyleBackColor = true;
            this.TreeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TreeButton_MouseClick);
            // 
            // villageNameBox
            // 
            this.villageNameBox.BackColor = System.Drawing.SystemColors.Info;
            this.villageNameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.villageNameBox.Location = new System.Drawing.Point(48, 66);
            this.villageNameBox.Name = "villageNameBox";
            this.villageNameBox.Size = new System.Drawing.Size(157, 27);
            this.villageNameBox.TabIndex = 1;
            this.villageNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gameHeaderLabel
            // 
            this.gameHeaderLabel.Font = new System.Drawing.Font("Arial", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameHeaderLabel.Location = new System.Drawing.Point(18, 11);
            this.gameHeaderLabel.Name = "gameHeaderLabel";
            this.gameHeaderLabel.Size = new System.Drawing.Size(210, 52);
            this.gameHeaderLabel.TabIndex = 0;
            this.gameHeaderLabel.Text = "Age of Villagers";
            this.gameHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 420);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.drawingAreaPanel);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingAreaPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label gameHeaderLabel;
        private System.Windows.Forms.TextBox villageNameBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button TreeButton;
        private System.Windows.Forms.ComboBox nationTypeCombo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

