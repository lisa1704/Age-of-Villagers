namespace AgeOfVillagers
{
    partial class Villagewindow
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
            this.drawingpanel = new System.Windows.Forms.Panel();
            this.toolpanel = new System.Windows.Forms.Panel();
            this.lblnation = new System.Windows.Forms.Label();
            this.lblvillage = new System.Windows.Forms.Label();
            this.lblgamename = new System.Windows.Forms.Label();
            this.rbtntree = new System.Windows.Forms.RadioButton();
            this.rbtnwatersource = new System.Windows.Forms.RadioButton();
            this.rbtnhouse = new System.Windows.Forms.RadioButton();
            this.btnsavevillage = new System.Windows.Forms.Button();
            this.btnopenvillage = new System.Windows.Forms.Button();
            this.btnnewvillage = new System.Windows.Forms.Button();
            this.toolpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingpanel
            // 
            this.drawingpanel.BackColor = System.Drawing.SystemColors.Control;
            this.drawingpanel.Location = new System.Drawing.Point(0, 0);
            this.drawingpanel.Name = "drawingpanel";
            this.drawingpanel.Size = new System.Drawing.Size(600, 400);
            this.drawingpanel.TabIndex = 0;
            // 
            // toolpanel
            // 
            this.toolpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolpanel.Controls.Add(this.lblnation);
            this.toolpanel.Controls.Add(this.lblvillage);
            this.toolpanel.Controls.Add(this.lblgamename);
            this.toolpanel.Controls.Add(this.rbtntree);
            this.toolpanel.Controls.Add(this.rbtnwatersource);
            this.toolpanel.Controls.Add(this.rbtnhouse);
            this.toolpanel.Controls.Add(this.btnsavevillage);
            this.toolpanel.Controls.Add(this.btnopenvillage);
            this.toolpanel.Controls.Add(this.btnnewvillage);
            this.toolpanel.Location = new System.Drawing.Point(600, 0);
            this.toolpanel.Name = "toolpanel";
            this.toolpanel.Size = new System.Drawing.Size(200, 400);
            this.toolpanel.TabIndex = 1;
            // 
            // lblnation
            // 
            this.lblnation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnation.AutoSize = true;
            this.lblnation.Location = new System.Drawing.Point(35, 106);
            this.lblnation.Name = "lblnation";
            this.lblnation.Size = new System.Drawing.Size(57, 21);
            this.lblnation.TabIndex = 5;
            this.lblnation.Text = "Nation";
            // 
            // lblvillage
            // 
            this.lblvillage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblvillage.AutoSize = true;
            this.lblvillage.Location = new System.Drawing.Point(35, 69);
            this.lblvillage.Name = "lblvillage";
            this.lblvillage.Size = new System.Drawing.Size(103, 21);
            this.lblvillage.TabIndex = 4;
            this.lblvillage.Text = "Village Name";
            // 
            // lblgamename
            // 
            this.lblgamename.AutoSize = true;
            this.lblgamename.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblgamename.Location = new System.Drawing.Point(6, 9);
            this.lblgamename.Name = "lblgamename";
            this.lblgamename.Size = new System.Drawing.Size(188, 27);
            this.lblgamename.TabIndex = 3;
            this.lblgamename.Text = "Age of Villagers";
            this.lblgamename.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbtntree
            // 
            this.rbtntree.AutoSize = true;
            this.rbtntree.Location = new System.Drawing.Point(35, 162);
            this.rbtntree.Name = "rbtntree";
            this.rbtntree.Size = new System.Drawing.Size(60, 25);
            this.rbtntree.TabIndex = 0;
            this.rbtntree.TabStop = true;
            this.rbtntree.Text = "Tree";
            this.rbtntree.UseVisualStyleBackColor = true;
            // 
            // rbtnwatersource
            // 
            this.rbtnwatersource.AutoSize = true;
            this.rbtnwatersource.Location = new System.Drawing.Point(35, 224);
            this.rbtnwatersource.Name = "rbtnwatersource";
            this.rbtnwatersource.Size = new System.Drawing.Size(124, 25);
            this.rbtnwatersource.TabIndex = 2;
            this.rbtnwatersource.TabStop = true;
            this.rbtnwatersource.Text = "Water Source";
            this.rbtnwatersource.UseVisualStyleBackColor = true;
            // 
            // rbtnhouse
            // 
            this.rbtnhouse.AutoSize = true;
            this.rbtnhouse.Location = new System.Drawing.Point(35, 193);
            this.rbtnhouse.Name = "rbtnhouse";
            this.rbtnhouse.Size = new System.Drawing.Size(75, 25);
            this.rbtnhouse.TabIndex = 1;
            this.rbtnhouse.TabStop = true;
            this.rbtnhouse.Text = "House";
            this.rbtnhouse.UseVisualStyleBackColor = true;
            // 
            // btnsavevillage
            // 
            this.btnsavevillage.Location = new System.Drawing.Point(35, 350);
            this.btnsavevillage.Name = "btnsavevillage";
            this.btnsavevillage.Size = new System.Drawing.Size(124, 29);
            this.btnsavevillage.TabIndex = 0;
            this.btnsavevillage.Text = "Save Village";
            this.btnsavevillage.UseVisualStyleBackColor = true;
            // 
            // btnopenvillage
            // 
            this.btnopenvillage.Location = new System.Drawing.Point(35, 315);
            this.btnopenvillage.Name = "btnopenvillage";
            this.btnopenvillage.Size = new System.Drawing.Size(124, 29);
            this.btnopenvillage.TabIndex = 0;
            this.btnopenvillage.Text = "Open Village";
            this.btnopenvillage.UseVisualStyleBackColor = true;
            // 
            // btnnewvillage
            // 
            this.btnnewvillage.Location = new System.Drawing.Point(35, 280);
            this.btnnewvillage.Name = "btnnewvillage";
            this.btnnewvillage.Size = new System.Drawing.Size(124, 29);
            this.btnnewvillage.TabIndex = 0;
            this.btnnewvillage.Text = "New Village";
            this.btnnewvillage.UseVisualStyleBackColor = true;
            this.btnnewvillage.Click += new System.EventHandler(this.btnnewvillage_Click);
            // 
            // Villagewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.toolpanel);
            this.Controls.Add(this.drawingpanel);
            this.Name = "Villagewindow";
            this.Text = "Age of Villagers";
            this.Load += new System.EventHandler(this.Villagewindow_Load);
            this.toolpanel.ResumeLayout(false);
            this.toolpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingpanel;
        private System.Windows.Forms.Panel toolpanel;
        private System.Windows.Forms.RadioButton rbtntree;
        private System.Windows.Forms.Button btnsavevillage;
        private System.Windows.Forms.Button btnopenvillage;
        private System.Windows.Forms.Button btnnewvillage;
        private System.Windows.Forms.RadioButton rbtnwatersource;
        private System.Windows.Forms.RadioButton rbtnhouse;
        private System.Windows.Forms.Label lblgamename;
        public System.Windows.Forms.Label lblnation;
        public System.Windows.Forms.Label lblvillage;
    }

}

