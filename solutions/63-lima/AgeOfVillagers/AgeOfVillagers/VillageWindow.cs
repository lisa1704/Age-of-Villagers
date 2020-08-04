using System.Windows.Forms;

namespace AgeOfVillagers
{
    class VillageWindow : Form
    {
        private Panel panel1;

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            // 
            // VillageWindow
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Name = "VillageWindow";
            this.ResumeLayout(false);

        }
    }
}