using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    class Arab_Beduin : INations
    {
        Pen pen = new Pen(Color.Black);
        Graphics gp;
        Point point;

        public Arab_Beduin(Graphics gp, Point point)
        {
            this.gp = gp;
            this.point = point;
        }
        public void draw_house()
        {
            Point p1 = new Point(point.X + 25, point.Y + 50);
            Point p2 = new Point(point.X - 25, point.Y + 50);
            Point p3 = new Point(point.X + 25, point.Y - 25);
            Point p4 = new Point(point.X + 50, point.Y + 25);
            gp.DrawLine(pen, point, p1);
            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p2, point);
            gp.DrawLine(pen, point, p3);
            gp.DrawLine(pen, p3, p4);
            gp.DrawLine(pen, p1, p4);
        }

        public void draw_tree()
        {
            Point p0 = new Point(point.X, point.Y);
            Point p1 = new Point(p0.X - 2, p0.Y);
            Point p2 = new Point(p0.X + 2, p0.Y);
            Point p3 = new Point(p0.X - 2, p0.Y + 50);
            Point p4 = new Point(p0.X + 2, p0.Y + 50);
            Point p5 = new Point(p0.X, p0.Y - 35);
            Point p6 = new Point(p0.X - 25, p0.Y - 25);
            Point p7 = new Point(p0.X + 25, p0.Y - 25);
            Point p8 = new Point(p0.X - 35, p0.Y - 10);
            Point p9 = new Point(p0.X + 35, p0.Y - 10);
            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p1, p3);
            gp.DrawLine(pen, p3, p4);
            gp.DrawLine(pen, p2, p4);
            gp.DrawLine(pen, p0, p5);
            gp.DrawLine(pen, p0, p6);
            gp.DrawLine(pen, p0, p7);
            gp.DrawLine(pen, p0, p8);
            gp.DrawLine(pen, p0, p9);
        }

        public void draw_watersource()
        {
            MessageBox.Show("No water resource found");
        }
        public void draw_terrain()
        {

        }
    }
}

