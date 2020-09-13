using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class DrawingPanel : Form
    {
        private Panel drawingPanel;
    

        public DrawingPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {   
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Name = "DrawingPanel";
            this.Load += new System.EventHandler(this.DrawingPanel_Load);
            this.ResumeLayout(false);

        }
        private void InitDrawingPanel()
        {
            drawingPanel = new Panel
            {
                Location = new Point(0, 0),
                Name = "DrawingVillagePanel",
                Size = new Size(600, 400),
                TabIndex = 0,
                BackColor =Color.White
            };
        }

        private void DrawingPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
