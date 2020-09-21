namespace Age_of_villagers
{
    partial class Form1
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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.villagetype = new System.Windows.Forms.ComboBox();
            this.newvillage = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.watersource = new System.Windows.Forms.Button();
            this.tree = new System.Windows.Forms.Button();
            this.house = new System.Windows.Forms.Button();
            this.villagename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drawpanel = new System.Windows.Forms.Panel();
            this.sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sidepanel.Controls.Add(this.villagetype);
            this.sidepanel.Controls.Add(this.newvillage);
            this.sidepanel.Controls.Add(this.open);
            this.sidepanel.Controls.Add(this.save);
            this.sidepanel.Controls.Add(this.watersource);
            this.sidepanel.Controls.Add(this.tree);
            this.sidepanel.Controls.Add(this.house);
            this.sidepanel.Controls.Add(this.villagename);
            this.sidepanel.Controls.Add(this.label2);
            this.sidepanel.Controls.Add(this.label1);
            this.sidepanel.Location = new System.Drawing.Point(605, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(240, 400);
            this.sidepanel.TabIndex = 0;
            this.sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.side_panel);
            // 
            // villagetype
            // 
            this.villagetype.FormattingEnabled = true;
            this.villagetype.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Arab Beduin",
            "Inuit Hunters"});
            this.villagetype.Location = new System.Drawing.Point(23, 102);
            this.villagetype.Name = "villagetype";
            this.villagetype.Size = new System.Drawing.Size(185, 24);
            this.villagetype.TabIndex = 10;
            this.villagetype.Text = "Nation";
            this.villagetype.SelectedIndexChanged += new System.EventHandler(this.vallagetype_SelectedIndexChanged);
            // 
            // newvillage
            // 
            this.newvillage.Location = new System.Drawing.Point(53, 346);
            this.newvillage.Name = "newvillage";
            this.newvillage.Size = new System.Drawing.Size(134, 36);
            this.newvillage.TabIndex = 8;
            this.newvillage.Text = "New Village";
            this.newvillage.UseVisualStyleBackColor = true;
            this.newvillage.Click += new System.EventHandler(this.newvillage_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(52, 306);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(135, 34);
            this.open.TabIndex = 7;
            this.open.Text = "Open Village";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(52, 267);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(135, 33);
            this.save.TabIndex = 6;
            this.save.Text = "Save Village";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // watersource
            // 
            this.watersource.Location = new System.Drawing.Point(53, 218);
            this.watersource.Name = "watersource";
            this.watersource.Size = new System.Drawing.Size(135, 32);
            this.watersource.TabIndex = 5;
            this.watersource.Text = "Water Source";
            this.watersource.UseVisualStyleBackColor = true;
            this.watersource.Click += new System.EventHandler(this.watersource_Click);
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(120, 181);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(88, 32);
            this.tree.TabIndex = 4;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = true;
            this.tree.Click += new System.EventHandler(this.tree_Click);
            // 
            // house
            // 
            this.house.Location = new System.Drawing.Point(23, 181);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(91, 31);
            this.house.TabIndex = 3;
            this.house.Text = "House";
            this.house.UseVisualStyleBackColor = true;
            this.house.Click += new System.EventHandler(this.house_Click);
            // 
            // villagename
            // 
            this.villagename.Location = new System.Drawing.Point(23, 74);
            this.villagename.Name = "villagename";
            this.villagename.Size = new System.Drawing.Size(185, 22);
            this.villagename.TabIndex = 2;
            this.villagename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.villagename_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Village Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age Of Villagers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // drawpanel
            // 
            this.drawpanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawpanel.Location = new System.Drawing.Point(2, 0);
            this.drawpanel.Name = "drawpanel";
            this.drawpanel.Size = new System.Drawing.Size(600, 400);
            this.drawpanel.TabIndex = 1;
            this.drawpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.draw_panel);
            this.drawpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawpanel_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 403);
            this.Controls.Add(this.drawpanel);
            this.Controls.Add(this.sidepanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel drawpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button watersource;
        private System.Windows.Forms.Button tree;
        private System.Windows.Forms.Button house;
        private System.Windows.Forms.TextBox villagename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newvillage;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox villagetype;
    }
}

