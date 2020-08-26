namespace AgeOfVillagers
{
    partial class NewVillageSelectorwindow
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
            this.cboxnation = new System.Windows.Forms.ComboBox();
            this.lblvillagename = new System.Windows.Forms.Label();
            this.lblnation = new System.Windows.Forms.Label();
            this.txtvillagename = new System.Windows.Forms.TextBox();
            this.btndone = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxnation
            // 
            this.cboxnation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxnation.FormattingEnabled = true;
            this.cboxnation.Location = new System.Drawing.Point(239, 132);
            this.cboxnation.Name = "cboxnation";
            this.cboxnation.Size = new System.Drawing.Size(280, 29);
            this.cboxnation.TabIndex = 0;
            // 
            // lblvillagename
            // 
            this.lblvillagename.AutoSize = true;
            this.lblvillagename.Location = new System.Drawing.Point(66, 58);
            this.lblvillagename.Name = "lblvillagename";
            this.lblvillagename.Size = new System.Drawing.Size(111, 21);
            this.lblvillagename.TabIndex = 1;
            this.lblvillagename.Text = "Village name : ";
            // 
            // lblnation
            // 
            this.lblnation.AutoSize = true;
            this.lblnation.Location = new System.Drawing.Point(66, 132);
            this.lblnation.Name = "lblnation";
            this.lblnation.Size = new System.Drawing.Size(102, 21);
            this.lblnation.TabIndex = 2;
            this.lblnation.Text = "Select Nation";
            // 
            // txtvillagename
            // 
            this.txtvillagename.Location = new System.Drawing.Point(239, 58);
            this.txtvillagename.Name = "txtvillagename";
            this.txtvillagename.Size = new System.Drawing.Size(280, 29);
            this.txtvillagename.TabIndex = 3;
            // 
            // btndone
            // 
            this.btndone.Location = new System.Drawing.Point(425, 205);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(94, 29);
            this.btndone.TabIndex = 4;
            this.btndone.Text = "Done";
            this.btndone.UseVisualStyleBackColor = true;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(239, 205);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(94, 29);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // NewVillageSelectorwindow
            // 
            this.ClientSize = new System.Drawing.Size(598, 271);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.txtvillagename);
            this.Controls.Add(this.lblnation);
            this.Controls.Add(this.lblvillagename);
            this.Controls.Add(this.cboxnation);
            this.Name = "NewVillageSelectorwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Village";
            this.Load += new System.EventHandler(this.NewVillageSelectorwindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox cboxnation;
        private System.Windows.Forms.Label lblvillagename;
        private System.Windows.Forms.Label lblnation;
        private System.Windows.Forms.TextBox txtvillagename;
        private System.Windows.Forms.Button btndone;
        private System.Windows.Forms.Button btncancel;
    }

}

