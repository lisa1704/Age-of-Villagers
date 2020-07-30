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
        List<Point> h_points = new List<Point>();
        List<Point> t_points = new List<Point>();
        List<Point> w_points = new List<Point>();
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
                foreach (Point pt in h_points)
                {
                    g.DrawRectangle(p, pt.X - 50, pt.Y - 50, 100, 100);
                }
                foreach (Point pt in t_points)
                {
                    g.DrawEllipse(p, pt.X - 50, pt.Y - 50, 100, 100);
                }
                foreach (Point pt in w_points)
                {
                    g.DrawEllipse(p, pt.X - 50, pt.Y - 50, 100, 100);
                }
        }

        private void drawpanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (type == "house")
            {
                h_points.Add(e.Location);
            }
            if (type == "tree")
            {
                t_points.Add(e.Location);
            }
            if (type == "watter")
            {
                w_points.Add(e.Location);
            }                
            drawpanel.Invalidate();
        }
    }
}
