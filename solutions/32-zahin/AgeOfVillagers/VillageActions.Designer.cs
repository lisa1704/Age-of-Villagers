namespace AgeOfVillagers
{
    partial class VillageActions
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
            this.VillageName = new System.Windows.Forms.TextBox();
            this.WaterSourceButton = new System.Windows.Forms.RadioButton();
            this.HouseButton = new System.Windows.Forms.RadioButton();
            this.TreeButton = new System.Windows.Forms.RadioButton();
            this.NewVillage = new System.Windows.Forms.Button();
            this.OpenVillage = new System.Windows.Forms.Button();
            this.SaveVillage = new System.Windows.Forms.Button();
            this.Nations = new System.Windows.Forms.ComboBox();
            this.ConfirmSaveVillage = new System.Windows.Forms.SaveFileDialog();
            this.ConfirmOpenVillage = new System.Windows.Forms.OpenFileDialog();
            this.DrawingBoard = new System.Windows.Forms.Panel();
            this.OptionsBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsBoard
            // 
            this.OptionsBoard.Controls.Add(this.VillageName);
            this.OptionsBoard.Controls.Add(this.WaterSourceButton);
            this.OptionsBoard.Controls.Add(this.HouseButton);
            this.OptionsBoard.Controls.Add(this.TreeButton);
            this.OptionsBoard.Controls.Add(this.NewVillage);
            this.OptionsBoard.Controls.Add(this.OpenVillage);
            this.OptionsBoard.Controls.Add(this.SaveVillage);
            this.OptionsBoard.Controls.Add(this.Nations);
            this.OptionsBoard.Font = new System.Drawing.Font("Arial", 7.8F);
            this.OptionsBoard.Location = new System.Drawing.Point(609, 1);
            this.OptionsBoard.Name = "OptionsBoard";
            this.OptionsBoard.Size = new System.Drawing.Size(257, 400);
            this.OptionsBoard.TabIndex = 0;
            this.OptionsBoard.TabStop = false;
            this.OptionsBoard.Text = "Options Here";
            this.OptionsBoard.Enter += new System.EventHandler(this.OptionsBoard_Enter);
            // 
            // VillageName
            // 
            this.VillageName.Location = new System.Drawing.Point(48, 63);
            this.VillageName.Name = "VillageName";
            this.VillageName.Size = new System.Drawing.Size(154, 22);
            this.VillageName.TabIndex = 0;
            this.VillageName.Text = "Enter Village Name";
            this.VillageName.TextChanged += new System.EventHandler(this.VillageName_TextChanged);
            // 
            // WaterSourceButton
            // 
            this.WaterSourceButton.AutoSize = true;
            this.WaterSourceButton.Location = new System.Drawing.Point(60, 220);
            this.WaterSourceButton.Name = "WaterSourceButton";
            this.WaterSourceButton.Size = new System.Drawing.Size(115, 20);
            this.WaterSourceButton.TabIndex = 9;
            this.WaterSourceButton.TabStop = true;
            this.WaterSourceButton.Text = "Water Source";
            this.WaterSourceButton.UseVisualStyleBackColor = true;
            this.WaterSourceButton.CheckedChanged += new System.EventHandler(this.WaterSourceButton_CheckedChanged);
            // 
            // HouseButton
            // 
            this.HouseButton.AutoSize = true;
            this.HouseButton.Location = new System.Drawing.Point(60, 194);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(69, 20);
            this.HouseButton.TabIndex = 8;
            this.HouseButton.TabStop = true;
            this.HouseButton.Text = "House";
            this.HouseButton.UseVisualStyleBackColor = true;
            this.HouseButton.CheckedChanged += new System.EventHandler(this.House_CheckedChanged);
            // 
            // TreeButton
            // 
            this.TreeButton.AutoSize = true;
            this.TreeButton.Location = new System.Drawing.Point(60, 168);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(58, 20);
            this.TreeButton.TabIndex = 7;
            this.TreeButton.TabStop = true;
            this.TreeButton.Text = "Tree";
            this.TreeButton.UseVisualStyleBackColor = true;
            this.TreeButton.CheckedChanged += new System.EventHandler(this.TreeButton_CheckedChanged);
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
            this.Nations.SelectedIndexChanged += new System.EventHandler(this.NationsName);
            // 
            // ConfirmOpenVillage
            // 
            this.ConfirmOpenVillage.InitialDirectory = "D:\\3-1\\SWE 4502 (Design Pattern Lab)\\Assignment Test\\AgeOfVillagers";
            this.ConfirmOpenVillage.FileOk += new System.ComponentModel.CancelEventHandler(this.ConfirmOpenVillage_FileOk);
            // 
            // DrawingBoard
            // 
            this.DrawingBoard.Location = new System.Drawing.Point(0, 0);
            this.DrawingBoard.Name = "DrawingBoard";
            this.DrawingBoard.Size = new System.Drawing.Size(603, 401);
            this.DrawingBoard.TabIndex = 1;
            this.DrawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingBoard_Click);
            // 
            // VillageActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 403);
            this.Controls.Add(this.DrawingBoard);
            this.Controls.Add(this.OptionsBoard);
            this.Font = new System.Drawing.Font("Arial", 7.8F);
            this.Name = "VillageActions";
            this.Text = "VillageBoard";
            this.Load += new System.EventHandler(this.NewVillage_Load);
            this.OptionsBoard.ResumeLayout(false);
            this.OptionsBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OptionsBoard;
        private System.Windows.Forms.ComboBox Nations;
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button NewVillage;
        private System.Windows.Forms.Button OpenVillage;
        private System.Windows.Forms.SaveFileDialog ConfirmSaveVillage;
        private System.Windows.Forms.OpenFileDialog ConfirmOpenVillage;
        private System.Windows.Forms.RadioButton WaterSourceButton;
        private System.Windows.Forms.RadioButton HouseButton;
        private System.Windows.Forms.RadioButton TreeButton;
        private System.Windows.Forms.TextBox VillageName;
        private System.Windows.Forms.Panel DrawingBoard;
    }
}

