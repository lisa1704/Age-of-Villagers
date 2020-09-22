namespace age_of_villagers
{
    partial class villageEditor
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
            this.VillageCanvas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveVillageButton = new System.Windows.Forms.Button();
            this.openVillageButton = new System.Windows.Forms.Button();
            this.newVillageButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.villageNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeButton = new System.Windows.Forms.RadioButton();
            this.houseButton = new System.Windows.Forms.RadioButton();
            this.waterSourceButton = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VillageCanvas
            // 
            this.VillageCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageCanvas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VillageCanvas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VillageCanvas.Location = new System.Drawing.Point(12, 12);
            this.VillageCanvas.Name = "VillageCanvas";
            this.VillageCanvas.Size = new System.Drawing.Size(600, 400);
            this.VillageCanvas.TabIndex = 2;
            this.VillageCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.VillageCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VillageCanvas_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.villageNameTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(612, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 389);
            this.panel2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveVillageButton);
            this.groupBox2.Controls.Add(this.openVillageButton);
            this.groupBox2.Controls.Add(this.newVillageButton);
            this.groupBox2.Location = new System.Drawing.Point(21, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Village Edit";
            // 
            // saveVillageButton
            // 
            this.saveVillageButton.AutoEllipsis = true;
            this.saveVillageButton.Location = new System.Drawing.Point(53, 26);
            this.saveVillageButton.Name = "saveVillageButton";
            this.saveVillageButton.Size = new System.Drawing.Size(106, 29);
            this.saveVillageButton.TabIndex = 0;
            this.saveVillageButton.Text = "Save Village";
            this.saveVillageButton.UseVisualStyleBackColor = true;
            this.saveVillageButton.Click += new System.EventHandler(this.saveVillageButton_Click);
            // 
            // openVillageButton
            // 
            this.openVillageButton.Location = new System.Drawing.Point(112, 63);
            this.openVillageButton.Name = "openVillageButton";
            this.openVillageButton.Size = new System.Drawing.Size(106, 29);
            this.openVillageButton.TabIndex = 0;
            this.openVillageButton.Text = "Open Village";
            this.openVillageButton.UseVisualStyleBackColor = true;
            this.openVillageButton.Click += new System.EventHandler(this.openVillageButton_Click);
            // 
            // newVillageButton
            // 
            this.newVillageButton.Location = new System.Drawing.Point(0, 63);
            this.newVillageButton.Name = "newVillageButton";
            this.newVillageButton.Size = new System.Drawing.Size(106, 29);
            this.newVillageButton.TabIndex = 0;
            this.newVillageButton.Text = "New Village";
            this.newVillageButton.UseVisualStyleBackColor = true;
            this.newVillageButton.Click += new System.EventHandler(this.newVillageButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.waterSourceButton);
            this.groupBox1.Controls.Add(this.houseButton);
            this.groupBox1.Controls.Add(this.treeButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // villageNameTextBox
            // 
            this.villageNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.villageNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.villageNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.villageNameTextBox.Location = new System.Drawing.Point(18, 63);
            this.villageNameTextBox.Name = "villageNameTextBox";
            this.villageNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.villageNameTextBox.TabIndex = 1;
            this.villageNameTextBox.Text = "Enter Village Name";
            this.villageNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.villageNameTextBox.Enter += new System.EventHandler(this.villageNameTextBox_enter);
            this.villageNameTextBox.Leave += new System.EventHandler(this.villageNameTextBox_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age Of Villagers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // treeButton
            // 
            this.treeButton.AutoSize = true;
            this.treeButton.Location = new System.Drawing.Point(20, 27);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(58, 24);
            this.treeButton.TabIndex = 0;
            this.treeButton.TabStop = true;
            this.treeButton.Text = "Tree";
            this.treeButton.UseVisualStyleBackColor = true;
            // 
            // houseButton
            // 
            this.houseButton.AutoSize = true;
            this.houseButton.Location = new System.Drawing.Point(104, 27);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(72, 24);
            this.houseButton.TabIndex = 1;
            this.houseButton.TabStop = true;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            // 
            // waterSourceButton
            // 
            this.waterSourceButton.AutoSize = true;
            this.waterSourceButton.Location = new System.Drawing.Point(56, 58);
            this.waterSourceButton.Name = "waterSourceButton";
            this.waterSourceButton.Size = new System.Drawing.Size(118, 24);
            this.waterSourceButton.TabIndex = 2;
            this.waterSourceButton.TabStop = true;
            this.waterSourceButton.Text = "Water Source";
            this.waterSourceButton.UseVisualStyleBackColor = true;
            this.waterSourceButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // villageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.VillageCanvas);
            this.Name = "villageEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Editor";
            this.Load += new System.EventHandler(this.villageEditor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel VillageCanvas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox villageNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveVillageButton;
        private System.Windows.Forms.Button openVillageButton;
        private System.Windows.Forms.Button newVillageButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton waterSourceButton;
        private System.Windows.Forms.RadioButton houseButton;
        private System.Windows.Forms.RadioButton treeButton;
    }
}

