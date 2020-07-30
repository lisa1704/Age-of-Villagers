using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_villagers
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        string type;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void side_panel(object sender, PaintEventArgs e)
        {

        }

        private void house_Click(object sender, EventArgs e)
        {
            type = "house";
        }

        private void tree_Click(object sender, EventArgs e)
        {
            type = "tree";
        }

        private void wattersource_Click(object sender, EventArgs e)
        {
            type = "watter";
        }

        private void draw_panel(object sender, PaintEventArgs e)
        {
            Graphics g = drawpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            if (type=="house")
            {
                g.DrawRectangle(p, x - 50, y - 50, 100, 100);
            }
            if (type == "tree")
            {
                g.DrawEllipse(p, x - 50, y - 50, 100, 100);
            }
            if (type == "watter")
            {
                g.DrawEllipse(p, x - 50, y - 50, 100, 100);
            }

        }

        private void drawpanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            x = p.X;
            y = p.Y;
            drawpanel.Invalidate();
        }
    }
}
