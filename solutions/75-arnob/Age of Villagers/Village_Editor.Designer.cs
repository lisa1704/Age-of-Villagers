using System;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    partial class Village_Editor_Window
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
            this.components = new System.ComponentModel.Container();
            this.New_village_button = new System.Windows.Forms.Button();
            this.radiobutton_waterSource = new System.Windows.Forms.RadioButton();
            this.radioButton_tree = new System.Windows.Forms.RadioButton();
            this.radioButton_House = new System.Windows.Forms.RadioButton();
            this.Open_village_button = new System.Windows.Forms.Button();
            this.Save_village_button = new System.Windows.Forms.Button();
            this.drawing_space = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_bar = new System.Windows.Forms.Panel();
            this.label_ageOfVillagers = new System.Windows.Forms.Label();
            this.comboBox_NationList = new System.Windows.Forms.ComboBox();
            this.Village_Name_textBox = new System.Windows.Forms.TextBox();
            this.Menu_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // New_village_button
            // 
            this.New_village_button.Location = new System.Drawing.Point(19, 352);
            this.New_village_button.Name = "New_village_button";
            this.New_village_button.Size = new System.Drawing.Size(80, 34);
            this.New_village_button.TabIndex = 0;
            this.New_village_button.Text = "New";
            this.New_village_button.UseVisualStyleBackColor = true;
            this.New_village_button.Click += new System.EventHandler(this.New_Village_Click);
            // 
            // radiobutton_waterSource
            // 
            this.radiobutton_waterSource.AutoSize = true;
            this.radiobutton_waterSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radiobutton_waterSource.Location = new System.Drawing.Point(66, 242);
            this.radiobutton_waterSource.Name = "radiobutton_waterSource";
            this.radiobutton_waterSource.Size = new System.Drawing.Size(132, 24);
            this.radiobutton_waterSource.TabIndex = 1;
            this.radiobutton_waterSource.TabStop = true;
            this.radiobutton_waterSource.Text = "Water Source";
            this.radiobutton_waterSource.UseVisualStyleBackColor = true;
            this.radiobutton_waterSource.CheckedChanged += new System.EventHandler(this.WaterSource_Clicked);
            // 
            // radioButton_tree
            // 
            this.radioButton_tree.AutoSize = true;
            this.radioButton_tree.Location = new System.Drawing.Point(35, 219);
            this.radioButton_tree.Name = "radioButton_tree";
            this.radioButton_tree.Size = new System.Drawing.Size(66, 24);
            this.radioButton_tree.TabIndex = 2;
            this.radioButton_tree.TabStop = true;
            this.radioButton_tree.Text = "Tree";
            this.radioButton_tree.UseVisualStyleBackColor = true;
            this.radioButton_tree.CheckedChanged += new System.EventHandler(this.Tree_Clicked);
            // 
            // radioButton_House
            // 
            this.radioButton_House.AutoSize = true;
            this.radioButton_House.Location = new System.Drawing.Point(117, 219);
            this.radioButton_House.Name = "radioButton_House";
            this.radioButton_House.Size = new System.Drawing.Size(81, 24);
            this.radioButton_House.TabIndex = 3;
            this.radioButton_House.TabStop = true;
            this.radioButton_House.Text = "House";
            this.radioButton_House.UseVisualStyleBackColor = true;
            this.radioButton_House.CheckedChanged += new System.EventHandler(this.House_Click);
            // 
            // Open_village_button
            // 
            this.Open_village_button.Location = new System.Drawing.Point(117, 352);
            this.Open_village_button.Name = "Open_village_button";
            this.Open_village_button.Size = new System.Drawing.Size(81, 34);
            this.Open_village_button.TabIndex = 4;
            this.Open_village_button.Text = "Open";
            this.Open_village_button.UseVisualStyleBackColor = true;
            this.Open_village_button.Click += new System.EventHandler(this.Open_Village_Click);
            // 
            // Save_village_button
            // 
            this.Save_village_button.Location = new System.Drawing.Point(66, 309);
            this.Save_village_button.Name = "Save_village_button";
            this.Save_village_button.Size = new System.Drawing.Size(82, 28);
            this.Save_village_button.TabIndex = 5;
            this.Save_village_button.Text = "Save";
            this.Save_village_button.UseVisualStyleBackColor = true;
            this.Save_village_button.Click += new System.EventHandler(this.Save_Village_Click);
            // 
            // drawing_space
            // 
            this.drawing_space.Location = new System.Drawing.Point(12, 12);
            this.drawing_space.Name = "drawing_space";
            this.drawing_space.Size = new System.Drawing.Size(600, 400);
            this.drawing_space.TabIndex = 7;
            this.drawing_space.Paint += new System.Windows.Forms.PaintEventHandler(this._Click);
            this.drawing_space.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawing_click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu_bar
            // 
            this.Menu_bar.Controls.Add(this.label_ageOfVillagers);
            this.Menu_bar.Controls.Add(this.comboBox_NationList);
            this.Menu_bar.Controls.Add(this.Village_Name_textBox);
            this.Menu_bar.Controls.Add(this.radiobutton_waterSource);
            this.Menu_bar.Controls.Add(this.radioButton_House);
            this.Menu_bar.Controls.Add(this.radioButton_tree);
            this.Menu_bar.Controls.Add(this.Open_village_button);
            this.Menu_bar.Controls.Add(this.New_village_button);
            this.Menu_bar.Controls.Add(this.Save_village_button);
            this.Menu_bar.Location = new System.Drawing.Point(609, 12);
            this.Menu_bar.Name = "Menu_bar";
            this.Menu_bar.Size = new System.Drawing.Size(222, 400);
            this.Menu_bar.TabIndex = 9;
            this.Menu_bar.Click += new System.EventHandler(this._Click);
            // 
            // label_ageOfVillagers
            // 
            this.label_ageOfVillagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ageOfVillagers.Location = new System.Drawing.Point(19, 20);
            this.label_ageOfVillagers.Name = "label_ageOfVillagers";
            this.label_ageOfVillagers.Size = new System.Drawing.Size(200, 69);
            this.label_ageOfVillagers.TabIndex = 8;
            this.label_ageOfVillagers.Text = "Age of Villagers";
            this.label_ageOfVillagers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // this.label_ageOfVillagers.Click += new System.EventHandler(this.AgeOfVillagers_Click);
            // 
            // comboBox_NationList
            // 
            this.comboBox_NationList.FormattingEnabled = true;
            this.comboBox_NationList.Items.AddRange(new object[] {
            "Arab Bedouin",
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.comboBox_NationList.Location = new System.Drawing.Point(35, 146);
            this.comboBox_NationList.Name = "comboBox_NationList";
            this.comboBox_NationList.Size = new System.Drawing.Size(113, 28);
            this.comboBox_NationList.TabIndex = 7;
            this.comboBox_NationList.Text = " Nation";
            this.comboBox_NationList.SelectedIndexChanged += new System.EventHandler(this.Nation_Type);
            // 
            // Village_Name_textBox
            // 
            this.Village_Name_textBox.Location = new System.Drawing.Point(35, 101);
            this.Village_Name_textBox.Name = "Village_Name_textBox";
            this.Village_Name_textBox.Size = new System.Drawing.Size(113, 26);
            this.Village_Name_textBox.TabIndex = 6;
            this.Village_Name_textBox.Text = "Village Name";
            this.Village_Name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.Village_Name_textBox.Click += new System.EventHandler(this.Village_Name_Click);
            // 
            // Village_Editor_Window
            // 
            this.ClientSize = new System.Drawing.Size(845, 420);
            this.Controls.Add(this.Menu_bar);
            this.Controls.Add(this.drawing_space);
            this.Name = "Village_Editor_Window";
            this.Menu_bar.ResumeLayout(false);
            this.Menu_bar.PerformLayout();
            this.ResumeLayout(false);

        }








        #endregion

        private System.Windows.Forms.Button New_village_button;
        private System.Windows.Forms.RadioButton radiobutton_waterSource;
        private System.Windows.Forms.RadioButton radioButton_tree;
        private System.Windows.Forms.RadioButton radioButton_House;
        private System.Windows.Forms.Button Open_village_button;
        private System.Windows.Forms.Button Save_village_button;
        private System.Windows.Forms.Panel drawing_space;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel Menu_bar;
        private System.Windows.Forms.Label label_ageOfVillagers;
        private System.Windows.Forms.ComboBox comboBox_NationList;
        private System.Windows.Forms.TextBox Village_Name_textBox;
    }
}

