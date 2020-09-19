namespace Age_Of_Villagers
{
    partial class AgeOfVillagers
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
            this.villageNameEditor = new System.Windows.Forms.TextBox();
            this.villageEditorPanel = new System.Windows.Forms.Panel();
            this.waterSourceButton = new System.Windows.Forms.RadioButton();
            this.houseButton = new System.Windows.Forms.RadioButton();
            this.treeButton = new System.Windows.Forms.RadioButton();
            this.selectNation = new System.Windows.Forms.ComboBox();
            this.buttonOpenVillage = new System.Windows.Forms.Button();
            this.buttonNewVillage = new System.Windows.Forms.Button();
            this.buttonSaveVillage = new System.Windows.Forms.Button();
            this.labelTittle = new System.Windows.Forms.Label();
            this.drawingSpace = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.villageEditorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // villageNameEditor
            // 
            this.villageNameEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.villageNameEditor.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villageNameEditor.Location = new System.Drawing.Point(66, 70);
            this.villageNameEditor.Name = "villageNameEditor";
            this.villageNameEditor.Size = new System.Drawing.Size(193, 29);
            this.villageNameEditor.TabIndex = 3;
            this.villageNameEditor.Text = " Village Name";
            this.villageNameEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // villageEditorPanel
            // 
            this.villageEditorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.villageEditorPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.villageEditorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.villageEditorPanel.Controls.Add(this.waterSourceButton);
            this.villageEditorPanel.Controls.Add(this.houseButton);
            this.villageEditorPanel.Controls.Add(this.treeButton);
            this.villageEditorPanel.Controls.Add(this.selectNation);
            this.villageEditorPanel.Controls.Add(this.buttonOpenVillage);
            this.villageEditorPanel.Controls.Add(this.buttonNewVillage);
            this.villageEditorPanel.Controls.Add(this.buttonSaveVillage);
            this.villageEditorPanel.Controls.Add(this.labelTittle);
            this.villageEditorPanel.Controls.Add(this.villageNameEditor);
            this.villageEditorPanel.Location = new System.Drawing.Point(629, 4);
            this.villageEditorPanel.Name = "villageEditorPanel";
            this.villageEditorPanel.Size = new System.Drawing.Size(299, 507);
            this.villageEditorPanel.TabIndex = 0;
            // 
            // waterSourceButton
            // 
            this.waterSourceButton.AutoSize = true;
            this.waterSourceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterSourceButton.Location = new System.Drawing.Point(96, 243);
            this.waterSourceButton.Name = "waterSourceButton";
            this.waterSourceButton.Size = new System.Drawing.Size(133, 24);
            this.waterSourceButton.TabIndex = 20;
            this.waterSourceButton.TabStop = true;
            this.waterSourceButton.Text = "Water Source";
            this.waterSourceButton.UseVisualStyleBackColor = true;
            // 
            // houseButton
            // 
            this.houseButton.AutoSize = true;
            this.houseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseButton.Location = new System.Drawing.Point(96, 213);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(79, 24);
            this.houseButton.TabIndex = 19;
            this.houseButton.TabStop = true;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            // 
            // treeButton
            // 
            this.treeButton.AutoSize = true;
            this.treeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeButton.Location = new System.Drawing.Point(96, 183);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(64, 24);
            this.treeButton.TabIndex = 17;
            this.treeButton.TabStop = true;
            this.treeButton.Text = "Tree";
            this.treeButton.UseVisualStyleBackColor = true;
            // 
            // selectNation
            // 
            this.selectNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNation.FormattingEnabled = true;
            this.selectNation.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.selectNation.Location = new System.Drawing.Point(66, 118);
            this.selectNation.Name = "selectNation";
            this.selectNation.Size = new System.Drawing.Size(193, 28);
            this.selectNation.TabIndex = 16;
            this.selectNation.Text = "       Select Nation";
            this.selectNation.SelectedIndexChanged += new System.EventHandler(this.selectNation_SelectedIndexChanged);
            // 
            // buttonOpenVillage
            // 
            this.buttonOpenVillage.AutoSize = true;
            this.buttonOpenVillage.BackColor = System.Drawing.Color.Silver;
            this.buttonOpenVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenVillage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpenVillage.Location = new System.Drawing.Point(150, 448);
            this.buttonOpenVillage.Name = "buttonOpenVillage";
            this.buttonOpenVillage.Size = new System.Drawing.Size(114, 39);
            this.buttonOpenVillage.TabIndex = 15;
            this.buttonOpenVillage.Text = "Open Village";
            this.buttonOpenVillage.UseVisualStyleBackColor = false;
            this.buttonOpenVillage.Click += new System.EventHandler(this.buttonOpenVillage_Click);
            // 
            // buttonNewVillage
            // 
            this.buttonNewVillage.AutoSize = true;
            this.buttonNewVillage.BackColor = System.Drawing.Color.Silver;
            this.buttonNewVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewVillage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewVillage.Location = new System.Drawing.Point(21, 448);
            this.buttonNewVillage.Name = "buttonNewVillage";
            this.buttonNewVillage.Size = new System.Drawing.Size(111, 39);
            this.buttonNewVillage.TabIndex = 14;
            this.buttonNewVillage.Text = "New Village";
            this.buttonNewVillage.UseVisualStyleBackColor = false;
            this.buttonNewVillage.Click += new System.EventHandler(this.buttonNewVillage_Click);
            // 
            // buttonSaveVillage
            // 
            this.buttonSaveVillage.AutoSize = true;
            this.buttonSaveVillage.BackColor = System.Drawing.Color.Silver;
            this.buttonSaveVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveVillage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSaveVillage.Location = new System.Drawing.Point(101, 382);
            this.buttonSaveVillage.Name = "buttonSaveVillage";
            this.buttonSaveVillage.Size = new System.Drawing.Size(111, 39);
            this.buttonSaveVillage.TabIndex = 11;
            this.buttonSaveVillage.Text = "Save Village";
            this.buttonSaveVillage.UseVisualStyleBackColor = false;
            this.buttonSaveVillage.Click += new System.EventHandler(this.buttonSaveVillage_Click);
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.Location = new System.Drawing.Point(61, 17);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(203, 29);
            this.labelTittle.TabIndex = 4;
            this.labelTittle.Text = "Age Of Villagers";
            // 
            // drawingSpace
            // 
            this.drawingSpace.BackColor = System.Drawing.Color.LavenderBlush;
            this.drawingSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingSpace.Location = new System.Drawing.Point(11, 91);
            this.drawingSpace.MaximumSize = new System.Drawing.Size(600, 400);
            this.drawingSpace.MinimumSize = new System.Drawing.Size(600, 400);
            this.drawingSpace.Name = "drawingSpace";
            this.drawingSpace.Size = new System.Drawing.Size(600, 400);
            this.drawingSpace.TabIndex = 7;
            this.drawingSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingSpace_Paint);
            this.drawingSpace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingSpace_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Drawing Space";
            // 
            // AgeOfVillagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawingSpace);
            this.Controls.Add(this.villageEditorPanel);
            this.Name = "AgeOfVillagers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.villageEditorPanel.ResumeLayout(false);
            this.villageEditorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox villageNameEditor;
        private System.Windows.Forms.Panel villageEditorPanel;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Panel drawingSpace;
        private System.Windows.Forms.Button buttonSaveVillage;
        private System.Windows.Forms.Button buttonOpenVillage;
        private System.Windows.Forms.Button buttonNewVillage;
        private System.Windows.Forms.ComboBox selectNation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton waterSourceButton;
        private System.Windows.Forms.RadioButton houseButton;
        private System.Windows.Forms.RadioButton treeButton;
    }
}

