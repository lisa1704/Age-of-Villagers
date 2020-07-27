namespace AgeOfVillagers
{
    partial class CreateNewVillage
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
            this.OptionsBoard = new System.Windows.Forms.GroupBox();
            this.DrawingBoard = new System.Windows.Forms.GroupBox();
            this.Nations = new System.Windows.Forms.ComboBox();
            this.HouseButton = new System.Windows.Forms.Button();
            this.WaterButton = new System.Windows.Forms.Button();
            this.TreeButton = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.NewVillage = new System.Windows.Forms.Button();
            this.ChooseVillage = new System.Windows.Forms.FolderBrowserDialog();
            this.OptionsBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsBoard
            // 
            this.OptionsBoard.Controls.Add(this.NewVillage);
            this.OptionsBoard.Controls.Add(this.OpenVillage);
            this.OptionsBoard.Controls.Add(this.SaveVillage);
            this.OptionsBoard.Controls.Add(this.TreeButton);
            this.OptionsBoard.Controls.Add(this.WaterButton);
            this.OptionsBoard.Controls.Add(this.HouseButton);
            this.OptionsBoard.Controls.Add(this.Nations);
            this.OptionsBoard.Font = new System.Drawing.Font("Arial", 7.8F);
            this.OptionsBoard.Location = new System.Drawing.Point(530, 1);
            this.OptionsBoard.Name = "OptionsBoard";
            this.OptionsBoard.Size = new System.Drawing.Size(255, 400);
            this.OptionsBoard.TabIndex = 0;
            this.OptionsBoard.TabStop = false;
            this.OptionsBoard.Text = "Options Here";
            // 
            // DrawingBoard
            // 
            this.DrawingBoard.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawingBoard.Location = new System.Drawing.Point(0, 1);
            this.DrawingBoard.Name = "DrawingBoard";
            this.DrawingBoard.Size = new System.Drawing.Size(525, 400);
            this.DrawingBoard.TabIndex = 0;
            this.DrawingBoard.TabStop = false;
            this.DrawingBoard.Text = "Drawing Board";
            // 
            // Nations
            // 
            this.Nations.AllowDrop = true;
            this.Nations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nations.FormattingEnabled = true;
            this.Nations.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.Nations.Location = new System.Drawing.Point(48, 104);
            this.Nations.Name = "Nations";
            this.Nations.Size = new System.Drawing.Size(154, 24);
            this.Nations.TabIndex = 0;
            this.Nations.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // HouseButton
            // 
            this.HouseButton.Location = new System.Drawing.Point(136, 179);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(66, 23);
            this.HouseButton.TabIndex = 1;
            this.HouseButton.Text = "House";
            this.HouseButton.UseVisualStyleBackColor = true;
            this.HouseButton.Click += new System.EventHandler(this.HouseButton_Click);
            // 
            // WaterButton
            // 
            this.WaterButton.Location = new System.Drawing.Point(60, 218);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(131, 25);
            this.WaterButton.TabIndex = 2;
            this.WaterButton.Text = "Water Source";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.WaterButton_Click);
            // 
            // TreeButton
            // 
            this.TreeButton.Location = new System.Drawing.Point(48, 179);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(66, 23);
            this.TreeButton.TabIndex = 3;
            this.TreeButton.Text = "Tree";
            this.TreeButton.UseVisualStyleBackColor = true;
            this.TreeButton.Click += new System.EventHandler(this.TreeButton_Click);
            // 
            // SaveVillage
            // 
            this.SaveVillage.Font = new System.Drawing.Font("Arial", 7.8F);
            this.SaveVillage.Location = new System.Drawing.Point(60, 334);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(131, 25);
            this.SaveVillage.TabIndex = 4;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            this.SaveVillage.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // OpenVillage
            // 
            this.OpenVillage.Font = new System.Drawing.Font("Arial", 7.8F);
            this.OpenVillage.Location = new System.Drawing.Point(133, 365);
            this.OpenVillage.Name = "OpenVillage";
            this.OpenVillage.Size = new System.Drawing.Size(110, 25);
            this.OpenVillage.TabIndex = 5;
            this.OpenVillage.Text = "Open Village";
            this.OpenVillage.UseVisualStyleBackColor = true;
            this.OpenVillage.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // NewVillage
            // 
            this.NewVillage.Font = new System.Drawing.Font("Arial", 7.8F);
            this.NewVillage.Location = new System.Drawing.Point(15, 365);
            this.NewVillage.Name = "NewVillage";
            this.NewVillage.Size = new System.Drawing.Size(112, 25);
            this.NewVillage.TabIndex = 6;
            this.NewVillage.Text = "New Village";
            this.NewVillage.UseVisualStyleBackColor = true;
            this.NewVillage.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // ChooseVillage
            // 
            this.ChooseVillage.SelectedPath = "D:\\3-1\\SWE 4502 (Design Pattern Lab)\\Assignment Test\\AgeOfVillagers";
            // 
            // CreateNewVillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 403);
            this.Controls.Add(this.DrawingBoard);
            this.Controls.Add(this.OptionsBoard);
            this.Font = new System.Drawing.Font("Arial", 7.8F);
            this.Name = "CreateNewVillage";
            this.Text = "VillageBoard";
            this.Load += new System.EventHandler(this.NewVillage_Load);
            this.OptionsBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OptionsBoard;
        private System.Windows.Forms.GroupBox DrawingBoard;
        private System.Windows.Forms.ComboBox Nations;
        private System.Windows.Forms.Button TreeButton;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.Button HouseButton;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.FolderBrowserDialog ChooseVillage;
    }
}

