namespace AgeOfVillagers
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
            this.SaveVillage = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tree = new System.Windows.Forms.RadioButton();
            this.House = new System.Windows.Forms.RadioButton();
            this.Water = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.canvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SaveVillage
            // 
            this.SaveVillage.Location = new System.Drawing.Point(760, 349);
            this.SaveVillage.Name = "SaveVillage";
            this.SaveVillage.Size = new System.Drawing.Size(129, 33);
            this.SaveVillage.TabIndex = 3;
            this.SaveVillage.Text = "Save Village";
            this.SaveVillage.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(715, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "New Village";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(834, 399);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Open Village";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Age of Villagers";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(715, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Enter Village Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(715, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Enter nation ";
            // 
            // tree
            // 
            this.tree.AutoSize = true;
            this.tree.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tree.Location = new System.Drawing.Point(743, 224);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(59, 21);
            this.tree.TabIndex = 11;
            this.tree.TabStop = true;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = false;
            // 
            // House
            // 
            this.House.AutoSize = true;
            this.House.BackColor = System.Drawing.Color.DimGray;
            this.House.Location = new System.Drawing.Point(834, 224);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(70, 21);
            this.House.TabIndex = 12;
            this.House.TabStop = true;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = false;
            // 
            // Water
            // 
            this.Water.AutoSize = true;
            this.Water.BackColor = System.Drawing.Color.DodgerBlue;
            this.Water.Location = new System.Drawing.Point(779, 278);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(116, 21);
            this.Water.TabIndex = 13;
            this.Water.TabStop = true;
            this.Water.Text = "Water Source";
            this.Water.UseVisualStyleBackColor = false;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.GhostWhite;
            this.canvas.Location = new System.Drawing.Point(24, 33);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(600, 400);
            this.canvas.TabIndex = 14;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(988, 488);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.Water);
            this.Controls.Add(this.House);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SaveVillage);
            this.Name = "Form1";
            this.Text = "Village Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveVillage;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton tree;
        private System.Windows.Forms.RadioButton House;
        private System.Windows.Forms.RadioButton Water;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel canvas;
    }
}

