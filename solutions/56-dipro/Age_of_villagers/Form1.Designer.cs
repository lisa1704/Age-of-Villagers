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
            this.Drawingpanel = new System.Windows.Forms.Panel();
            this.Tree = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.House = new System.Windows.Forms.Button();
            this.Watersource = new System.Windows.Forms.Button();
            this.Savevillage = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Newvillage = new System.Windows.Forms.Button();
            this.Openvillage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Drawingpanel
            // 
            this.Drawingpanel.Location = new System.Drawing.Point(0, 0);
            this.Drawingpanel.Name = "Drawingpanel";
            this.Drawingpanel.Size = new System.Drawing.Size(600, 400);
            this.Drawingpanel.TabIndex = 0;
            this.Drawingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Drawingpanel_Paint);
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(606, 191);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(75, 23);
            this.Tree.TabIndex = 1;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(726, 191);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(75, 23);
            this.House.TabIndex = 2;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // Watersource
            // 
            this.Watersource.Location = new System.Drawing.Point(667, 237);
            this.Watersource.Name = "Watersource";
            this.Watersource.Size = new System.Drawing.Size(80, 23);
            this.Watersource.TabIndex = 3;
            this.Watersource.Text = "Watersource";
            this.Watersource.UseVisualStyleBackColor = true;
            this.Watersource.Click += new System.EventHandler(this.Watersource_Click);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Arab Bedoun",
            "Inuit Hunters"});
            this.listBox1.Location = new System.Drawing.Point(648, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 400);
            this.Controls.Add(this.Openvillage);
            this.Controls.Add(this.Newvillage);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Savevillage);
            this.Controls.Add(this.Watersource);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Drawingpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Drawingpanel;
        private System.Windows.Forms.Button Tree;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button Watersource;
        private System.Windows.Forms.Button Savevillage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Newvillage;
        private System.Windows.Forms.Button Openvillage;
    }
}

