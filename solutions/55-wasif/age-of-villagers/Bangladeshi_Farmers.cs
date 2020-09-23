
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    class Bangladeshi_Farmers : INations
    {
        Pen pen = new Pen(Color.Black);
        Graphics gp;
        Point p;
        public Bangladeshi_Farmers(Graphics gp, Point p)
        {
            this.gp = gp;
            this.p = p;

        }
        public void draw_house()
        {
            Point p1 = new Point(p.X + 16, p.Y - 16);
            Point p2 = new Point(p.X + 32, p.Y);
            Point p3 = new Point(p.X, p.Y + 16);
            Point p4 = new Point(p2.X, p2.Y + 16);

            gp.DrawLine(pen, p, p1);
            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p2, p);
            gp.DrawLine(pen, p, p2);
            gp.DrawLine(pen, p, p3);
            gp.DrawLine(pen, p2, p4);
            gp.DrawLine(pen, p3, p4);
        }

        public void draw_tree()
        {
            Point p1 = new Point(p.X - 2, p.Y);
            Point p2 = new Point(p.X + 2, p.Y);
            Point p3 = new Point(p.X - 2, p.Y + 24);
            Point p4 = new Point(p.X + 2, p.Y + 24);
            gp.DrawArc(pen, p.X-12, p.Y-12, 24, 24, 0, 360);
        

            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p1, p3);
            gp.DrawLine(pen, p3, p4);
            gp.DrawLine(pen, p2, p4);
        }

        public void draw_watersource()
        {
            Point p1 = new Point(p.X, p.Y);
            Point p2 = new Point(p.X + 10, p.Y - 4);
            Point p3 = new Point(p.X + 12, p.Y);
            Point p4 = new Point(p.X + 24, p.Y - 10);
            Point p5 = new Point(p.X + 38, p.Y);
            Point p6 = new Point(p.X + 34, p.Y + 18);
            Point p7 = new Point(p.X + 14, p.Y + 10);
            Point p8 = new Point(p.X, p.Y + 22);
            Point p9 = new Point(p.X - 10, p.Y + 14);

            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen,p2, p3);
            gp.DrawLine(pen,p3, p4);
            gp.DrawLine(pen,p4, p5);
            gp.DrawLine(pen,p5, p6);
            gp.DrawLine(pen,p6, p7);
            gp.DrawLine(pen,p7, p8);
            gp.DrawLine(pen,p8, p9);
            gp.DrawLine(pen,p9, p1);
            
        }
        
        public Color draw_terrain()
        {
            return Color.PaleGreen;
        }
    }
}