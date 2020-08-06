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
            this.buttonOpenVillage = new System.Windows.Forms.Button();
            this.buttonNewVillage = new System.Windows.Forms.Button();
            this.buttonSaveVillage = new System.Windows.Forms.Button();
            this.buttonWaterSource = new System.Windows.Forms.Button();
            this.buttonHouse = new System.Windows.Forms.Button();
            this.buttonTree = new System.Windows.Forms.Button();
            this.nationSelector = new System.Windows.Forms.DomainUpDown();
            this.labelTittle = new System.Windows.Forms.Label();
            this.drawingSpace = new System.Windows.Forms.Panel();
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
            this.villageEditorPanel.Controls.Add(this.buttonOpenVillage);
            this.villageEditorPanel.Controls.Add(this.buttonNewVillage);
            this.villageEditorPanel.Controls.Add(this.buttonSaveVillage);
            this.villageEditorPanel.Controls.Add(this.buttonWaterSource);
            this.villageEditorPanel.Controls.Add(this.buttonHouse);
            this.villageEditorPanel.Controls.Add(this.buttonTree);
            this.villageEditorPanel.Controls.Add(this.nationSelector);
            this.villageEditorPanel.Controls.Add(this.labelTittle);
            this.villageEditorPanel.Controls.Add(this.villageNameEditor);
            this.villageEditorPanel.Location = new System.Drawing.Point(629, 4);
            this.villageEditorPanel.Name = "villageEditorPanel";
            this.villageEditorPanel.Size = new System.Drawing.Size(299, 507);
            this.villageEditorPanel.TabIndex = 0;
            this.villageEditorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // 
            // buttonWaterSource
            // 
            this.buttonWaterSource.AutoSize = true;
            this.buttonWaterSource.BackColor = System.Drawing.Color.Silver;
            this.buttonWaterSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWaterSource.Location = new System.Drawing.Point(101, 254);
            this.buttonWaterSource.Name = "buttonWaterSource";
            this.buttonWaterSource.Size = new System.Drawing.Size(122, 39);
            this.buttonWaterSource.TabIndex = 9;
            this.buttonWaterSource.Text = "Water Source";
            this.buttonWaterSource.UseVisualStyleBackColor = false;
            // 
            // buttonHouse
            // 
            this.buttonHouse.AutoSize = true;
            this.buttonHouse.BackColor = System.Drawing.Color.Silver;
            this.buttonHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHouse.Location = new System.Drawing.Point(172, 196);
            this.buttonHouse.Name = "buttonHouse";
            this.buttonHouse.Size = new System.Drawing.Size(92, 39);
            this.buttonHouse.TabIndex = 8;
            this.buttonHouse.Text = "House";
            this.buttonHouse.UseVisualStyleBackColor = false;
            // 
            // buttonTree
            // 
            this.buttonTree.AutoSize = true;
            this.buttonTree.BackColor = System.Drawing.Color.Silver;
            this.buttonTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTree.Location = new System.Drawing.Point(66, 196);
            this.buttonTree.Name = "buttonTree";
            this.buttonTree.Size = new System.Drawing.Size(92, 39);
            this.buttonTree.TabIndex = 7;
            this.buttonTree.Text = "Tree";
            this.buttonTree.UseVisualStyleBackColor = false;
            // 
            // nationSelector
            // 
            this.nationSelector.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationSelector.Items.Add("Bangladeshi Farmers");
            this.nationSelector.Items.Add("Arab Bedouin");
            this.nationSelector.Items.Add("Egyptian Kings");
            this.nationSelector.Items.Add("Inuit Hunters");
            this.nationSelector.Location = new System.Drawing.Point(66, 123);
            this.nationSelector.Name = "nationSelector";
            this.nationSelector.Size = new System.Drawing.Size(198, 29);
            this.nationSelector.TabIndex = 6;
            this.nationSelector.Text = "Nation";
            this.nationSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.drawingSpace.Location = new System.Drawing.Point(11, 91);
            this.drawingSpace.MaximumSize = new System.Drawing.Size(600, 400);
            this.drawingSpace.MinimumSize = new System.Drawing.Size(600, 400);
            this.drawingSpace.Name = "drawingSpace";
            this.drawingSpace.Size = new System.Drawing.Size(600, 400);
            this.drawingSpace.TabIndex = 7;
            // 
            // AgeOfVillagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 523);
            this.Controls.Add(this.drawingSpace);
            this.Controls.Add(this.villageEditorPanel);
            this.Name = "AgeOfVillagers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.villageEditorPanel.ResumeLayout(false);
            this.villageEditorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox villageNameEditor;
        private System.Windows.Forms.Panel villageEditorPanel;
        private System.Windows.Forms.DomainUpDown nationSelector;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Panel drawingSpace;
        private System.Windows.Forms.Button buttonWaterSource;
        private System.Windows.Forms.Button buttonHouse;
        private System.Windows.Forms.Button buttonTree;
        private System.Windows.Forms.Button buttonSaveVillage;
        private System.Windows.Forms.Button buttonOpenVillage;
        private System.Windows.Forms.Button buttonNewVillage;
    }
}

