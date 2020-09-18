namespace AgeOfVillagers
{
    partial class editorVillagers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.villageNameBox = new System.Windows.Forms.TextBox();
            this.New = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.house = new System.Windows.Forms.RadioButton();
            this.tree = new System.Windows.Forms.RadioButton();
            this.waterSource = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(37, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 403);
            this.panel1.TabIndex = 0;
            // 
            // villageNameBox
            // 
            this.villageNameBox.Location = new System.Drawing.Point(612, 89);
            this.villageNameBox.Name = "villageNameBox";
            this.villageNameBox.Size = new System.Drawing.Size(186, 22);
            this.villageNameBox.TabIndex = 1;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(570, 352);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(71, 27);
            this.New.TabIndex = 2;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(677, 352);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(66, 26);
            this.open.TabIndex = 3;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(774, 352);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(79, 26);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouins",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.comboBox1.Location = new System.Drawing.Point(599, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // house
            // 
            this.house.AutoSize = true;
            this.house.Location = new System.Drawing.Point(649, 217);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(70, 21);
            this.house.TabIndex = 6;
            this.house.TabStop = true;
            this.house.Text = "House";
            this.house.UseVisualStyleBackColor = true;
            // 
            // tree
            // 
            this.tree.AutoSize = true;
            this.tree.Location = new System.Drawing.Point(649, 245);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(59, 21);
            this.tree.TabIndex = 7;
            this.tree.TabStop = true;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = true;
            // 
            // waterSource
            // 
            this.waterSource.AutoSize = true;
            this.waterSource.Location = new System.Drawing.Point(649, 273);
            this.waterSource.Name = "waterSource";
            this.waterSource.Size = new System.Drawing.Size(114, 21);
            this.waterSource.TabIndex = 8;
            this.waterSource.TabStop = true;
            this.waterSource.Text = "Water source";
            this.waterSource.UseVisualStyleBackColor = true;
            this.waterSource.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // editorVillagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 481);
            this.Controls.Add(this.waterSource);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.house);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Controls.Add(this.New);
            this.Controls.Add(this.villageNameBox);
            this.Controls.Add(this.panel1);
            this.Name = "editorVillagers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox villageNameBox;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton house;
        private System.Windows.Forms.RadioButton tree;
        private System.Windows.Forms.RadioButton waterSource;
    }
}

