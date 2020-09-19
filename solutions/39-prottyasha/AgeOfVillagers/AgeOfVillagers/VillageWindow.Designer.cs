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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.TableLayoutPanel();
            this.rbtn_waterSource = new System.Windows.Forms.RadioButton();
            this.rbtn_house = new System.Windows.Forms.RadioButton();
            this.rbtn_tree = new System.Windows.Forms.RadioButton();
            this.Label_villName = new System.Windows.Forms.Label();
            this.btn_saveVillage = new System.Windows.Forms.Button();
            this.btn_newVillage = new System.Windows.Forms.Button();
            this.nation_selector = new System.Windows.Forms.ComboBox();
            this.Lbl_aovtitle = new System.Windows.Forms.Label();
            this.btn_openVillage = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.White;
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseClick);
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SidePanel.AutoSize = true;
            this.SidePanel.ColumnCount = 1;
            this.SidePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SidePanel.Controls.Add(this.rbtn_waterSource, 0, 5);
            this.SidePanel.Controls.Add(this.rbtn_house, 0, 4);
            this.SidePanel.Controls.Add(this.rbtn_tree, 0, 3);
            this.SidePanel.Controls.Add(this.Label_villName, 0, 1);
            this.SidePanel.Controls.Add(this.btn_saveVillage, 0, 7);
            this.SidePanel.Controls.Add(this.btn_newVillage, 0, 6);
            this.SidePanel.Controls.Add(this.nation_selector, 0, 2);
            this.SidePanel.Controls.Add(this.Lbl_aovtitle, 0, 0);
            this.SidePanel.Controls.Add(this.btn_openVillage, 0, 8);
            this.SidePanel.Location = new System.Drawing.Point(600, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Padding = new System.Windows.Forms.Padding(15, 30, 15, 15);
            this.SidePanel.RowCount = 9;
            this.SidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.SidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.SidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.SidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.SidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.SidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.SidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.SidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.SidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.SidePanel.Size = new System.Drawing.Size(199, 420);
            this.SidePanel.TabIndex = 1;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // rbtn_waterSource
            // 
            this.rbtn_waterSource.AutoSize = true;
            this.rbtn_waterSource.Location = new System.Drawing.Point(18, 262);
            this.rbtn_waterSource.Name = "rbtn_waterSource";
            this.rbtn_waterSource.Size = new System.Drawing.Size(118, 24);
            this.rbtn_waterSource.TabIndex = 3;
            this.rbtn_waterSource.TabStop = true;
            this.rbtn_waterSource.Text = "Water Source";
            this.rbtn_waterSource.UseVisualStyleBackColor = true;
            this.rbtn_waterSource.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_house
            // 
            this.rbtn_house.AutoSize = true;
            this.rbtn_house.Location = new System.Drawing.Point(18, 228);
            this.rbtn_house.Name = "rbtn_house";
            this.rbtn_house.Size = new System.Drawing.Size(72, 24);
            this.rbtn_house.TabIndex = 3;
            this.rbtn_house.TabStop = true;
            this.rbtn_house.Text = "House";
            this.rbtn_house.UseVisualStyleBackColor = true;
            this.rbtn_house.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_tree
            // 
            this.rbtn_tree.AutoSize = true;
            this.rbtn_tree.Location = new System.Drawing.Point(18, 195);
            this.rbtn_tree.Name = "rbtn_tree";
            this.rbtn_tree.Size = new System.Drawing.Size(58, 24);
            this.rbtn_tree.TabIndex = 3;
            this.rbtn_tree.TabStop = true;
            this.rbtn_tree.Text = "Tree";
            this.rbtn_tree.UseVisualStyleBackColor = true;
            this.rbtn_tree.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Label_villName
            // 
            this.Label_villName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_villName.AutoSize = true;
            this.Label_villName.Location = new System.Drawing.Point(50, 69);
            this.Label_villName.Name = "Label_villName";
            this.Label_villName.Size = new System.Drawing.Size(99, 20);
            this.Label_villName.TabIndex = 5;
            this.Label_villName.Text = "Village Name";
            this.Label_villName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_villName.Click += new System.EventHandler(this.Label_villName_Click);
            // 
            // btn_saveVillage
            // 
            this.btn_saveVillage.Location = new System.Drawing.Point(18, 331);
            this.btn_saveVillage.Name = "btn_saveVillage";
            this.btn_saveVillage.Size = new System.Drawing.Size(163, 30);
            this.btn_saveVillage.TabIndex = 4;
            this.btn_saveVillage.Text = "Save Village";
            this.btn_saveVillage.UseVisualStyleBackColor = true;
            this.btn_saveVillage.Click += new System.EventHandler(this.btn_saveVillage_Click);
            // 
            // btn_newVillage
            // 
            this.btn_newVillage.Location = new System.Drawing.Point(18, 295);
            this.btn_newVillage.Name = "btn_newVillage";
            this.btn_newVillage.Size = new System.Drawing.Size(163, 30);
            this.btn_newVillage.TabIndex = 4;
            this.btn_newVillage.Text = "New Village";
            this.btn_newVillage.UseVisualStyleBackColor = true;
            this.btn_newVillage.Click += new System.EventHandler(this.btn_newVillage_Click);
            // 
            // nation_selector
            // 
            this.nation_selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nation_selector.FormattingEnabled = true;
            this.nation_selector.Items.AddRange(new object[] {
            "Arab Bedouins",
            "Bangladeshi Farmers",
            "Egyptian Kings"});
            this.nation_selector.Location = new System.Drawing.Point(18, 101);
            this.nation_selector.Name = "nation_selector";
            this.nation_selector.Size = new System.Drawing.Size(163, 28);
            this.nation_selector.TabIndex = 6;
            // 
            // Lbl_aovtitle
            // 
            this.Lbl_aovtitle.AutoSize = true;
            this.Lbl_aovtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_aovtitle.Location = new System.Drawing.Point(18, 30);
            this.Lbl_aovtitle.Name = "Lbl_aovtitle";
            this.Lbl_aovtitle.Size = new System.Drawing.Size(163, 28);
            this.Lbl_aovtitle.TabIndex = 0;
            this.Lbl_aovtitle.Text = "Age of Villagers";
            this.Lbl_aovtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_aovtitle.Click += new System.EventHandler(this.Lbl_aovtitle_Click);
            // 
            // btn_openVillage
            // 
            this.btn_openVillage.Location = new System.Drawing.Point(18, 367);
            this.btn_openVillage.Name = "btn_openVillage";
            this.btn_openVillage.Size = new System.Drawing.Size(163, 35);
            this.btn_openVillage.TabIndex = 4;
            this.btn_openVillage.Text = "Open Village";
            this.btn_openVillage.UseVisualStyleBackColor = true;
            this.btn_openVillage.Click += new System.EventHandler(this.btn_openVillage_Click);
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.DrawingPanel);
            this.Name = "VillageWindow";
            this.Text = "VillageWindow";
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.TableLayoutPanel SidePanel;
        private System.Windows.Forms.Label Lbl_aovtitle;
        private System.Windows.Forms.RadioButton rbtn_tree;
        private System.Windows.Forms.Button btn_openVillage;
        private System.Windows.Forms.Button btn_newVillage;
        private System.Windows.Forms.RadioButton rbtn_waterSource;
        private System.Windows.Forms.RadioButton rbtn_house;
        private System.Windows.Forms.Button btn_saveVillage;
        private System.Windows.Forms.Label Label_villName;
        private System.Windows.Forms.ComboBox nation_selector;
    }
}

