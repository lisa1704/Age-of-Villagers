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
            this.Save_village = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save_village
            // 
            this.Save_village.Location = new System.Drawing.Point(651, 117);
            this.Save_village.Name = "Save_village";
            this.Save_village.Size = new System.Drawing.Size(75, 23);
            this.Save_village.TabIndex = 0;
            this.Save_village.Text = "Save Village";
            this.Save_village.UseVisualStyleBackColor = true;
            this.Save_village.Click += new System.EventHandler(this.Save_village_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_village);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save_village;
    }
}

