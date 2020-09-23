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
        Pen pen = new Pen(Color.Black);
        Graphics gp;
        Point p0;
        public Inuit_Hunters(Graphics gp, Point p0)
        {
            this.gp = gp;
            this.p0 = p0;
        }
        public void draw_house()
        {
            Point p1 = new Point(p0.X, p0.Y);
            Point p2 = new Point(p1.X + 24, p0.Y);
            Point p3 = new Point(p1.X + 24, p0.Y + 24);
            Point p4 = new Point(p1.X, p0.Y + 24);

            gp.DrawLine(pen, p3, p4);
            gp.DrawArc(pen, p1.X, p1.Y+1, 24, 45, 0, -180);
            gp.DrawArc(pen, p1.X + 9, p2.Y + 16, 6, 15, 0, -180);
            

        }

        public void draw_tree()
        {
            MessageBox.Show("Inuit Hunters can not plant trees");
        }

        public void draw_watersource()
        {
            MessageBox.Show("Inuit Hunters does not have water source");
        }
        public Color draw_terrain()
        {
            return Color.White;
        }
    }
}

