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
        int x;
        int y;
        public VillageEditor()
        {
            InitializeComponent();
        }
    
        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = drawingPanel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

        }

        private void VillageEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VillageEditor_Load_1(object sender, EventArgs e)
        {

        }

        private void villageName_TextChanged(object sender, EventArgs e)
        {

        }

        private void mouseClick1_drawingPanel(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            x = point.X;
            y = point.Y;
            drawingPanel.Invalidate();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mouseClick_NationList(object sender, MouseEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
