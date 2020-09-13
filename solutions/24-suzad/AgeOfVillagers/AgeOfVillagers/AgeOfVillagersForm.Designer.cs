namespace AgeOfVillagers
{
    partial class AgeOfVillagersForm
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
            this.pnlDrawingSpace = new System.Windows.Forms.Panel();
            this.pnlToolSide = new System.Windows.Forms.Panel();
            this.lblAgeOfVillagers = new System.Windows.Forms.Label();
            this.lblVillageName = new System.Windows.Forms.Label();
            this.lblNationName = new System.Windows.Forms.Label();
            this.radiobtnTree = new System.Windows.Forms.RadioButton();
            this.radiobtnHouse = new System.Windows.Forms.RadioButton();
            this.radiobtnWaterSource = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewVillage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDrawingSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawingSpace
            // 
            this.pnlDrawingSpace.Controls.Add(this.pnlToolSide);
            this.pnlDrawingSpace.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawingSpace.Name = "pnlDrawingSpace";
            this.pnlDrawingSpace.Size = new System.Drawing.Size(600, 400);
            this.pnlDrawingSpace.TabIndex = 0;
            this.pnlDrawingSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawingSpace_Paint);
            this.pnlDrawingSpace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlDrawingSpace_MouseClick);
            // 
            // pnlToolSide
            // 
            this.pnlToolSide.Location = new System.Drawing.Point(601, 0);
            this.pnlToolSide.Name = "pnlToolSide";
            this.pnlToolSide.Size = new System.Drawing.Size(195, 400);
            this.pnlToolSide.TabIndex = 1;
            // 
            // lblAgeOfVillagers
            // 
            this.lblAgeOfVillagers.AutoSize = true;
            this.lblAgeOfVillagers.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgeOfVillagers.Location = new System.Drawing.Point(606, 9);
            this.lblAgeOfVillagers.Name = "lblAgeOfVillagers";
            this.lblAgeOfVillagers.Size = new System.Drawing.Size(185, 20);
            this.lblAgeOfVillagers.TabIndex = 1;
            this.lblAgeOfVillagers.Text = "Age of Villagers";
            // 
            // lblVillageName
            // 
            this.lblVillageName.AutoSize = true;
            this.lblVillageName.Location = new System.Drawing.Point(645, 45);
            this.lblVillageName.Name = "lblVillageName";
            this.lblVillageName.Size = new System.Drawing.Size(95, 20);
            this.lblVillageName.TabIndex = 2;
            this.lblVillageName.Text = "VillageName";
            // 
            // lblNationName
            // 
            this.lblNationName.AutoSize = true;
            this.lblNationName.Location = new System.Drawing.Point(645, 75);
            this.lblNationName.Name = "lblNationName";
            this.lblNationName.Size = new System.Drawing.Size(94, 20);
            this.lblNationName.TabIndex = 3;
            this.lblNationName.Text = "NationName";
            // 
            // radiobtnTree
            // 
            this.radiobtnTree.AutoSize = true;
            this.radiobtnTree.Location = new System.Drawing.Point(623, 138);
            this.radiobtnTree.Name = "radiobtnTree";
            this.radiobtnTree.Size = new System.Drawing.Size(58, 24);
            this.radiobtnTree.TabIndex = 4;
            this.radiobtnTree.TabStop = true;
            this.radiobtnTree.Text = "Tree";
            this.radiobtnTree.UseVisualStyleBackColor = true;
            // 
            // radiobtnHouse
            // 
            this.radiobtnHouse.AutoSize = true;
            this.radiobtnHouse.Location = new System.Drawing.Point(623, 168);
            this.radiobtnHouse.Name = "radiobtnHouse";
            this.radiobtnHouse.Size = new System.Drawing.Size(72, 24);
            this.radiobtnHouse.TabIndex = 5;
            this.radiobtnHouse.TabStop = true;
            this.radiobtnHouse.Text = "House";
            this.radiobtnHouse.UseVisualStyleBackColor = true;
            // 
            // radiobtnWaterSource
            // 
            this.radiobtnWaterSource.AutoSize = true;
            this.radiobtnWaterSource.Location = new System.Drawing.Point(623, 198);
            this.radiobtnWaterSource.Name = "radiobtnWaterSource";
            this.radiobtnWaterSource.Size = new System.Drawing.Size(116, 24);
            this.radiobtnWaterSource.TabIndex = 6;
            this.radiobtnWaterSource.TabStop = true;
            this.radiobtnWaterSource.Text = "Water source";
            this.radiobtnWaterSource.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(645, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewVillage
            // 
            this.btnNewVillage.Location = new System.Drawing.Point(645, 308);
            this.btnNewVillage.Name = "btnNewVillage";
            this.btnNewVillage.Size = new System.Drawing.Size(109, 29);
            this.btnNewVillage.TabIndex = 2;
            this.btnNewVillage.Text = "New village";
            this.btnNewVillage.UseVisualStyleBackColor = true;
            this.btnNewVillage.Click += new System.EventHandler(this.btnNewVillage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open village";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AgeOfVillagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewVillage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radiobtnWaterSource);
            this.Controls.Add(this.radiobtnHouse);
            this.Controls.Add(this.radiobtnTree);
            this.Controls.Add(this.lblNationName);
            this.Controls.Add(this.lblVillageName);
            this.Controls.Add(this.lblAgeOfVillagers);
            this.Controls.Add(this.pnlDrawingSpace);
            this.Name = "AgeOfVillagersForm";
            this.Text = "Age of Villagers";
            this.Load += new System.EventHandler(this.AgeOfVillagersForm_Load);
            this.pnlDrawingSpace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlDrawingSpace;
        public System.Windows.Forms.Panel pnlToolSide;
        public System.Windows.Forms.Label lblAgeOfVillagers;
        public System.Windows.Forms.Label lblVillageName;
        public System.Windows.Forms.Label lblNationName;
        public System.Windows.Forms.RadioButton radiobtnTree;
        public System.Windows.Forms.RadioButton radiobtnHouse;
        public System.Windows.Forms.RadioButton radiobtnWaterSource;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnNewVillage;
        public System.Windows.Forms.Button button1;
    }
}

