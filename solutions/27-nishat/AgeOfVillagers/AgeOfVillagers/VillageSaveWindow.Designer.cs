namespace AgeOfVillagers
{
    partial class VillageSaveWindow
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
            this.lblvillagename = new System.Windows.Forms.Label();
            this.txtvillagename = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // txtvillagename
            // 
            this.txtvillagename.Location = new System.Drawing.Point(239, 58);
            this.txtvillagename.Name = "txtvillagename";
            this.txtvillagename.Size = new System.Drawing.Size(280, 29);
            this.txtvillagename.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(425, 129);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 29);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(239, 129);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(94, 29);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // VillageSaveWindow
            // 
            this.ClientSize = new System.Drawing.Size(598, 208);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtvillagename);
            this.Controls.Add(this.lblvillagename);
            this.Name = "VillageSaveWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm save";
            this.Load += new System.EventHandler(this.VillageSaveWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label lblvillagename;
        private System.Windows.Forms.TextBox txtvillagename;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
    }

}

