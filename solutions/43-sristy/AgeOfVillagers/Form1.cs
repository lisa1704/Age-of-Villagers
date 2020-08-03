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
        string name;
        string type;
        string item;
        List<Point> h_points = new List<Point>();
        List<Point> t_points = new List<Point>();
        List<Point> w_points = new List<Point>();

        Nationfactory nationfactory = new Nationfactory();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void side_panel(object sender, PaintEventArgs e) { }
        private void house_Click(object sender, EventArgs e)
        {
            item = "house";
        }

        private void tree_Click(object sender, EventArgs e)
        {
            item = "tree";
        }

        private void watersource_Click(object sender, EventArgs e)
        {
            item = "water";
        }

        private void draw_panel(object sender, PaintEventArgs e)
        {
            Graphics g = drawpanel.CreateGraphics();
                foreach (Point pt in h_points)
                {
                nationfactory.GetNation(type).Draw_house(g, pt.X - 50, pt.Y - 50);
                }
                foreach (Point pt in t_points)
                {
                nationfactory.GetNation(type).Draw_tree(g, pt.X - 50, pt.Y - 50);
                }
                foreach (Point pt in w_points)
                {
                nationfactory.GetNation(type).Draw_watersource(g, pt.X - 50, pt.Y - 50);
            }
        }

        private void drawpanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (item == "house")
            {
                h_points.Add(e.Location);
            }
            if (item == "tree")
            {
                t_points.Add(e.Location);
            }
            if (item == "water")
            {
                w_points.Add(e.Location);
            }
            drawpanel.Invalidate();
        }

        private void villagename_KeyDown(object sender, KeyEventArgs e)
        {
            name = villagename.Text;
        }

        private void vallagetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = villagetype.Text;
            nationfactory.GetNation(type);
        }

        //private void drawpanel_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (item == "house")
        //    {
        //        h_points.Remove(h_points.Last());
        //    }
        //    if (item == "tree")
        //    {
        //        t_points.Remove(t_points.Last());
        //    }
        //    if (item == "water")
        //    {
        //        w_points.Remove(w_points.Last());
        //    }
        //}
    }
}
