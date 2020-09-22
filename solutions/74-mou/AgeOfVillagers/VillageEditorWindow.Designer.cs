using System;

namespace AgeOfVillagers
{
    partial class VillageEditorWindow
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
        private void InitializeComponent()
        {
            this.savevillage = new System.Windows.Forms.Button();
            this.newvillage = new System.Windows.Forms.Button();
            this.openvillage = new System.Windows.Forms.Button();
            this.treeradio = new System.Windows.Forms.RadioButton();
            this.houseradio = new System.Windows.Forms.RadioButton();
            this.waterradio = new System.Windows.Forms.RadioButton();
            this.AgeOfVillagerstitlelabel = new System.Windows.Forms.Label();
            this.toolpanel = new System.Windows.Forms.Panel();
            this.NationTypelistBox = new System.Windows.Forms.ListBox();
            this.Itemslabel = new System.Windows.Forms.Label();
            this.Nationlabel = new System.Windows.Forms.Label();
            this.VillageNamelabel = new System.Windows.Forms.Label();
            this.villagename = new System.Windows.Forms.TextBox();
            this.drawingpanel = new System.Windows.Forms.Panel();
            this.toolpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // savevillage
            // 
            this.savevillage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.savevillage.Location = new System.Drawing.Point(66, 287);
            this.savevillage.Name = "savevillage";
            this.savevillage.Size = new System.Drawing.Size(166, 31);
            this.savevillage.TabIndex = 0;
            this.savevillage.Text = "Save Village";
            this.savevillage.UseVisualStyleBackColor = false;
            this.savevillage.Click += new System.EventHandler(this.savevillage_Click);
            // 
            // newvillage
            // 
            this.newvillage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.newvillage.Location = new System.Drawing.Point(66, 324);
            this.newvillage.Name = "newvillage";
            this.newvillage.Size = new System.Drawing.Size(166, 31);
            this.newvillage.TabIndex = 1;
            this.newvillage.Text = "New Village";
            this.newvillage.UseVisualStyleBackColor = false;
            this.newvillage.Click += new System.EventHandler(this.newvillage_Click);
            // 
            // openvillage
            // 
            this.openvillage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.openvillage.Location = new System.Drawing.Point(66, 361);
            this.openvillage.Name = "openvillage";
            this.openvillage.Size = new System.Drawing.Size(166, 28);
            this.openvillage.TabIndex = 2;
            this.openvillage.Text = "Open Village";
            this.openvillage.UseVisualStyleBackColor = false;
            this.openvillage.Click += new System.EventHandler(this.openvillage_Click);
            // 
            // treeradio
            // 
            this.treeradio.AutoSize = true;
            this.treeradio.Location = new System.Drawing.Point(66, 227);
            this.treeradio.Name = "treeradio";
            this.treeradio.Size = new System.Drawing.Size(58, 24);
            this.treeradio.TabIndex = 3;
            this.treeradio.TabStop = true;
            this.treeradio.Text = "Tree";
            this.treeradio.UseVisualStyleBackColor = true;
            this.treeradio.CheckedChanged += new System.EventHandler(this.TreeRadio_CheckedChanged);
            // 
            // houseradio
            // 
            this.houseradio.AutoSize = true;
            this.houseradio.Location = new System.Drawing.Point(152, 227);
            this.houseradio.Name = "houseradio";
            this.houseradio.Size = new System.Drawing.Size(72, 24);
            this.houseradio.TabIndex = 4;
            this.houseradio.TabStop = true;
            this.houseradio.Text = "House";
            this.houseradio.UseVisualStyleBackColor = true;
            this.houseradio.CheckedChanged += new System.EventHandler(this.HouseRadio_CheckedChanged);
            // 
            // waterradio
            // 
            this.waterradio.AutoSize = true;
            this.waterradio.Location = new System.Drawing.Point(66, 257);
            this.waterradio.Name = "waterradio";
            this.waterradio.Size = new System.Drawing.Size(118, 24);
            this.waterradio.TabIndex = 5;
            this.waterradio.TabStop = true;
            this.waterradio.Text = "Water Source";
            this.waterradio.UseVisualStyleBackColor = true;
            this.waterradio.CheckedChanged += new System.EventHandler(this.WAtersourceRadioCheckedChanged);
            // 
            // AgeOfVillagerstitlelabel
            // 
            this.AgeOfVillagerstitlelabel.AutoSize = true;
            this.AgeOfVillagerstitlelabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeOfVillagerstitlelabel.Location = new System.Drawing.Point(29, 9);
            this.AgeOfVillagerstitlelabel.Name = "AgeOfVillagerstitlelabel";
            this.AgeOfVillagerstitlelabel.Size = new System.Drawing.Size(222, 32);
            this.AgeOfVillagerstitlelabel.TabIndex = 6;
            this.AgeOfVillagerstitlelabel.Text = "Age of Villagers";
            this.AgeOfVillagerstitlelabel.Click += new System.EventHandler(this.titlelabel_Click);
            // 
            // toolpanel
            // 
            this.toolpanel.BackColor = System.Drawing.Color.Lavender;
            this.toolpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolpanel.Controls.Add(this.NationTypelistBox);
            this.toolpanel.Controls.Add(this.Itemslabel);
            this.toolpanel.Controls.Add(this.Nationlabel);
            this.toolpanel.Controls.Add(this.VillageNamelabel);
            this.toolpanel.Controls.Add(this.villagename);
            this.toolpanel.Controls.Add(this.AgeOfVillagerstitlelabel);
            this.toolpanel.Controls.Add(this.savevillage);
            this.toolpanel.Controls.Add(this.newvillage);
            this.toolpanel.Controls.Add(this.openvillage);
            this.toolpanel.Controls.Add(this.waterradio);
            this.toolpanel.Controls.Add(this.houseradio);
            this.toolpanel.Controls.Add(this.treeradio);
            this.toolpanel.Location = new System.Drawing.Point(641, 23);
            this.toolpanel.Name = "toolpanel";
            this.toolpanel.Size = new System.Drawing.Size(296, 400);
            this.toolpanel.TabIndex = 9;
            this.toolpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toolpanel_Paint);
            // 
            // NationTypelistBox
            // 
            this.NationTypelistBox.FormattingEnabled = true;
            this.NationTypelistBox.ItemHeight = 20;
            this.NationTypelistBox.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationTypelistBox.Location = new System.Drawing.Point(67, 155);
            this.NationTypelistBox.Name = "NationTypelistBox";
            this.NationTypelistBox.Size = new System.Drawing.Size(165, 24);
            this.NationTypelistBox.TabIndex = 16;
            this.NationTypelistBox.SelectedIndexChanged += new System.EventHandler(this.NationTypelistBox_SelectedIndexChanged);
            // 
            // Itemslabel
            // 
            this.Itemslabel.AutoSize = true;
            this.Itemslabel.Location = new System.Drawing.Point(66, 204);
            this.Itemslabel.Name = "Itemslabel";
            this.Itemslabel.Size = new System.Drawing.Size(48, 20);
            this.Itemslabel.TabIndex = 13;
            this.Itemslabel.Text = "Items:";
            this.Itemslabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Nationlabel
            // 
            this.Nationlabel.AutoSize = true;
            this.Nationlabel.Location = new System.Drawing.Point(67, 132);
            this.Nationlabel.Name = "Nationlabel";
            this.Nationlabel.Size = new System.Drawing.Size(57, 20);
            this.Nationlabel.TabIndex = 12;
            this.Nationlabel.Text = "Nation:";
            this.Nationlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // VillageNamelabel
            // 
            this.VillageNamelabel.AutoSize = true;
            this.VillageNamelabel.Location = new System.Drawing.Point(67, 64);
            this.VillageNamelabel.Name = "VillageNamelabel";
            this.VillageNamelabel.Size = new System.Drawing.Size(102, 20);
            this.VillageNamelabel.TabIndex = 11;
            this.VillageNamelabel.Text = "Village Name:";
            this.VillageNamelabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // villagename
            // 
            this.villagename.BackColor = System.Drawing.SystemColors.HighlightText;
            this.villagename.Location = new System.Drawing.Point(66, 87);
            this.villagename.Name = "villagename";
            this.villagename.Size = new System.Drawing.Size(158, 27);
            this.villagename.TabIndex = 14;
            this.villagename.TextChanged += new System.EventHandler(this.villagenameTextChanged);
            // 
            // drawingpanel
            // 
            this.drawingpanel.BackColor = System.Drawing.Color.White;
            this.drawingpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingpanel.Location = new System.Drawing.Point(12, 23);
            this.drawingpanel.Name = "drawingpanel";
            this.drawingpanel.Size = new System.Drawing.Size(600, 400);
            this.drawingpanel.TabIndex = 10;
            this.drawingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintDrawPanel);
            this.drawingpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingpanel_MouseClick);
            // 
            // VillageEditorWindow
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(956, 460);
            this.Controls.Add(this.drawingpanel);
            this.Controls.Add(this.toolpanel);
            this.Name = "VillageEditorWindow";
            this.Text = "Age of Villagers";
            this.Load += new System.EventHandler(this.VillageWindow_Load);
            this.toolpanel.ResumeLayout(false);
            this.toolpanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button savevillage;
        private System.Windows.Forms.Button newvillage;
        private System.Windows.Forms.Button openvillage;
        private System.Windows.Forms.ListBox NationTypelistBox;
        private System.Windows.Forms.RadioButton treeradio;
        private System.Windows.Forms.RadioButton houseradio;
        private System.Windows.Forms.RadioButton waterradio;
        private System.Windows.Forms.Label AgeOfVillagerstitlelabel;
        private System.Windows.Forms.Panel toolpanel;
        private System.Windows.Forms.Panel drawingpanel;
        private System.Windows.Forms.TextBox villagename;
        private System.Windows.Forms.Label VillageNamelabel;
        private System.Windows.Forms.Label Itemslabel;
        private System.Windows.Forms.Label Nationlabel;
    }
}