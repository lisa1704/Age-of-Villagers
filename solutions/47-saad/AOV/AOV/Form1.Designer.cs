namespace AOV
{
    partial class AgeOfVillagers
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
            this.NameOfVillage = new System.Windows.Forms.TextBox();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.Nation = new System.Windows.Forms.ComboBox();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.House = new System.Windows.Forms.RadioButton();
            this.WaterSource = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // NameOfVillage
            // 
            this.NameOfVillage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NameOfVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfVillage.Location = new System.Drawing.Point(616, 62);
            this.NameOfVillage.Name = "NameOfVillage";
            this.NameOfVillage.Size = new System.Drawing.Size(169, 22);
            this.NameOfVillage.TabIndex = 0;
            this.NameOfVillage.Text = "Name your village";
            this.NameOfVillage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveVillage
            // 
            this.SaveVillage.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveVillage.Location = new System.Drawing.Point(661, 346);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(99, 31);
            this.SaveVillage.TabIndex = 3;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = false;
            // 
            // OpenVillage
            // 
            this.OpenVillage.BackColor = System.Drawing.Color.Yellow;
            this.OpenVillage.Location = new System.Drawing.Point(713, 383);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(84, 31);
            this.OpenVillage.TabIndex = 5;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = false;
            // 
            // NewVillage
            // 
            this.NewVillage.BackColor = System.Drawing.Color.IndianRed;
            this.NewVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVillage.Location = new System.Drawing.Point(616, 383);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(91, 31);
            this.NewVillage.TabIndex = 6;
            this.NewVillage.Text = "New village";
            this.NewVillage.UseVisualStyleBackColor = false;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Canvas.Location = new System.Drawing.Point(10, 14);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(600, 400);
            this.Canvas.TabIndex = 7;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(635, 14);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(10);
            this.Label.Size = new System.Drawing.Size(139, 36);
            this.Label.TabIndex = 9;
            this.Label.Text = "Age of Villagers";
            this.Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Nation
            // 
            this.Nation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nation.FormattingEnabled = true;
            this.Nation.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.Nation.Location = new System.Drawing.Point(616, 101);
            this.Nation.Name = "Nation";
            this.Nation.Size = new System.Drawing.Size(169, 24);
            this.Nation.TabIndex = 11;
            this.Nation.Text = "Select nation";
            this.Nation.SelectedIndexChanged += new System.EventHandler(this.Nation_SelectedIndexChanged);
            // 
            // Tree
            // 
            this.Tree.AutoSize = true;
            this.Tree.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Tree.Location = new System.Drawing.Point(616, 175);
            this.Tree.Name = "Tree";
            this.Tree.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.Tree.Size = new System.Drawing.Size(87, 27);
            this.Tree.TabIndex = 15;
            this.Tree.TabStop = true;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = false;
            this.Tree.CheckedChanged += new System.EventHandler(this.Tree_CheckedChanged);
            // 
            // House
            // 
            this.House.AutoSize = true;
            this.House.BackColor = System.Drawing.Color.Goldenrod;
            this.House.Location = new System.Drawing.Point(709, 175);
            this.House.Name = "House";
            this.House.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.House.Size = new System.Drawing.Size(96, 27);
            this.House.TabIndex = 16;
            this.House.TabStop = true;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = false;
            this.House.CheckedChanged += new System.EventHandler(this.House_CheckedChanged);
            // 
            // WaterSource
            // 
            this.WaterSource.AutoSize = true;
            this.WaterSource.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.WaterSource.Location = new System.Drawing.Point(643, 218);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.WaterSource.Size = new System.Drawing.Size(131, 27);
            this.WaterSource.TabIndex = 18;
            this.WaterSource.TabStop = true;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = false;
            this.WaterSource.CheckedChanged += new System.EventHandler(this.WaterSource_CheckedChanged);
            // 
            // AgeOfVillagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WaterSource);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Nation);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.NewVillage);
            this.Controls.Add(this.OpenVillage);
            this.Controls.Add(this.SaveVillage);
            this.Controls.Add(this.NameOfVillage);
            this.Name = "AgeOfVillagers";
            this.Text = "Age of Villagers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameOfVillage;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ComboBox Nation;
        private System.Windows.Forms.RadioButton Tree;
        private System.Windows.Forms.RadioButton House;
        private System.Windows.Forms.RadioButton WaterSource;
    }
}

