namespace AgeOfVillagers
{
    partial class OpenVillageWindow
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
            this.lblnationselect = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.cboxnation = new System.Windows.Forms.ComboBox();
            this.lblvillagepath = new System.Windows.Forms.Label();
            this.txtvillagepath = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnationselect
            // 
            this.lblnationselect.AutoSize = true;
            this.lblnationselect.Location = new System.Drawing.Point(47, 118);
            this.lblnationselect.Name = "lblnationselect";
            this.lblnationselect.Size = new System.Drawing.Size(102, 21);
            this.lblnationselect.TabIndex = 1;
            this.lblnationselect.Text = "Select Nation";
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(517, 203);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(94, 29);
            this.btnopen.TabIndex = 4;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(381, 203);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(94, 29);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cboxnation
            // 
            this.cboxnation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxnation.FormattingEnabled = true;
            this.cboxnation.Location = new System.Drawing.Point(195, 115);
            this.cboxnation.Name = "cboxnation";
            this.cboxnation.Size = new System.Drawing.Size(280, 29);
            this.cboxnation.TabIndex = 5;
            // 
            // lblvillagepath
            // 
            this.lblvillagepath.AutoSize = true;
            this.lblvillagepath.Location = new System.Drawing.Point(47, 46);
            this.lblvillagepath.Name = "lblvillagepath";
            this.lblvillagepath.Size = new System.Drawing.Size(102, 21);
            this.lblvillagepath.TabIndex = 1;
            this.lblvillagepath.Text = "Select Village";
            // 
            // txtvillagepath
            // 
            this.txtvillagepath.Enabled = false;
            this.txtvillagepath.Location = new System.Drawing.Point(195, 46);
            this.txtvillagepath.Name = "txtvillagepath";
            this.txtvillagepath.Size = new System.Drawing.Size(280, 29);
            this.txtvillagepath.TabIndex = 6;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(517, 42);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(94, 29);
            this.btnbrowse.TabIndex = 7;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // OpenVillageWindow
            // 
            this.ClientSize = new System.Drawing.Size(656, 272);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtvillagepath);
            this.Controls.Add(this.lblvillagepath);
            this.Controls.Add(this.cboxnation);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.lblnationselect);
            this.Name = "OpenVillageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Village";
            this.Load += new System.EventHandler(this.OpenVillageWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label lblnationselect;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ComboBox cboxnation;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.Label lblvillagepath;
        private System.Windows.Forms.TextBox txtvillagepath;
        private System.Windows.Forms.Button btnbrowse;
    }

}

