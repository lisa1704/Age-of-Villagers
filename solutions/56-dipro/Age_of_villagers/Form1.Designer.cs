namespace Age_of_villagers
{
    partial class villagename_box
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
            this.Drawingpanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Savevillage = new System.Windows.Forms.Button();
            this.Newvillage = new System.Windows.Forms.Button();
            this.Openvillage = new System.Windows.Forms.Button();
            this.Age_of_villagers = new System.Windows.Forms.Label();
            this.Village_Name = new System.Windows.Forms.Label();
            this.villagename_textbox = new System.Windows.Forms.TextBox();
            this.Nation_name = new System.Windows.Forms.Label();
            this.Nation_list = new System.Windows.Forms.ComboBox();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Drawingpanel
            // 
            this.Drawingpanel.Location = new System.Drawing.Point(0, 0);
            this.Drawingpanel.Name = "Drawingpanel";
            this.Drawingpanel.Size = new System.Drawing.Size(600, 400);
            this.Drawingpanel.TabIndex = 0;
            this.Drawingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Drawingpanel_Paint);
            this.Drawingpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Drawinpanel_mouse);
            // 
            // Savevillage
            // 
            this.Savevillage.Location = new System.Drawing.Point(667, 314);
            this.Savevillage.Name = "Savevillage";
            this.Savevillage.Size = new System.Drawing.Size(75, 23);
            this.Savevillage.TabIndex = 4;
            this.Savevillage.Text = "Savevillage";
            this.Savevillage.UseVisualStyleBackColor = true;
            this.Savevillage.Click += new System.EventHandler(this.Savevillage_Click);
            // 
            // Newvillage
            // 
            this.Newvillage.Location = new System.Drawing.Point(606, 364);
            this.Newvillage.Name = "Newvillage";
            this.Newvillage.Size = new System.Drawing.Size(75, 23);
            this.Newvillage.TabIndex = 6;
            this.Newvillage.Text = "Newvillage";
            this.Newvillage.UseVisualStyleBackColor = true;
            this.Newvillage.Click += new System.EventHandler(this.Newvillage_Click);
            // 
            // Openvillage
            // 
            this.Openvillage.Location = new System.Drawing.Point(726, 363);
            this.Openvillage.Name = "Openvillage";
            this.Openvillage.Size = new System.Drawing.Size(75, 23);
            this.Openvillage.TabIndex = 7;
            this.Openvillage.Text = "Openvillage";
            this.Openvillage.UseVisualStyleBackColor = true;
            this.Openvillage.Click += new System.EventHandler(this.Openvillage_Click);
            // 
            // Age_of_villagers
            // 
            this.Age_of_villagers.AutoSize = true;
            this.Age_of_villagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_of_villagers.Location = new System.Drawing.Point(641, 39);
            this.Age_of_villagers.Name = "Age_of_villagers";
            this.Age_of_villagers.Size = new System.Drawing.Size(137, 20);
            this.Age_of_villagers.TabIndex = 8;
            this.Age_of_villagers.Text = "Age of villagers ";
            this.Age_of_villagers.Click += new System.EventHandler(this.Age_of_villagers_Click);
            // 
            // Village_Name
            // 
            this.Village_Name.AutoSize = true;
            this.Village_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Village_Name.Location = new System.Drawing.Point(622, 85);
            this.Village_Name.Name = "Village_Name";
            this.Village_Name.Size = new System.Drawing.Size(85, 13);
            this.Village_Name.TabIndex = 9;
            this.Village_Name.Text = "Village Name:";
            this.Village_Name.Click += new System.EventHandler(this.Village_Name_Click);
            // 
            // villagename_textbox
            // 
            this.villagename_textbox.Location = new System.Drawing.Point(706, 82);
            this.villagename_textbox.Name = "villagename_textbox";
            this.villagename_textbox.Size = new System.Drawing.Size(84, 20);
            this.villagename_textbox.TabIndex = 10;
            this.villagename_textbox.TextChanged += new System.EventHandler(this.villagename_textbox_TextChanged);
            // 
            // Nation_name
            // 
            this.Nation_name.AutoSize = true;
            this.Nation_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nation_name.Location = new System.Drawing.Point(622, 121);
            this.Nation_name.Name = "Nation_name";
            this.Nation_name.Size = new System.Drawing.Size(84, 13);
            this.Nation_name.TabIndex = 11;
            this.Nation_name.Text = "Nation Name:";
            this.Nation_name.Click += new System.EventHandler(this.Nation_name_Click);
            // 
            // Nation_list
            // 
            this.Nation_list.FormattingEnabled = true;
            this.Nation_list.Items.AddRange(new object[] {
            "Bangladeshi Farmers ",
            "Arab Bedouin",
            "Egyptian Kings ",
            "Inuit Hunters "});
            this.Nation_list.Location = new System.Drawing.Point(706, 121);
            this.Nation_list.Name = "Nation_list";
            this.Nation_list.Size = new System.Drawing.Size(84, 21);
            this.Nation_list.TabIndex = 12;
            this.Nation_list.Text = "Nation list";
            this.Nation_list.SelectedIndexChanged += new System.EventHandler(this.Nation_list_SelectedIndexChanged);
            // 
            // Tree
            // 
            this.Tree.AutoSize = true;
            this.Tree.Location = new System.Drawing.Point(667, 176);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(47, 17);
            this.Tree.TabIndex = 13;
            this.Tree.TabStop = true;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.CheckedChanged += new System.EventHandler(this.Tree_CheckedChanged);
            // 
            // villagename_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 400);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Nation_list);
            this.Controls.Add(this.Nation_name);
            this.Controls.Add(this.villagename_textbox);
            this.Controls.Add(this.Village_Name);
            this.Controls.Add(this.Age_of_villagers);
            this.Controls.Add(this.Openvillage);
            this.Controls.Add(this.Newvillage);
            this.Controls.Add(this.Savevillage);
            this.Controls.Add(this.Drawingpanel);
            this.Name = "villagename_box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Drawingpanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Savevillage;
        private System.Windows.Forms.Button Newvillage;
        private System.Windows.Forms.Button Openvillage;
        private System.Windows.Forms.Label Age_of_villagers;
        private System.Windows.Forms.Label Village_Name;
        private System.Windows.Forms.TextBox villagename_textbox;
        private System.Windows.Forms.Label Nation_name;
        private System.Windows.Forms.ComboBox Nation_list;
        private System.Windows.Forms.RadioButton Tree;
    }
}

