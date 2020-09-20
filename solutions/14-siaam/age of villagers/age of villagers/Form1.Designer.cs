namespace age_of_villagers
{
    partial class aov_editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.new_vill = new System.Windows.Forms.Button();
            this.open_vill = new System.Windows.Forms.Button();
            this.save_vill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nation = new System.Windows.Forms.ComboBox();
            this.vill_name = new System.Windows.Forms.TextBox();
            this.housebutton = new System.Windows.Forms.Button();
            this.waterbutton = new System.Windows.Forms.Button();
            this.treebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(708, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age Of Villagers";
            // 
            // new_vill
            // 
            this.new_vill.Location = new System.Drawing.Point(688, 395);
            this.new_vill.Name = "new_vill";
            this.new_vill.Size = new System.Drawing.Size(104, 43);
            this.new_vill.TabIndex = 1;
            this.new_vill.Text = "New Village";
            this.new_vill.UseVisualStyleBackColor = true;
            this.new_vill.Click += new System.EventHandler(this.button1_Click);
            // 
            // open_vill
            // 
            this.open_vill.Location = new System.Drawing.Point(798, 395);
            this.open_vill.Name = "open_vill";
            this.open_vill.Size = new System.Drawing.Size(104, 43);
            this.open_vill.TabIndex = 2;
            this.open_vill.Text = "Open Village";
            this.open_vill.UseVisualStyleBackColor = true;
            // 
            // save_vill
            // 
            this.save_vill.Location = new System.Drawing.Point(744, 346);
            this.save_vill.Name = "save_vill";
            this.save_vill.Size = new System.Drawing.Size(104, 43);
            this.save_vill.TabIndex = 3;
            this.save_vill.Text = "Save Village";
            this.save_vill.UseVisualStyleBackColor = true;
            this.save_vill.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(37, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nation
            // 
            this.nation.AllowDrop = true;
            this.nation.FormattingEnabled = true;
            this.nation.Location = new System.Drawing.Point(713, 143);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(165, 24);
            this.nation.TabIndex = 5;
            this.nation.Text = "Select Nation";
            this.nation.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            //"Arab Beduin",
            //"Egyptian king",
            //"Inuit Hunter"
            });
            this.nation.SelectedIndexChanged += new System.EventHandler(this.nation_SelectedIndexChanged);
            // 
            // vill_name
            // 
            this.vill_name.Location = new System.Drawing.Point(713, 95);
            this.vill_name.Name = "vill_name";
            this.vill_name.Size = new System.Drawing.Size(165, 22);
            this.vill_name.TabIndex = 6;
            this.vill_name.Text = "Enter Village Name";
            this.vill_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // housebutton
            // 
            this.housebutton.Location = new System.Drawing.Point(798, 228);
            this.housebutton.Name = "housebutton";
            this.housebutton.Size = new System.Drawing.Size(104, 29);
            this.housebutton.TabIndex = 8;
            this.housebutton.Text = "House";
            this.housebutton.UseVisualStyleBackColor = true;
            // 
            // waterbutton
            // 
            this.waterbutton.Location = new System.Drawing.Point(744, 263);
            this.waterbutton.Name = "waterbutton";
            this.waterbutton.Size = new System.Drawing.Size(104, 29);
            this.waterbutton.TabIndex = 9;
            this.waterbutton.Text = "Water Source";
            this.waterbutton.UseVisualStyleBackColor = true;
            // 
            // treebutton
            // 
            this.treebutton.Location = new System.Drawing.Point(688, 228);
            this.treebutton.Name = "treebutton";
            this.treebutton.Size = new System.Drawing.Size(104, 29);
            this.treebutton.TabIndex = 7;
            this.treebutton.Text = "Tree";
            this.treebutton.UseVisualStyleBackColor = true;
            this.treebutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // aov_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 485);
            this.Controls.Add(this.waterbutton);
            this.Controls.Add(this.housebutton);
            this.Controls.Add(this.treebutton);
            this.Controls.Add(this.vill_name);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.save_vill);
            this.Controls.Add(this.open_vill);
            this.Controls.Add(this.new_vill);
            this.Controls.Add(this.label1);
            this.Name = "aov_editor";
            this.Text = "Age of Villagers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button new_vill;
        private System.Windows.Forms.Button open_vill;
        private System.Windows.Forms.Button save_vill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox nation;
        private System.Windows.Forms.TextBox vill_name;
        private System.Windows.Forms.Button housebutton;
        private System.Windows.Forms.Button waterbutton;
        private System.Windows.Forms.Button treebutton;
    }
}

