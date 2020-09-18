namespace Age_Of_Villagers
{
    partial class VillageEditorWindow
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
            this.villNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openVill = new System.Windows.Forms.Button();
            this.newVill = new System.Windows.Forms.Button();
            this.saveVill = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.rdButtonHouse = new System.Windows.Forms.RadioButton();
            this.rdButtonTree = new System.Windows.Forms.RadioButton();
            this.rdButtonWaterSrc = new System.Windows.Forms.RadioButton();
            this.nationCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // villNameBox
            // 
            this.villNameBox.Location = new System.Drawing.Point(742, 87);
            this.villNameBox.Name = "villNameBox";
            this.villNameBox.Size = new System.Drawing.Size(66, 22);
            this.villNameBox.TabIndex = 0;
            this.villNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(728, 50);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age Of Villagers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openVill
            // 
            this.openVill.Location = new System.Drawing.Point(747, 383);
            this.openVill.Name = "openVill";
            this.openVill.Size = new System.Drawing.Size(110, 23);
            this.openVill.TabIndex = 5;
            this.openVill.Text = "Open Village";
            this.openVill.UseVisualStyleBackColor = true;
            // 
            // newVill
            // 
            this.newVill.Location = new System.Drawing.Point(689, 428);
            this.newVill.Name = "newVill";
            this.newVill.Size = new System.Drawing.Size(103, 24);
            this.newVill.TabIndex = 6;
            this.newVill.Text = "New Village";
            this.newVill.UseVisualStyleBackColor = true;
            this.newVill.Click += new System.EventHandler(this.newVill_Click);
            // 
            // saveVill
            // 
            this.saveVill.Location = new System.Drawing.Point(811, 429);
            this.saveVill.Name = "saveVill";
            this.saveVill.Size = new System.Drawing.Size(100, 23);
            this.saveVill.TabIndex = 7;
            this.saveVill.Text = "Save Village";
            this.saveVill.UseVisualStyleBackColor = true;
            this.saveVill.Click += new System.EventHandler(this.saveVill_Click);
            this.saveVill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveVill_MouseClick);
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(30, 25);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(622, 448);
            this.Panel1.TabIndex = 9;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // rdButtonHouse
            // 
            this.rdButtonHouse.AutoSize = true;
            this.rdButtonHouse.Location = new System.Drawing.Point(747, 201);
            this.rdButtonHouse.Name = "rdButtonHouse";
            this.rdButtonHouse.Size = new System.Drawing.Size(70, 21);
            this.rdButtonHouse.TabIndex = 10;
            this.rdButtonHouse.TabStop = true;
            this.rdButtonHouse.Text = "House";
            this.rdButtonHouse.UseVisualStyleBackColor = true;
            this.rdButtonHouse.CheckedChanged += new System.EventHandler(this.rdButtonHouse_CheckedChanged);
            // 
            // rdButtonTree
            // 
            this.rdButtonTree.AutoSize = true;
            this.rdButtonTree.Location = new System.Drawing.Point(747, 243);
            this.rdButtonTree.Name = "rdButtonTree";
            this.rdButtonTree.Size = new System.Drawing.Size(59, 21);
            this.rdButtonTree.TabIndex = 11;
            this.rdButtonTree.TabStop = true;
            this.rdButtonTree.Text = "Tree";
            this.rdButtonTree.UseVisualStyleBackColor = true;
            // 
            // rdButtonWaterSrc
            // 
            this.rdButtonWaterSrc.AutoSize = true;
            this.rdButtonWaterSrc.Location = new System.Drawing.Point(747, 285);
            this.rdButtonWaterSrc.Name = "rdButtonWaterSrc";
            this.rdButtonWaterSrc.Size = new System.Drawing.Size(112, 21);
            this.rdButtonWaterSrc.TabIndex = 12;
            this.rdButtonWaterSrc.TabStop = true;
            this.rdButtonWaterSrc.Text = "WaterSource";
            this.rdButtonWaterSrc.UseVisualStyleBackColor = true;
            // 
            // nationCombo
            // 
            this.nationCombo.FormattingEnabled = true;
            this.nationCombo.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouins",
            "Inuit Hunters",
            "Egyptian King"});
            this.nationCombo.Location = new System.Drawing.Point(730, 143);
            this.nationCombo.Name = "nationCombo";
            this.nationCombo.Size = new System.Drawing.Size(121, 24);
            this.nationCombo.TabIndex = 13;
            this.nationCombo.SelectedIndexChanged += new System.EventHandler(this.nationCombo_SelectedIndexChanged);
            // 
            // VillageEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 586);
            this.Controls.Add(this.nationCombo);
            this.Controls.Add(this.rdButtonWaterSrc);
            this.Controls.Add(this.rdButtonTree);
            this.Controls.Add(this.rdButtonHouse);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.saveVill);
            this.Controls.Add(this.newVill);
            this.Controls.Add(this.openVill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.villNameBox);
            this.Name = "VillageEditorWindow";
            this.Text = "VillageEditorWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox villNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openVill;
        private System.Windows.Forms.Button newVill;
        private System.Windows.Forms.Button saveVill;
        private System.Windows.Forms.ComboBox nationCombo;
        public System.Windows.Forms.RadioButton rdButtonHouse;
        public System.Windows.Forms.RadioButton rdButtonTree;
        public System.Windows.Forms.RadioButton rdButtonWaterSrc;
        public System.Windows.Forms.Panel Panel1;
    }
}