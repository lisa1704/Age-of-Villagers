namespace Age_Of_Villagers
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
            this.VillageNameEditor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NationSelector = new System.Windows.Forms.DomainUpDown();
            this.Label_AOV = new System.Windows.Forms.Label();
            this.DrawingSpace = new System.Windows.Forms.Panel();
            this.buttonTree = new System.Windows.Forms.Button();
            this.buttonHouse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VillageNameEditor
            // 
            this.VillageNameEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VillageNameEditor.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VillageNameEditor.Location = new System.Drawing.Point(66, 70);
            this.VillageNameEditor.Name = "VillageNameEditor";
            this.VillageNameEditor.Size = new System.Drawing.Size(194, 29);
            this.VillageNameEditor.TabIndex = 3;
            this.VillageNameEditor.Text = " Village Name";
            this.VillageNameEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonHouse);
            this.panel1.Controls.Add(this.buttonTree);
            this.panel1.Controls.Add(this.NationSelector);
            this.panel1.Controls.Add(this.Label_AOV);
            this.panel1.Controls.Add(this.VillageNameEditor);
            this.panel1.Location = new System.Drawing.Point(629, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 507);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NationSelector
            // 
            this.NationSelector.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationSelector.Items.Add("Bangladeshi Farmers");
            this.NationSelector.Items.Add("Arab Bedouin");
            this.NationSelector.Items.Add("Egyptian Kings");
            this.NationSelector.Items.Add("Inuit Hunters");
            this.NationSelector.Location = new System.Drawing.Point(66, 123);
            this.NationSelector.Name = "NationSelector";
            this.NationSelector.Size = new System.Drawing.Size(198, 29);
            this.NationSelector.TabIndex = 6;
            this.NationSelector.Text = "Nation";
            this.NationSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_AOV
            // 
            this.Label_AOV.AutoSize = true;
            this.Label_AOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AOV.Location = new System.Drawing.Point(61, 17);
            this.Label_AOV.Name = "Label_AOV";
            this.Label_AOV.Size = new System.Drawing.Size(203, 29);
            this.Label_AOV.TabIndex = 4;
            this.Label_AOV.Text = "Age Of Villagers";
            // 
            // DrawingSpace
            // 
            this.DrawingSpace.Location = new System.Drawing.Point(11, 91);
            this.DrawingSpace.MaximumSize = new System.Drawing.Size(600, 400);
            this.DrawingSpace.MinimumSize = new System.Drawing.Size(600, 400);
            this.DrawingSpace.Name = "DrawingSpace";
            this.DrawingSpace.Size = new System.Drawing.Size(600, 400);
            this.DrawingSpace.TabIndex = 7;
            // 
            // buttonTree
            // 
            this.buttonTree.AutoSize = true;
            this.buttonTree.BackColor = System.Drawing.Color.Silver;
            this.buttonTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTree.Location = new System.Drawing.Point(66, 196);
            this.buttonTree.Name = "buttonTree";
            this.buttonTree.Size = new System.Drawing.Size(92, 39);
            this.buttonTree.TabIndex = 7;
            this.buttonTree.Text = "Tree";
            this.buttonTree.UseVisualStyleBackColor = false;
            // 
            // buttonHouse
            // 
            this.buttonHouse.AutoSize = true;
            this.buttonHouse.BackColor = System.Drawing.Color.Silver;
            this.buttonHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHouse.Location = new System.Drawing.Point(172, 196);
            this.buttonHouse.Name = "buttonHouse";
            this.buttonHouse.Size = new System.Drawing.Size(92, 39);
            this.buttonHouse.TabIndex = 8;
            this.buttonHouse.Text = "House";
            this.buttonHouse.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(101, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Water Source";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AgeOfVillagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 524);
            this.Controls.Add(this.DrawingSpace);
            this.Controls.Add(this.panel1);
            this.Name = "AgeOfVillagers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox VillageNameEditor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DomainUpDown NationSelector;
        private System.Windows.Forms.Label Label_AOV;
        private System.Windows.Forms.Panel DrawingSpace;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonHouse;
        private System.Windows.Forms.Button buttonTree;
    }
}

