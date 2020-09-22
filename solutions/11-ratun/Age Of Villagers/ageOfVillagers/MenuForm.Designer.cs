namespace ageOfVillagers
{
    partial class MenuForm
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treebutton = new System.Windows.Forms.RadioButton();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.Nation = new System.Windows.Forms.TextBox();
            this.VillageName = new System.Windows.Forms.TextBox();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.ageOfVillagers = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.houseButton = new System.Windows.Forms.RadioButton();
            this.waterButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 400);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.waterButton);
            this.panel1.Controls.Add(this.houseButton);
            this.panel1.Controls.Add(this.treebutton);
            this.panel1.Controls.Add(this.OpenVillage);
            this.panel1.Controls.Add(this.NewVillage);
            this.panel1.Controls.Add(this.Nation);
            this.panel1.Controls.Add(this.VillageName);
            this.panel1.Controls.Add(this.SaveVillage);
            this.panel1.Controls.Add(this.ageOfVillagers);
            this.panel1.Location = new System.Drawing.Point(606, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 400);
            this.panel1.TabIndex = 2;
            // 
            // treebutton
            // 
            this.treebutton.AutoSize = true;
            this.treebutton.Location = new System.Drawing.Point(51, 186);
            this.treebutton.Name = "treebutton";
            this.treebutton.Size = new System.Drawing.Size(59, 21);
            this.treebutton.TabIndex = 8;
            this.treebutton.TabStop = true;
            this.treebutton.Text = "Tree";
            this.treebutton.UseVisualStyleBackColor = true;
            this.treebutton.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Location = new System.Drawing.Point(142, 365);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(105, 23);
            this.OpenVillage.TabIndex = 7;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // NewVillage
            // 
            this.NewVillage.Location = new System.Drawing.Point(16, 365);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(94, 23);
            this.NewVillage.TabIndex = 6;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // Nation
            // 
            this.Nation.Location = new System.Drawing.Point(47, 105);
            this.Nation.Name = "Nation";
            this.Nation.Size = new System.Drawing.Size(186, 22);
            this.Nation.TabIndex = 3;
            this.Nation.TextChanged += new System.EventHandler(this.Nation_TextChanged);
            // 
            // VillageName
            // 
            this.VillageName.Location = new System.Drawing.Point(74, 77);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(124, 22);
            this.VillageName.TabIndex = 2;
            this.VillageName.TextChanged += new System.EventHandler(this.VillageName_TextChanged);
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(74, 327);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(124, 23);
            this.SaveVillage.TabIndex = 1;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ageOfVillagers
            // 
            this.ageOfVillagers.AutoSize = true;
            this.ageOfVillagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageOfVillagers.Location = new System.Drawing.Point(57, 28);
            this.ageOfVillagers.Name = "ageOfVillagers";
            this.ageOfVillagers.Size = new System.Drawing.Size(162, 24);
            this.ageOfVillagers.TabIndex = 0;
            this.ageOfVillagers.Text = "Age Of Villagers";
            this.ageOfVillagers.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 400);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // houseButton
            // 
            this.houseButton.AutoSize = true;
            this.houseButton.Location = new System.Drawing.Point(123, 186);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(70, 21);
            this.houseButton.TabIndex = 9;
            this.houseButton.TabStop = true;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.CheckedChanged += new System.EventHandler(this.HouseButton_CheckedChanged);
            // 
            // waterButton
            // 
            this.waterButton.AutoSize = true;
            this.waterButton.Location = new System.Drawing.Point(74, 228);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(67, 21);
            this.waterButton.TabIndex = 10;
            this.waterButton.TabStop = true;
            this.waterButton.Text = "Water";
            this.waterButton.UseVisualStyleBackColor = true;
            this.waterButton.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ageOfVillagers;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Nation;
        private System.Windows.Forms.TextBox VillageName;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.RadioButton treebutton;
        private System.Windows.Forms.RadioButton waterButton;
        private System.Windows.Forms.RadioButton houseButton;
    }
}