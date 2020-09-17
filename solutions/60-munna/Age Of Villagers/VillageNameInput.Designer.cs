namespace Age_Of_Villagers
{
    partial class VillageNameInput
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
            this.asking_for_village_name = new System.Windows.Forms.Label();
            this.VillageName_Input = new System.Windows.Forms.TextBox();
            this.NewVillage_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asking_for_village_name
            // 
            this.asking_for_village_name.AutoSize = true;
            this.asking_for_village_name.BackColor = System.Drawing.SystemColors.Info;
            this.asking_for_village_name.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.asking_for_village_name.Location = new System.Drawing.Point(12, 28);
            this.asking_for_village_name.Name = "asking_for_village_name";
            this.asking_for_village_name.Size = new System.Drawing.Size(411, 30);
            this.asking_for_village_name.TabIndex = 1;
            this.asking_for_village_name.Text = "Please provide the name of the village:";
            // 
            // VillageName_Input
            // 
            this.VillageName_Input.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VillageName_Input.Location = new System.Drawing.Point(46, 92);
            this.VillageName_Input.Name = "VillageName_Input";
            this.VillageName_Input.Size = new System.Drawing.Size(324, 25);
            this.VillageName_Input.TabIndex = 2;
            // 
            // NewVillage_Button
            // 
            this.NewVillage_Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NewVillage_Button.Location = new System.Drawing.Point(147, 143);
            this.NewVillage_Button.Name = "NewVillage_Button";
            this.NewVillage_Button.Size = new System.Drawing.Size(118, 42);
            this.NewVillage_Button.TabIndex = 3;
            this.NewVillage_Button.Text = "Enter";
            this.NewVillage_Button.UseVisualStyleBackColor = false;
            // 
            // VillageNameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(437, 207);
            this.Controls.Add(this.NewVillage_Button);
            this.Controls.Add(this.VillageName_Input);
            this.Controls.Add(this.asking_for_village_name);
            this.Name = "VillageNameInput";
            this.Text = "VillageNameInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asking_for_village_name;
        private System.Windows.Forms.TextBox VillageName_Input;
        private System.Windows.Forms.Button NewVillage_Button;
    }
}