using System.Windows.Forms;

namespace Age_of_Villagers
{
    partial class CreateEditVIllage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenVillage = new System.Windows.Forms.Button();
            this.btnNewVillage = new System.Windows.Forms.Button();
            this.btnSaveVillage = new System.Windows.Forms.Button();
            this.rbtnWaterResource = new System.Windows.Forms.RadioButton();
            this.rbtnHouse = new System.Windows.Forms.RadioButton();
            this.rbtnTree = new System.Windows.Forms.RadioButton();
            this.textNation = new System.Windows.Forms.TextBox();
            this.textVillageName = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.drawingSpace = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btnOpenVillage);
            this.panel1.Controls.Add(this.btnNewVillage);
            this.panel1.Controls.Add(this.btnSaveVillage);
            this.panel1.Controls.Add(this.rbtnWaterResource);
            this.panel1.Controls.Add(this.rbtnHouse);
            this.panel1.Controls.Add(this.rbtnTree);
            this.panel1.Controls.Add(this.textNation);
            this.panel1.Controls.Add(this.textVillageName);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(595, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 401);
            this.panel1.TabIndex = 0;
            // 
            // btnOpenVillage
            // 
            this.btnOpenVillage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOpenVillage.FlatAppearance.BorderSize = 0;
            this.btnOpenVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenVillage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenVillage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenVillage.Location = new System.Drawing.Point(62, 349);
            this.btnOpenVillage.Name = "btnOpenVillage";
            this.btnOpenVillage.Size = new System.Drawing.Size(100, 25);
            this.btnOpenVillage.TabIndex = 8;
            this.btnOpenVillage.TabStop = false;
            this.btnOpenVillage.Text = "Open Village";
            this.btnOpenVillage.UseVisualStyleBackColor = false;
            this.btnOpenVillage.Click += new System.EventHandler(this.btnOpenVillage_Click);
            // 
            // btnNewVillage
            // 
            this.btnNewVillage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewVillage.FlatAppearance.BorderSize = 0;
            this.btnNewVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewVillage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewVillage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewVillage.Location = new System.Drawing.Point(62, 305);
            this.btnNewVillage.Name = "btnNewVillage";
            this.btnNewVillage.Size = new System.Drawing.Size(100, 25);
            this.btnNewVillage.TabIndex = 7;
            this.btnNewVillage.TabStop = false;
            this.btnNewVillage.Text = "New Village";
            this.btnNewVillage.UseVisualStyleBackColor = false;
            this.btnNewVillage.Click += new System.EventHandler(this.btnNewVillage_Click);
            // 
            // btnSaveVillage
            // 
            this.btnSaveVillage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveVillage.FlatAppearance.BorderSize = 0;
            this.btnSaveVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveVillage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVillage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveVillage.Location = new System.Drawing.Point(62, 265);
            this.btnSaveVillage.Name = "btnSaveVillage";
            this.btnSaveVillage.Size = new System.Drawing.Size(100, 25);
            this.btnSaveVillage.TabIndex = 6;
            this.btnSaveVillage.TabStop = false;
            this.btnSaveVillage.Text = "Save Village";
            this.btnSaveVillage.UseVisualStyleBackColor = false;
            this.btnSaveVillage.Click += new System.EventHandler(this.btnSaveVillage_Click);
            // 
            // rbtnWaterResource
            // 
            this.rbtnWaterResource.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWaterResource.Location = new System.Drawing.Point(52, 212);
            this.rbtnWaterResource.Name = "rbtnWaterResource";
            this.rbtnWaterResource.Size = new System.Drawing.Size(122, 20);
            this.rbtnWaterResource.TabIndex = 5;
            this.rbtnWaterResource.TabStop = true;
            this.rbtnWaterResource.Text = "Water Resource";
            this.rbtnWaterResource.UseVisualStyleBackColor = true;
            // 
            // rbtnHouse
            // 
            this.rbtnHouse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHouse.Location = new System.Drawing.Point(52, 189);
            this.rbtnHouse.Name = "rbtnHouse";
            this.rbtnHouse.Size = new System.Drawing.Size(122, 20);
            this.rbtnHouse.TabIndex = 4;
            this.rbtnHouse.TabStop = true;
            this.rbtnHouse.Text = "House";
            this.rbtnHouse.UseVisualStyleBackColor = true;
            // 
            // rbtnTree
            // 
            this.rbtnTree.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTree.Location = new System.Drawing.Point(52, 166);
            this.rbtnTree.Name = "rbtnTree";
            this.rbtnTree.Size = new System.Drawing.Size(122, 20);
            this.rbtnTree.TabIndex = 3;
            this.rbtnTree.TabStop = true;
            this.rbtnTree.Text = "Tree";
            this.rbtnTree.UseVisualStyleBackColor = true;
            // 
            // textNation
            // 
            this.textNation.BackColor = System.Drawing.Color.PowderBlue;
            this.textNation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNation.Location = new System.Drawing.Point(18, 108);
            this.textNation.Name = "textNation";
            this.textNation.Size = new System.Drawing.Size(186, 16);
            this.textNation.TabIndex = 2;
            this.textNation.Text = "Name of the Nation";
            this.textNation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNation.TextChanged += new System.EventHandler(this.textNation_TextChanged);
            // 
            // textVillageName
            // 
            this.textVillageName.BackColor = System.Drawing.Color.PowderBlue;
            this.textVillageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textVillageName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVillageName.Location = new System.Drawing.Point(18, 86);
            this.textVillageName.Name = "textVillageName";
            this.textVillageName.Size = new System.Drawing.Size(186, 16);
            this.textVillageName.TabIndex = 1;
            this.textVillageName.Text = "Name of the Village";
            this.textVillageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textVillageName.TextChanged += new System.EventHandler(this.textVillageName_TextChanged);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.PowderBlue;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Enabled = false;
            this.title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(18, 22);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(186, 24);
            this.title.TabIndex = 3;
            this.title.TabStop = false;
            this.title.Text = "Age of Villagers";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // drawingSpace
            // 
            this.drawingSpace.Location = new System.Drawing.Point(1, 0);
            this.drawingSpace.Name = "drawingSpace";
            this.drawingSpace.Size = new System.Drawing.Size(600, 400);
            this.drawingSpace.TabIndex = 1;
            this.drawingSpace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingSpace_MouseClick);
            // 
            // CreateEditVIllage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(819, 400);
            this.Controls.Add(this.drawingSpace);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateEditVIllage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Creation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textNation;
        private System.Windows.Forms.TextBox textVillageName;
        private System.Windows.Forms.RadioButton rbtnWaterResource;
        private System.Windows.Forms.RadioButton rbtnHouse;
        private System.Windows.Forms.RadioButton rbtnTree;
        private System.Windows.Forms.Button btnOpenVillage;
        private System.Windows.Forms.Button btnNewVillage;
        private System.Windows.Forms.Button btnSaveVillage;
        private System.Windows.Forms.TextBox title;
        private Panel drawingSpace;
    }
}

