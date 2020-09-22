using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmers : INation
    {
        public void paint_house(MouseEventArgs e, Graphics g, Pen p)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            Point pt1 = new Point(x, y);
            Point pt2 = new Point(x + 16, y);
            Point pt3 = new Point(x + 16, y + 10);
            Point pt4 = new Point(x, y + 10);
            Point pt5 = new Point(x + 8, y - 6);
            g.DrawLine(p, pt1, pt5);
            g.DrawLine(p, pt5, pt2);
            g.DrawLine(p, pt2, pt3);
            g.DrawLine(p, pt3, pt4);
            g.DrawLine(p, pt4, pt1);
            g.DrawLine(p, pt1, pt2);

        }
        
        public void paint_tree(MouseEventArgs e, Graphics g, Pen p)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            Point pt1 = new Point(x, y);
            Point pt2 = new Point(x+3, y);
            Point pt3 = new Point(x+3, y+16);
            Point pt4 = new Point(x, y+16);
            g.DrawArc(p, x - 8, y - 8, 16, 16, 0, 360);
            g.DrawLine(p, pt1, pt2);
            g.DrawLine(p, pt2, pt3);
            g.DrawLine(p, pt3, pt4);
            g.DrawLine(p, pt4, pt1);

        }
        public void paint_waterSource(MouseEventArgs e, Graphics g, Pen p)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            Point pt1 = new Point(x, y);
            Point pt2 = new Point(x + 8, y-8);
            Point pt3 = new Point(x + 12, y - 10);
            Point pt4 = new Point(x + 12, y - 6);
            Point pt5 = new Point(x + 18, y - 10);
            Point pt6 = new Point(x + 24, y - 2);
            Point pt7 = new Point(x + 20, y + 5);
            Point pt8 = new Point(x + 16, y + 1);
            Point pt9 = new Point(x + 10, y + 6);
            g.DrawLine(p, pt1, pt2);
            g.DrawLine(p, pt2, pt3);
            g.DrawLine(p, pt3, pt4);
            g.DrawLine(p, pt4, pt5);
            g.DrawLine(p, pt5, pt6);
            g.DrawLine(p, pt6, pt7);
            g.DrawLine(p, pt7, pt8);
            g.DrawLine(p, pt8, pt9);
            g.DrawLine(p, pt9, pt1);

        }

    }



    static class Program
    {

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
