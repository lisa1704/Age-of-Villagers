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
            this.titlelabel = new System.Windows.Forms.Label();
            this.toolpanel = new System.Windows.Forms.Panel();
            this.nation = new System.Windows.Forms.ListBox();
            this.villagename = new System.Windows.Forms.TextBox();
            this.drawingpanel = new System.Windows.Forms.Panel();
            this.toolpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // savevillage
            // 
            this.savevillage.Location = new System.Drawing.Point(66, 252);
            this.savevillage.Name = "savevillage";
            this.savevillage.Size = new System.Drawing.Size(148, 31);
            this.savevillage.TabIndex = 0;
            this.savevillage.Text = "Save Village";
            this.savevillage.UseVisualStyleBackColor = true;
            this.savevillage.Click += new System.EventHandler(this.savevillage_Click);
            // 
            // newvillage
            // 
            this.newvillage.Location = new System.Drawing.Point(66, 298);
            this.newvillage.Name = "newvillage";
            this.newvillage.Size = new System.Drawing.Size(148, 31);
            this.newvillage.TabIndex = 1;
            this.newvillage.Text = "New Village";
            this.newvillage.UseVisualStyleBackColor = true;
            this.newvillage.Click += new System.EventHandler(this.newvillage_Click);
            // 
            // openvillage
            // 
            this.openvillage.Location = new System.Drawing.Point(66, 351);
            this.openvillage.Name = "openvillage";
            this.openvillage.Size = new System.Drawing.Size(148, 28);
            this.openvillage.TabIndex = 2;
            this.openvillage.Text = "Open Village";
            this.openvillage.UseVisualStyleBackColor = true;
            this.openvillage.Click += new System.EventHandler(this.openvillage_Click);
            // 
            // treeradio
            // 
            this.treeradio.AutoSize = true;
            this.treeradio.Location = new System.Drawing.Point(69, 162);
            this.treeradio.Name = "treeradio";
            this.treeradio.Size = new System.Drawing.Size(58, 24);
            this.treeradio.TabIndex = 3;
            this.treeradio.TabStop = true;
            this.treeradio.Text = "Tree";
            this.treeradio.UseVisualStyleBackColor = true;
            this.treeradio.CheckedChanged += new System.EventHandler(this.treeradio_CheckedChanged);
            this.treeradio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TreeRadioMouseClicked);
            // 
            // houseradio
            // 
            this.houseradio.AutoSize = true;
            this.houseradio.Location = new System.Drawing.Point(69, 192);
            this.houseradio.Name = "houseradio";
            this.houseradio.Size = new System.Drawing.Size(72, 24);
            this.houseradio.TabIndex = 4;
            this.houseradio.TabStop = true;
            this.houseradio.Text = "House";
            this.houseradio.UseVisualStyleBackColor = true;
            this.houseradio.CheckedChanged += new System.EventHandler(this.houseradio_CheckedChanged);
            this.houseradio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HouseRadioMouseClicked);
            // 
            // waterradio
            // 
            this.waterradio.AutoSize = true;
            this.waterradio.Location = new System.Drawing.Point(69, 222);
            this.waterradio.Name = "waterradio";
            this.waterradio.Size = new System.Drawing.Size(118, 24);
            this.waterradio.TabIndex = 5;
            this.waterradio.TabStop = true;
            this.waterradio.Text = "Water Source";
            this.waterradio.UseVisualStyleBackColor = true;
            this.waterradio.CheckedChanged += new System.EventHandler(this.waterradio_CheckedChanged);
            this.waterradio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WaterSourceRadioMouseClicked);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titlelabel.Location = new System.Drawing.Point(29, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(239, 35);
            this.titlelabel.TabIndex = 6;
            this.titlelabel.Text = "Age of Villagers";
            this.titlelabel.Click += new System.EventHandler(this.titlelabel_Click);
            // 
            // toolpanel
            // 
            this.toolpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolpanel.Controls.Add(this.nation);
            this.toolpanel.Controls.Add(this.villagename);
            this.toolpanel.Controls.Add(this.titlelabel);
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
            // nation
            // 
            this.nation.FormattingEnabled = true;
            this.nation.ItemHeight = 20;
            this.nation.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.nation.Location = new System.Drawing.Point(56, 114);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(178, 24);
            this.nation.TabIndex = 10;
            this.nation.SelectedIndexChanged += new System.EventHandler(this.nation_SelectedIndexChanged);
            this.nation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nation_KeyDown);
            // 
            // villagename
            // 
            this.villagename.BackColor = System.Drawing.SystemColors.HighlightText;
            this.villagename.Location = new System.Drawing.Point(56, 64);
            this.villagename.Name = "villagename";
            this.villagename.Size = new System.Drawing.Size(178, 27);
            this.villagename.TabIndex = 5;
            this.villagename.TextChanged += new System.EventHandler(this.villagename_TextChanged);
            this.villagename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.villagename_KeyDown);
            // 
            // drawingpanel
            // 
            this.drawingpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingpanel.Location = new System.Drawing.Point(12, 23);
            this.drawingpanel.Name = "drawingpanel";
            this.drawingpanel.Size = new System.Drawing.Size(600, 400);
            this.drawingpanel.TabIndex = 10;
            this.drawingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingpanel_Paint);
            this.drawingpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingpanel_MouseClick);
            this.drawingpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingpanel_MouseDown);
            this.drawingpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingpanel_MouseMove);
            this.drawingpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingpanel_MouseUp);
            // 
            // VillageEditorWindow
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 460);
            this.Controls.Add(this.drawingpanel);
            this.Controls.Add(this.toolpanel);
            this.Name = "VillageEditorWindow";
            this.Text = "Age of Villagers";
            this.Load += new System.EventHandler(this.VillageWindow_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingpanel_MouseUp);
            this.toolpanel.ResumeLayout(false);
            this.toolpanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button savevillage;
        private System.Windows.Forms.Button newvillage;
        private System.Windows.Forms.Button openvillage;
        private System.Windows.Forms.RadioButton treeradio;
        private System.Windows.Forms.RadioButton houseradio;
        private System.Windows.Forms.RadioButton waterradio;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Panel toolpanel;
        private System.Windows.Forms.Panel drawingpanel;
        private System.Windows.Forms.TextBox villagename;
        private System.Windows.Forms.ListBox nation;
    }
}