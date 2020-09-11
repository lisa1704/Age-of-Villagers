namespace AgeOfVillagers
{
    partial class NewVillageCreateForm
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
            this.lblVillageName = new System.Windows.Forms.Label();
            this.txtboxVillageName = new System.Windows.Forms.TextBox();
            this.lblNationName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.comboBoxNationName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblVillageName
            // 
            this.lblVillageName.AutoSize = true;
            this.lblVillageName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVillageName.Location = new System.Drawing.Point(123, 155);
            this.lblVillageName.Name = "lblVillageName";
            this.lblVillageName.Size = new System.Drawing.Size(157, 32);
            this.lblVillageName.TabIndex = 0;
            this.lblVillageName.Text = "Village Name";
            // 
            // txtboxVillageName
            // 
            this.txtboxVillageName.Location = new System.Drawing.Point(286, 161);
            this.txtboxVillageName.Name = "txtboxVillageName";
            this.txtboxVillageName.Size = new System.Drawing.Size(316, 27);
            this.txtboxVillageName.TabIndex = 1;
            // 
            // lblNationName
            // 
            this.lblNationName.AutoSize = true;
            this.lblNationName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNationName.Location = new System.Drawing.Point(123, 95);
            this.lblNationName.Name = "lblNationName";
            this.lblNationName.Size = new System.Drawing.Size(157, 32);
            this.lblNationName.TabIndex = 0;
            this.lblNationName.Text = "Nation Name";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(286, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 43);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(423, 286);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 43);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // comboBoxNationName
            // 
            this.comboBoxNationName.FormattingEnabled = true;
            this.comboBoxNationName.Items.AddRange(new object[] {
            "Bangladeshi Farmer",
            "Arab Bedouin",
            "Egyptian King",
            "Inuit Hunter"});
            this.comboBoxNationName.Location = new System.Drawing.Point(286, 101);
            this.comboBoxNationName.Name = "comboBoxNationName";
            this.comboBoxNationName.Size = new System.Drawing.Size(316, 28);
            this.comboBoxNationName.TabIndex = 3;
            // 
            // NewVillageCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxNationName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNationName);
            this.Controls.Add(this.txtboxVillageName);
            this.Controls.Add(this.lblVillageName);
            this.Name = "NewVillageCreateForm";
            this.Text = "NewVillageCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVillageName;
        private System.Windows.Forms.TextBox txtboxVillageName;
        private System.Windows.Forms.Label lblNationName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox comboBoxNationName;
    }
}