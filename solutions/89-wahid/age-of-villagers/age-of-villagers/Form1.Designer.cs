namespace age_of_villagers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ageofvillagers = new System.Windows.Forms.Label();
            this.villagenamebox = new System.Windows.Forms.TextBox();
            this.villagename = new System.Windows.Forms.Label();
            this.villagelocationbox = new System.Windows.Forms.ComboBox();
            this.villagelocation = new System.Windows.Forms.Label();
            this.tree = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(33, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ageofvillagers
            // 
            this.ageofvillagers.AutoSize = true;
            this.ageofvillagers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ageofvillagers.Location = new System.Drawing.Point(681, 38);
            this.ageofvillagers.Name = "ageofvillagers";
            this.ageofvillagers.Size = new System.Drawing.Size(193, 32);
            this.ageofvillagers.TabIndex = 1;
            this.ageofvillagers.Text = "Age of villagers";
            this.ageofvillagers.Click += new System.EventHandler(this.ageofvillagers_Click);
            // 
            // villagenamebox
            // 
            this.villagenamebox.Location = new System.Drawing.Point(786, 100);
            this.villagenamebox.Name = "villagenamebox";
            this.villagenamebox.Size = new System.Drawing.Size(100, 23);
            this.villagenamebox.TabIndex = 2;
            this.villagenamebox.TextChanged += new System.EventHandler(this.villagenamebox_TextChanged);
            // 
            // villagename
            // 
            this.villagename.AutoSize = true;
            this.villagename.Location = new System.Drawing.Point(692, 103);
            this.villagename.Name = "villagename";
            this.villagename.Size = new System.Drawing.Size(75, 15);
            this.villagename.TabIndex = 3;
            this.villagename.Text = "Village name";
            this.villagename.Click += new System.EventHandler(this.villagename_Click);
            // 
            // villagelocationbox
            // 
            this.villagelocationbox.FormattingEnabled = true;
            this.villagelocationbox.Location = new System.Drawing.Point(786, 138);
            this.villagelocationbox.Name = "villagelocationbox";
            this.villagelocationbox.Size = new System.Drawing.Size(100, 23);
            this.villagelocationbox.TabIndex = 4;
            this.villagelocationbox.SelectedIndexChanged += new System.EventHandler(this.villagelocationbox_SelectedIndexChanged);
            // 
            // villagelocation
            // 
            this.villagelocation.AutoSize = true;
            this.villagelocation.Location = new System.Drawing.Point(692, 141);
            this.villagelocation.Name = "villagelocation";
            this.villagelocation.Size = new System.Drawing.Size(88, 15);
            this.villagelocation.TabIndex = 5;
            this.villagelocation.Text = "Village location";
            this.villagelocation.Click += new System.EventHandler(this.villagelocation_Click);
            // 
            // tree
            // 
            this.tree.AutoSize = true;
            this.tree.Location = new System.Drawing.Point(737, 215);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(47, 19);
            this.tree.TabIndex = 6;
            this.tree.TabStop = true;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = true;
            this.tree.CheckedChanged += new System.EventHandler(this.tree_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.villagelocation);
            this.Controls.Add(this.villagelocationbox);
            this.Controls.Add(this.villagename);
            this.Controls.Add(this.villagenamebox);
            this.Controls.Add(this.ageofvillagers);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ageofvillagers;
        private System.Windows.Forms.TextBox villagenamebox;
        private System.Windows.Forms.Label villagename;
        private System.Windows.Forms.ComboBox villagelocationbox;
        private System.Windows.Forms.Label villagelocation;
        private System.Windows.Forms.RadioButton tree;
    }
}

