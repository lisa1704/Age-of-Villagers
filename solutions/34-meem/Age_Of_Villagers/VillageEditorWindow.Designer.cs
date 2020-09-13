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
            this.house = new System.Windows.Forms.Button();
            this.tree = new System.Windows.Forms.Button();
            this.waterSource = new System.Windows.Forms.Button();
            this.openVill = new System.Windows.Forms.Button();
            this.newVill = new System.Windows.Forms.Button();
            this.saveVill = new System.Windows.Forms.Button();
            this.nationList = new System.Windows.Forms.ListBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // villNameBox
            // 
            this.villNameBox.Location = new System.Drawing.Point(742, 87);
            this.villNameBox.Name = "villNameBox";
            this.villNameBox.Size = new System.Drawing.Size(66, 22);
            this.villNameBox.TabIndex = 0;
            this.villNameBox.Text = "katakhali";
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
            // house
            // 
            this.house.Location = new System.Drawing.Point(703, 205);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(75, 23);
            this.house.TabIndex = 2;
            this.house.Text = "House";
            this.house.UseVisualStyleBackColor = true;
            this.house.Click += new System.EventHandler(this.house_Click);
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(811, 205);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(75, 23);
            this.tree.TabIndex = 3;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = true;
            this.tree.Click += new System.EventHandler(this.tree_Click);
            // 
            // waterSource
            // 
            this.waterSource.Location = new System.Drawing.Point(742, 250);
            this.waterSource.Name = "waterSource";
            this.waterSource.Size = new System.Drawing.Size(109, 23);
            this.waterSource.TabIndex = 4;
            this.waterSource.Text = "Water Source";
            this.waterSource.UseVisualStyleBackColor = true;
            this.waterSource.Click += new System.EventHandler(this.waterSource_Click);
            // 
            // openVill
            // 
            this.openVill.Location = new System.Drawing.Point(761, 380);
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
            // 
            // nationList
            // 
            this.nationList.FormattingEnabled = true;
            this.nationList.ItemHeight = 16;
            this.nationList.Items.AddRange(new object[] {
            "Bangladeshi",
            "Arab",
            "inuit"});
            this.nationList.Location = new System.Drawing.Point(703, 125);
            this.nationList.Name = "nationList";
            this.nationList.Size = new System.Drawing.Size(168, 20);
            this.nationList.TabIndex = 8;
            this.nationList.SelectedIndexChanged += new System.EventHandler(this.nationList_SelectedIndexChanged);
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
            // VillageEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 586);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.nationList);
            this.Controls.Add(this.saveVill);
            this.Controls.Add(this.newVill);
            this.Controls.Add(this.openVill);
            this.Controls.Add(this.waterSource);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.house);
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
        private System.Windows.Forms.Button house;
        private System.Windows.Forms.Button tree;
        private System.Windows.Forms.Button waterSource;
        private System.Windows.Forms.Button openVill;
        private System.Windows.Forms.Button newVill;
        private System.Windows.Forms.Button saveVill;
        private System.Windows.Forms.ListBox nationList;
        private System.Windows.Forms.Panel Panel1;
    }
}