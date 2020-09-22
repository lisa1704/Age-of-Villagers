using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace age_of_villagers
{
    class Inuit_Hunters : INations
    {
        Pen pen = new Pen(Color.Red);
        Graphics gp;
        Point p0;
        public Inuit_Hunters(Graphics gp, Point p0)
        {
            this.gp = gp;
            this.p0 = p0;
        }
        public void draw_house()
        {
            Point p1 = new Point(p0.X - 75, p0.Y);
            Point p2 = new Point(p0.X + 75, p0.Y);
            Point p3 = new Point(p0.X - 50, p0.Y - 50);
            gp.DrawArc(pen, p3.X, p3.Y, 150, 150, 180, 180);
            gp.DrawArc(pen, p2.X, p2.Y, 150, 150, 180, 180);
            gp.DrawLine(pen, p1, p2);
        }

        public void draw_tree()
        {
            MessageBox.Show("Inuit Hunters can not plant trees");
        }

        public void draw_watersource()
        {
            MessageBox.Show("Inuit Hunters does not have water source");
        }
    }
}

