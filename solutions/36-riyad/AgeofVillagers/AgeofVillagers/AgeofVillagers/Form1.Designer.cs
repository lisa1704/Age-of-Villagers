namespace AgeofVillagers
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
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tree_btn = new System.Windows.Forms.Button();
            this.villageName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waterSource_btn = new System.Windows.Forms.Button();
            this.nation = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.house_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tree_btn);
            this.panel2.Controls.Add(this.villageName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.waterSource_btn);
            this.panel2.Controls.Add(this.nation);
            this.panel2.Controls.Add(this.save_btn);
            this.panel2.Controls.Add(this.house_btn);
            this.panel2.Controls.Add(this.new_btn);
            this.panel2.Controls.Add(this.open_btn);
            this.panel2.Location = new System.Drawing.Point(600, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 400);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tree_btn
            // 
            this.tree_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tree_btn.Location = new System.Drawing.Point(5, 181);
            this.tree_btn.Name = "tree_btn";
            this.tree_btn.Size = new System.Drawing.Size(99, 25);
            this.tree_btn.TabIndex = 0;
            this.tree_btn.Text = "Tree";
            this.tree_btn.UseVisualStyleBackColor = true;
            this.tree_btn.Click += new System.EventHandler(this.tree_btn_Click);
            // 
            // villageName
            // 
            this.villageName.AutoSize = true;
            this.villageName.Location = new System.Drawing.Point(82, 82);
            this.villageName.Name = "villageName";
            this.villageName.Size = new System.Drawing.Size(70, 20);
            this.villageName.TabIndex = 2;
            this.villageName.Text = "Katakhali";
            this.villageName.Click += new System.EventHandler(this.villageName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age of Villagers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // waterSource_btn
            // 
            this.waterSource_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waterSource_btn.Location = new System.Drawing.Point(50, 217);
            this.waterSource_btn.Name = "waterSource_btn";
            this.waterSource_btn.Size = new System.Drawing.Size(125, 25);
            this.waterSource_btn.TabIndex = 0;
            this.waterSource_btn.Text = "Water Source";
            this.waterSource_btn.UseVisualStyleBackColor = true;
            this.waterSource_btn.Click += new System.EventHandler(this.waterSource_btn_Click);
            // 
            // nation
            // 
            this.nation.AutoSize = true;
            this.nation.Location = new System.Drawing.Point(37, 115);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(145, 20);
            this.nation.TabIndex = 2;
            this.nation.Text = "Bangladeshi Farmers";
            this.nation.Click += new System.EventHandler(this.nation_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save_btn.Location = new System.Drawing.Point(50, 303);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(125, 25);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save Village";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // house_btn
            // 
            this.house_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.house_btn.Location = new System.Drawing.Point(114, 181);
            this.house_btn.Name = "house_btn";
            this.house_btn.Size = new System.Drawing.Size(101, 25);
            this.house_btn.TabIndex = 0;
            this.house_btn.Text = "House";
            this.house_btn.UseVisualStyleBackColor = true;
            this.house_btn.Click += new System.EventHandler(this.house_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.new_btn.Location = new System.Drawing.Point(5, 341);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(99, 25);
            this.new_btn.TabIndex = 0;
            this.new_btn.Text = "New Village";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.open_btn.Location = new System.Drawing.Point(114, 341);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(101, 25);
            this.open_btn.TabIndex = 0;
            this.open_btn.Text = "Open Village";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(822, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DrawPanel);
            this.Name = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tree_btn;
        private System.Windows.Forms.Label villageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button waterSource_btn;
        private System.Windows.Forms.Label nation;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button house_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button open_btn;
    }
}