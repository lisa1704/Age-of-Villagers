namespace Age_of_villagers
{
    partial class VillageCreator
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
            this.components = new System.ComponentModel.Container();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.NationList = new System.Windows.Forms.ComboBox();
            this.WaterSource = new System.Windows.Forms.RadioButton();
            this.House = new System.Windows.Forms.RadioButton();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.NewVillage = new System.Windows.Forms.Button();
            this.VillageNameBox = new System.Windows.Forms.TextBox();
            this.NAtionName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(789, 334);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(121, 28);
            this.SaveVillage.TabIndex = 1;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Location = new System.Drawing.Point(858, 368);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(121, 29);
            this.OpenVillage.TabIndex = 3;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // NationList
            // 
            this.NationList.FormattingEnabled = true;
            this.NationList.Items.AddRange(new object[] {
            "Bangladeshi",
            "Arab",
            "Egyptian",
            "Inuit"});
            this.NationList.Location = new System.Drawing.Point(792, 152);
            this.NationList.Name = "NationList";
            this.NationList.Size = new System.Drawing.Size(151, 28);
            this.NationList.TabIndex = 6;
            this.NationList.Text = "Nation List";
            this.NationList.SelectedIndexChanged += new System.EventHandler(this.NationList_SelectedIndexChanged);
            // 
            // WaterSource
            // 
            this.WaterSource.AutoSize = true;
            this.WaterSource.Location = new System.Drawing.Point(792, 262);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(118, 24);
            this.WaterSource.TabIndex = 8;
            this.WaterSource.TabStop = true;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.CheckedChanged += new System.EventHandler(this.WaterSource_CheckedChanged);
            // 
            // House
            // 
            this.House.AutoSize = true;
            this.House.Location = new System.Drawing.Point(792, 232);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(72, 24);
            this.House.TabIndex = 9;
            this.House.TabStop = true;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.CheckedChanged += new System.EventHandler(this.House_CheckedChanged);
            // 
            // Tree
            // 
            this.Tree.AutoSize = true;
            this.Tree.Location = new System.Drawing.Point(792, 202);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(58, 24);
            this.Tree.TabIndex = 10;
            this.Tree.TabStop = true;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.CheckedChanged += new System.EventHandler(this.Tree_CheckedChanged);
            // 
            // NewVillage
            // 
            this.NewVillage.Location = new System.Drawing.Point(719, 368);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(121, 29);
            this.NewVillage.TabIndex = 11;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // VillageNameBox
            // 
            this.VillageNameBox.Location = new System.Drawing.Point(792, 110);
            this.VillageNameBox.Name = "VillageNameBox";
            this.VillageNameBox.Size = new System.Drawing.Size(151, 27);
            this.VillageNameBox.TabIndex = 12;
            this.VillageNameBox.TextChanged += new System.EventHandler(this.VillageNameBox_TextChanged);
            // 
            // NAtionName
            // 
            this.NAtionName.AutoSize = true;
            this.NAtionName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NAtionName.Location = new System.Drawing.Point(679, 155);
            this.NAtionName.Name = "NAtionName";
            this.NAtionName.Size = new System.Drawing.Size(107, 20);
            this.NAtionName.TabIndex = 15;
            this.NAtionName.Text = "Nation Name:";
            this.NAtionName.Click += new System.EventHandler(this.NAtionName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(680, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Village Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(699, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Age Of Villagers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(32, 39);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(600, 400);
            this.MainPanel.TabIndex = 18;
            this.MainPanel.Click += new System.EventHandler(this.MainPanel_Click);
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.MainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_panelMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // VillageCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 479);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NAtionName);
            this.Controls.Add(this.VillageNameBox);
            this.Controls.Add(this.NewVillage);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.House);
            this.Controls.Add(this.WaterSource);
            this.Controls.Add(this.NationList);
            this.Controls.Add(this.OpenVillage);
            this.Controls.Add(this.SaveVillage);
            this.Name = "VillageCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.ComboBox NationList;
        private System.Windows.Forms.RadioButton WaterSource;
        private System.Windows.Forms.RadioButton House;
        private System.Windows.Forms.RadioButton Tree;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.TextBox VillageNameBox;
        private System.Windows.Forms.Label NAtionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

