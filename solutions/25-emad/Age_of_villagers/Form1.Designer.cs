namespace Age_of_villagers
{
    partial class Form1
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
            this.panel = new System.Windows.Forms.Panel();
            this.Age_of_Villagers = new System.Windows.Forms.Label();
            this.village_name = new System.Windows.Forms.Label();
            this.nations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(600, 400);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Age_of_Villagers
            // 
            this.Age_of_Villagers.AutoSize = true;
            this.Age_of_Villagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_of_Villagers.Location = new System.Drawing.Point(709, 31);
            this.Age_of_Villagers.Name = "Age_of_Villagers";
            this.Age_of_Villagers.Size = new System.Drawing.Size(165, 25);
            this.Age_of_Villagers.TabIndex = 1;
            this.Age_of_Villagers.Text = "Age of Villagers";
            this.Age_of_Villagers.Click += new System.EventHandler(this.Label1_Click);
            // 
            // village_name
            // 
            this.village_name.AutoSize = true;
            this.village_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.village_name.Location = new System.Drawing.Point(737, 90);
            this.village_name.Name = "village_name";
            this.village_name.Size = new System.Drawing.Size(91, 18);
            this.village_name.TabIndex = 2;
            this.village_name.Text = "Village name";
            this.village_name.Click += new System.EventHandler(this.Village_name_Click);
            // 
            // nations
            // 
            this.nations.AutoSize = true;
            this.nations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nations.Location = new System.Drawing.Point(753, 131);
            this.nations.Name = "nations";
            this.nations.Size = new System.Drawing.Size(59, 18);
            this.nations.TabIndex = 3;
            this.nations.Text = "Nations";
            this.nations.Click += new System.EventHandler(this.Nations_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(949, 441);
            this.Controls.Add(this.nations);
            this.Controls.Add(this.village_name);
            this.Controls.Add(this.Age_of_Villagers);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gamename;
        private System.Windows.Forms.RadioButton radioButtontree;
        private System.Windows.Forms.RadioButton radiobuttonhouse;
        private System.Windows.Forms.RadioButton radioButtonWaterSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAgeofvillagers;
        private System.Windows.Forms.Label labelVillagename;
        private System.Windows.Forms.Label labelNation;
        private System.Windows.Forms.RadioButton radioButtTree;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label Age_of_Villagers;
        private System.Windows.Forms.Label village_name;
        private System.Windows.Forms.Label nations;
    }
}

