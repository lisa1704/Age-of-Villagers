namespace AgeOfVillagers
{
    partial class VillageWindow
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
            this.drawing_panel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.village_name = new System.Windows.Forms.Label();
            this.Nation_Name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbVillageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BD = new System.Windows.Forms.RadioButton();
            this.Hunters = new System.Windows.Forms.RadioButton();
            this.Egyptians = new System.Windows.Forms.RadioButton();
            this.Arabians = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WaterSource = new System.Windows.Forms.RadioButton();
            this.House = new System.Windows.Forms.RadioButton();
            this.drawing_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawing_panel
            // 
            this.drawing_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawing_panel.Controls.Add(this.groupBox3);
            this.drawing_panel.Controls.Add(this.panel2);
            this.drawing_panel.Location = new System.Drawing.Point(2, 1);
            this.drawing_panel.Name = "drawing_panel";
            this.drawing_panel.Size = new System.Drawing.Size(600, 400);
            this.drawing_panel.TabIndex = 0;
            this.drawing_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_panel_Paint);
            this.drawing_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawing_panel_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(599, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(599, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 367);
            this.panel2.TabIndex = 0;
            // 
            // Tree
            // 
            this.Tree.AutoSize = true;
            this.Tree.Location = new System.Drawing.Point(0, 22);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(47, 19);
            this.Tree.TabIndex = 4;
            this.Tree.TabStop = true;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.ClickTree);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age of Villegers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // village_name
            // 
            this.village_name.AutoSize = true;
            this.village_name.Location = new System.Drawing.Point(658, 35);
            this.village_name.Name = "village_name";
            this.village_name.Size = new System.Drawing.Size(56, 15);
            this.village_name.TabIndex = 1;
            this.village_name.Text = "KataKhali";
            this.village_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.village_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nation_Name
            // 
            this.Nation_Name.AutoSize = true;
            this.Nation_Name.Location = new System.Drawing.Point(671, 60);
            this.Nation_Name.Name = "Nation_Name";
            this.Nation_Name.Size = new System.Drawing.Size(43, 15);
            this.Nation_Name.TabIndex = 1;
            this.Nation_Name.Text = "Nation";
            this.Nation_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nation_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Village";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save_Village);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open Village";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Open_village);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(601, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "New Village";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.New_Village);
            // 
            // tbVillageName
            // 
            this.tbVillageName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbVillageName.Location = new System.Drawing.Point(706, 287);
            this.tbVillageName.Name = "tbVillageName";
            this.tbVillageName.Size = new System.Drawing.Size(95, 23);
            this.tbVillageName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(601, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Village Name";
            // 
            // BD
            // 
            this.BD.AutoSize = true;
            this.BD.Location = new System.Drawing.Point(0, 22);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(134, 19);
            this.BD.TabIndex = 6;
            this.BD.TabStop = true;
            this.BD.Text = "Bangladeshi Farmers";
            this.BD.UseVisualStyleBackColor = true;
            this.BD.Click += new System.EventHandler(this.Click_Bangladeshi_Farmers);
            // 
            // Hunters
            // 
            this.Hunters.AutoSize = true;
            this.Hunters.Location = new System.Drawing.Point(100, 38);
            this.Hunters.Name = "Hunters";
            this.Hunters.Size = new System.Drawing.Size(94, 19);
            this.Hunters.TabIndex = 6;
            this.Hunters.TabStop = true;
            this.Hunters.Text = "Inuit Hunters";
            this.Hunters.UseVisualStyleBackColor = true;
            this.Hunters.Click += new System.EventHandler(this.Click_Inuit_Hunters);
            // 
            // Egyptians
            // 
            this.Egyptians.AutoSize = true;
            this.Egyptians.Location = new System.Drawing.Point(0, 63);
            this.Egyptians.Name = "Egyptians";
            this.Egyptians.Size = new System.Drawing.Size(103, 19);
            this.Egyptians.TabIndex = 6;
            this.Egyptians.TabStop = true;
            this.Egyptians.Text = "Egyptian Kings";
            this.Egyptians.UseVisualStyleBackColor = true;
            this.Egyptians.Click += new System.EventHandler(this.Click_Egyptian_Kings);
            // 
            // Arabians
            // 
            this.Arabians.AutoSize = true;
            this.Arabians.Location = new System.Drawing.Point(100, 75);
            this.Arabians.Name = "Arabians";
            this.Arabians.Size = new System.Drawing.Size(97, 19);
            this.Arabians.TabIndex = 6;
            this.Arabians.TabStop = true;
            this.Arabians.Text = "Arab Bedouin";
            this.Arabians.UseVisualStyleBackColor = true;
            this.Arabians.Click += new System.EventHandler(this.Click_Arab_Bedouin);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BD);
            this.groupBox1.Controls.Add(this.Arabians);
            this.groupBox1.Controls.Add(this.Egyptians);
            this.groupBox1.Controls.Add(this.Hunters);
            this.groupBox1.Location = new System.Drawing.Point(601, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Your Nation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WaterSource);
            this.groupBox2.Controls.Add(this.House);
            this.groupBox2.Controls.Add(this.Tree);
            this.groupBox2.Location = new System.Drawing.Point(601, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // WaterSource
            // 
            this.WaterSource.AutoSize = true;
            this.WaterSource.Location = new System.Drawing.Point(47, 60);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(95, 19);
            this.WaterSource.TabIndex = 4;
            this.WaterSource.TabStop = true;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.Click += new System.EventHandler(this.ClickWaterSource);
            // 
            // House
            // 
            this.House.AutoSize = true;
            this.House.Location = new System.Drawing.Point(91, 22);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(59, 19);
            this.House.TabIndex = 4;
            this.House.TabStop = true;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.ClickHouse);
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVillageName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nation_Name);
            this.Controls.Add(this.village_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawing_panel);
            this.Name = "VillageWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VillageWindow_Load);
            this.drawing_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawing_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label village_name;
        private System.Windows.Forms.Label Nation_Name;
        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbVillageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton BD;
        private System.Windows.Forms.RadioButton Hunters;
        private System.Windows.Forms.RadioButton Egyptians;
        private System.Windows.Forms.RadioButton Arabians;
        private System.Windows.Forms.GroupBox groupBox1;
       
       
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Tree;
        private System.Windows.Forms.RadioButton WaterSource;
        private System.Windows.Forms.RadioButton House;
    }
}

