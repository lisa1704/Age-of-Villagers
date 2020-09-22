namespace AgeOfVillagers
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
            this.gameName = new System.Windows.Forms.Label();
            this.villageName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonTree = new System.Windows.Forms.RadioButton();
            this.radioButtonHouse = new System.Windows.Forms.RadioButton();
            this.radioButtonWaterSource = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxNationName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameName.Location = new System.Drawing.Point(609, 9);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(184, 31);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "Age of Villagers";
            this.gameName.Click += new System.EventHandler(this.label1_Click);
            // 
            // villageName
            // 
            this.villageName.AutoSize = true;
            this.villageName.Location = new System.Drawing.Point(671, 51);
            this.villageName.Name = "villageName";
            this.villageName.Size = new System.Drawing.Size(78, 20);
            this.villageName.TabIndex = 1;
            this.villageName.Text = "Kathakhali";
            this.villageName.Click += new System.EventHandler(this.villageName_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouse_click);
            // 
            // radioButtonTree
            // 
            this.radioButtonTree.AutoSize = true;
            this.radioButtonTree.Location = new System.Drawing.Point(626, 167);
            this.radioButtonTree.Name = "radioButtonTree";
            this.radioButtonTree.Size = new System.Drawing.Size(58, 24);
            this.radioButtonTree.TabIndex = 4;
            this.radioButtonTree.TabStop = true;
            this.radioButtonTree.Text = "Tree";
            this.radioButtonTree.UseVisualStyleBackColor = true;
            this.radioButtonTree.CheckedChanged += new System.EventHandler(this.radioButtonTree_CheckedChanged);
            // 
            // radioButtonHouse
            // 
            this.radioButtonHouse.AutoSize = true;
            this.radioButtonHouse.Location = new System.Drawing.Point(690, 167);
            this.radioButtonHouse.Name = "radioButtonHouse";
            this.radioButtonHouse.Size = new System.Drawing.Size(72, 24);
            this.radioButtonHouse.TabIndex = 5;
            this.radioButtonHouse.TabStop = true;
            this.radioButtonHouse.Text = "House";
            this.radioButtonHouse.UseVisualStyleBackColor = true;
            this.radioButtonHouse.CheckedChanged += new System.EventHandler(this.radioButtonHouse_CheckedChanged);
            // 
            // radioButtonWaterSource
            // 
            this.radioButtonWaterSource.AutoSize = true;
            this.radioButtonWaterSource.Location = new System.Drawing.Point(644, 208);
            this.radioButtonWaterSource.Name = "radioButtonWaterSource";
            this.radioButtonWaterSource.Size = new System.Drawing.Size(118, 24);
            this.radioButtonWaterSource.TabIndex = 6;
            this.radioButtonWaterSource.TabStop = true;
            this.radioButtonWaterSource.Text = "Water Source";
            this.radioButtonWaterSource.UseVisualStyleBackColor = true;
            this.radioButtonWaterSource.CheckedChanged += new System.EventHandler(this.radioButtonWaterSource_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(644, 279);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save Village";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(644, 323);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(94, 29);
            this.buttonNew.TabIndex = 8;
            this.buttonNew.Text = "New Village";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpen.Location = new System.Drawing.Point(644, 373);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(94, 29);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "Open Village";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxNationName
            // 
            this.comboBoxNationName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNationName.FormattingEnabled = true;
            this.comboBoxNationName.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.comboBoxNationName.Location = new System.Drawing.Point(626, 117);
            this.comboBoxNationName.Name = "comboBoxNationName";
            this.comboBoxNationName.Size = new System.Drawing.Size(167, 28);
            this.comboBoxNationName.TabIndex = 10;
            this.comboBoxNationName.SelectedIndexChanged += new System.EventHandler(this.comboBoxNationName_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxNationName);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.radioButtonWaterSource);
            this.Controls.Add(this.radioButtonHouse);
            this.Controls.Add(this.radioButtonTree);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.villageName);
            this.Controls.Add(this.gameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label villageName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonTree;
        private System.Windows.Forms.RadioButton radioButtonHouse;
        private System.Windows.Forms.RadioButton radioButtonWaterSource;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxNationName;
    }
}

