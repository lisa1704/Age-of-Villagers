﻿namespace Age_of_Villagers
{
    partial class CreateNewVillageForm
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
            this.village_name = new System.Windows.Forms.Label();
            this.nation_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // village_name
            // 
            this.village_name.AutoSize = true;
            this.village_name.Location = new System.Drawing.Point(77, 77);
            this.village_name.Name = "village_name";
            this.village_name.Size = new System.Drawing.Size(116, 25);
            this.village_name.TabIndex = 0;
            this.village_name.Text = "Village Name";
            // 
            // GetNationName
            // 
            this.nation_name.AutoSize = true;
            this.nation_name.Location = new System.Drawing.Point(77, 201);
            this.nation_name.Name = "GetNationName";
            this.nation_name.Size = new System.Drawing.Size(116, 25);
            this.nation_name.TabIndex = 1;
            this.nation_name.Text = "Nation_name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 2;
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(313, 319);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(112, 34);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // CreateNewVillageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nation_name);
            this.Controls.Add(this.village_name);
            this.Name = "CreateNewVillageForm";
            this.Text = "CreateNewVillageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label village_name;
        private System.Windows.Forms.Label nation_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button submit;
    }
}