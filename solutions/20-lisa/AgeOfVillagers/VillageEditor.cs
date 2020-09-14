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
    public partial class VillageEditor : Form
    {
        private Panel drawPanel;
        private Panel toolPanel;

        public VillageEditor()
        {
            InitializeComponent();
        }
        private void EditorPanel()
        {
            toolPanel = new Panel();
            SuspendLayout();
            DrawingPanel();
            ResumeLayout(false);
        }
        private void DrawingPanel()
        {
            drawPanel = new Panel
            {
                Location = new Point(0, 0),
                Name = "DrawingPanel",
                TabIndex = 0,
                Size = new Size(600,400),
                BackColor = Color.IndianRed,

            };
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VillageEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
