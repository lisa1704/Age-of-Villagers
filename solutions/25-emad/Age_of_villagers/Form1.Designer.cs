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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAgeofvillagers = new System.Windows.Forms.Label();
            this.labelVillagename = new System.Windows.Forms.Label();
            this.labelNation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 400);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // labelAgeofvillagers
            // 
            this.labelAgeofvillagers.AutoSize = true;
            this.labelAgeofvillagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeofvillagers.Location = new System.Drawing.Point(680, 38);
            this.labelAgeofvillagers.Name = "labelAgeofvillagers";
            this.labelAgeofvillagers.Size = new System.Drawing.Size(165, 25);
            this.labelAgeofvillagers.TabIndex = 1;
            this.labelAgeofvillagers.Text = "Age of Villagers";
            this.labelAgeofvillagers.Click += new System.EventHandler(this.LabelAgeofvillagers_Click);
            // 
            // labelVillagename
            // 
            this.labelVillagename.AutoSize = true;
            this.labelVillagename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVillagename.Location = new System.Drawing.Point(715, 90);
            this.labelVillagename.Name = "labelVillagename";
            this.labelVillagename.Size = new System.Drawing.Size(90, 18);
            this.labelVillagename.TabIndex = 2;
            this.labelVillagename.Text = "VillageName";
            this.labelVillagename.Click += new System.EventHandler(this.LabelVillagename_Click);
            // 
            // labelNation
            // 
            this.labelNation.AutoSize = true;
            this.labelNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNation.Location = new System.Drawing.Point(735, 134);
            this.labelNation.Name = "labelNation";
            this.labelNation.Size = new System.Drawing.Size(51, 18);
            this.labelNation.TabIndex = 3;
            this.labelNation.Text = "Nation";
            this.labelNation.Click += new System.EventHandler(this.LabelNation_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(913, 479);
            this.Controls.Add(this.labelNation);
            this.Controls.Add(this.labelVillagename);
            this.Controls.Add(this.labelAgeofvillagers);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
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
    }
}

