﻿namespace Age_of_villagers
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
            this.Save_village = new System.Windows.Forms.Button();
            this.New_village = new System.Windows.Forms.Button();
            this.Open_village = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Save_village
            // 
            this.Save_village.Location = new System.Drawing.Point(663, 275);
            this.Save_village.Name = "Save_village";
            this.Save_village.Size = new System.Drawing.Size(75, 23);
            this.Save_village.TabIndex = 0;
            this.Save_village.Text = "Save Village";
            this.Save_village.UseVisualStyleBackColor = true;
            this.Save_village.Click += new System.EventHandler(this.Save_village_Click);
            // 
            // New_village
            // 
            this.New_village.Location = new System.Drawing.Point(628, 304);
            this.New_village.Name = "New_village";
            this.New_village.Size = new System.Drawing.Size(75, 23);
            this.New_village.TabIndex = 1;
            this.New_village.Text = "New Village";
            this.New_village.UseVisualStyleBackColor = true;
            this.New_village.Click += new System.EventHandler(this.New_village_Click);
            // 
            // Open_village
            // 
            this.Open_village.Location = new System.Drawing.Point(709, 304);
            this.Open_village.Name = "Open_village";
            this.Open_village.Size = new System.Drawing.Size(75, 23);
            this.Open_village.TabIndex = 2;
            this.Open_village.Text = "Open Village";
            this.Open_village.UseVisualStyleBackColor = true;
            this.Open_village.Click += new System.EventHandler(this.Open_village_Click);
            // 
            // Tree
            // 
            this.Tree.AutoSize = true;
            this.Tree.Location = new System.Drawing.Point(628, 103);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(47, 17);
            this.Tree.TabIndex = 3;
            this.Tree.TabStop = true;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.CheckedChanged += new System.EventHandler(this.Tree_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Open_village);
            this.Controls.Add(this.New_village);
            this.Controls.Add(this.Save_village);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_village;
        private System.Windows.Forms.Button New_village;
        private System.Windows.Forms.Button Open_village;
        private System.Windows.Forms.RadioButton Tree;
    }
}

