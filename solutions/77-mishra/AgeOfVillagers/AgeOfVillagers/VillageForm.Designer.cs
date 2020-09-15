namespace AgeOfVillagers
{
    partial class VillageForm
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
            this.drawingBoard = new System.Windows.Forms.Panel();
            this.save_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.villageName = new System.Windows.Forms.Label();
            this.nations = new System.Windows.Forms.Label();
            this.tree_changed = new System.Windows.Forms.RadioButton();
            this.house_button = new System.Windows.Forms.RadioButton();
            this.water_button = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // drawingBoard
            // 
            this.drawingBoard.Location = new System.Drawing.Point(12, 12);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(600, 400);
            this.drawingBoard.TabIndex = 0;
            this.drawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBoard_Paint);
            this.drawingBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseClick);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.Info;
            this.save_button.Location = new System.Drawing.Point(670, 303);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(130, 29);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Save Village";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_Click);
            // 
            // new_button
            // 
            this.new_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.new_button.Location = new System.Drawing.Point(618, 349);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(110, 29);
            this.new_button.TabIndex = 2;
            this.new_button.Text = "New Village";
            this.new_button.UseVisualStyleBackColor = false;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // open_button
            // 
            this.open_button.BackColor = System.Drawing.Color.DarkKhaki;
            this.open_button.Location = new System.Drawing.Point(734, 349);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(111, 29);
            this.open_button.TabIndex = 3;
            this.open_button.Text = "Open Village";
            this.open_button.UseVisualStyleBackColor = false;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.header.Location = new System.Drawing.Point(638, 20);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(208, 37);
            this.header.TabIndex = 7;
            this.header.Text = "Age Of Villagers";
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // villageName
            // 
            this.villageName.AutoSize = true;
            this.villageName.Location = new System.Drawing.Point(691, 72);
            this.villageName.Name = "villageName";
            this.villageName.Size = new System.Drawing.Size(99, 20);
            this.villageName.TabIndex = 8;
            this.villageName.Text = "Village Name";
            this.villageName.Click += new System.EventHandler(this.villageName_Click);
            // 
            // nations
            // 
            this.nations.AutoSize = true;
            this.nations.Location = new System.Drawing.Point(702, 108);
            this.nations.Name = "nations";
            this.nations.Size = new System.Drawing.Size(60, 20);
            this.nations.TabIndex = 9;
            this.nations.Text = "Nations";
            this.nations.Click += new System.EventHandler(this.nations_Click);
            // 
            // tree_changed
            // 
            this.tree_changed.AutoSize = true;
            this.tree_changed.BackColor = System.Drawing.Color.Green;
            this.tree_changed.ForeColor = System.Drawing.Color.White;
            this.tree_changed.Location = new System.Drawing.Point(638, 154);
            this.tree_changed.Name = "tree_changed";
            this.tree_changed.Size = new System.Drawing.Size(58, 24);
            this.tree_changed.TabIndex = 10;
            this.tree_changed.TabStop = true;
            this.tree_changed.Text = "Tree";
            this.tree_changed.UseVisualStyleBackColor = false;
            this.tree_changed.CheckedChanged += new System.EventHandler(this.tree_changed_CheckedChanged);
            // 
            // house_button
            // 
            this.house_button.AutoSize = true;
            this.house_button.BackColor = System.Drawing.Color.Chocolate;
            this.house_button.ForeColor = System.Drawing.Color.White;
            this.house_button.Location = new System.Drawing.Point(762, 154);
            this.house_button.Name = "house_button";
            this.house_button.Size = new System.Drawing.Size(72, 24);
            this.house_button.TabIndex = 11;
            this.house_button.TabStop = true;
            this.house_button.Text = "House";
            this.house_button.UseVisualStyleBackColor = false;
            this.house_button.CheckedChanged += new System.EventHandler(this.house_button_CheckedChanged);
            // 
            // water_button
            // 
            this.water_button.AutoSize = true;
            this.water_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.water_button.ForeColor = System.Drawing.Color.White;
            this.water_button.Location = new System.Drawing.Point(683, 193);
            this.water_button.Name = "water_button";
            this.water_button.Size = new System.Drawing.Size(118, 24);
            this.water_button.TabIndex = 12;
            this.water_button.TabStop = true;
            this.water_button.Text = "Water Source";
            this.water_button.UseVisualStyleBackColor = false;
            this.water_button.CheckedChanged += new System.EventHandler(this.water_button_CheckedChanged);
            // 
            // VillageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 508);
            this.Controls.Add(this.water_button);
            this.Controls.Add(this.house_button);
            this.Controls.Add(this.tree_changed);
            this.Controls.Add(this.nations);
            this.Controls.Add(this.villageName);
            this.Controls.Add(this.header);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.drawingBoard);
            this.Name = "VillageForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingBoard;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label villageName;
        private System.Windows.Forms.Label nations;
        private System.Windows.Forms.RadioButton tree_changed;
        private System.Windows.Forms.RadioButton house_button;
        private System.Windows.Forms.RadioButton water_button;
    }
}

