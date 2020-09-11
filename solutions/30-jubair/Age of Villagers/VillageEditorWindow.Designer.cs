namespace Age_of_Villagers
{
    partial class VillageEditorWindow
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
            this.drawing_space = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label_village_name = new System.Windows.Forms.Label();
            this.label_nation_name = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_tree = new System.Windows.Forms.Button();
            this.button_house = new System.Windows.Forms.Button();
            this.button_water = new System.Windows.Forms.Button();
            this.drawing_space.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawing_space
            // 
            this.drawing_space.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawing_space.Controls.Add(this.panel2);
            this.drawing_space.Location = new System.Drawing.Point(3, 14);
            this.drawing_space.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawing_space.Name = "drawing_space";
            this.drawing_space.Size = new System.Drawing.Size(600, 400);
            this.drawing_space.TabIndex = 0;
            this.drawing_space.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_space_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(856, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 612);
            this.panel2.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(675, 23);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(195, 35);
            this.label.TabIndex = 1;
            this.label.Text = "Age of Villagers";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_village_name
            // 
            this.label_village_name.AutoSize = true;
            this.label_village_name.Location = new System.Drawing.Point(727, 72);
            this.label_village_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_village_name.Name = "label_village_name";
            this.label_village_name.Size = new System.Drawing.Size(83, 25);
            this.label_village_name.TabIndex = 1;
            this.label_village_name.Text = "KataKhali";
            this.label_village_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_village_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_nation_name
            // 
            this.label_nation_name.AutoSize = true;
            this.label_nation_name.Location = new System.Drawing.Point(685, 110);
            this.label_nation_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nation_name.Name = "label_nation_name";
            this.label_nation_name.Size = new System.Drawing.Size(166, 25);
            this.label_nation_name.TabIndex = 1;
            this.label_nation_name.Text = "Bangladeshi Farmer";
            this.label_nation_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_nation_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_save.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_save.Location = new System.Drawing.Point(701, 316);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(136, 38);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Save Village";
            this.button_save.UseVisualStyleBackColor = false;
            // 
            // button_open
            // 
            this.button_open.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_open.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_open.Location = new System.Drawing.Point(623, 364);
            this.button_open.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(136, 38);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "Open Village";
            this.button_open.UseVisualStyleBackColor = false;
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_new.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_new.Location = new System.Drawing.Point(767, 364);
            this.button_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(136, 38);
            this.button_new.TabIndex = 3;
            this.button_new.Text = "New Village";
            this.button_new.UseVisualStyleBackColor = false;
            // 
            // button_tree
            // 
            this.button_tree.Location = new System.Drawing.Point(659, 169);
            this.button_tree.Name = "button_tree";
            this.button_tree.Size = new System.Drawing.Size(112, 34);
            this.button_tree.TabIndex = 1;
            this.button_tree.Text = "Tree";
            this.button_tree.UseVisualStyleBackColor = true;
            this.button_tree.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_house
            // 
            this.button_house.Location = new System.Drawing.Point(777, 169);
            this.button_house.Name = "button_house";
            this.button_house.Size = new System.Drawing.Size(112, 34);
            this.button_house.TabIndex = 2;
            this.button_house.Text = "House";
            this.button_house.UseVisualStyleBackColor = true;
            this.button_house.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_water
            // 
            this.button_water.Location = new System.Drawing.Point(708, 209);
            this.button_water.Name = "button_water";
            this.button_water.Size = new System.Drawing.Size(129, 40);
            this.button_water.TabIndex = 3;
            this.button_water.Text = "Water Source";
            this.button_water.UseVisualStyleBackColor = true;
            // 
            // VillageEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 434);
            this.Controls.Add(this.button_water);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_house);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_tree);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_nation_name);
            this.Controls.Add(this.label_village_name);
            this.Controls.Add(this.label);
            this.Controls.Add(this.drawing_space);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VillageEditorWindow";
            this.Text = "Village Window";
            this.drawing_space.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawing_space;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_village_name;
        private System.Windows.Forms.Label label_nation_name;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_tree;
        private System.Windows.Forms.Button button_house;
        private System.Windows.Forms.Button button_water;
    }
}

