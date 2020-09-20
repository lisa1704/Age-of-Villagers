using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    class Inuit_Hunters : INations
    {
        Pen pen = new Pen(Color.Red);
        Graphics gp;
        public Inuit_Hunters(Graphics gp)
        {
            this.gp = gp;
        }
        public void draw_house()
        {
            
            Point p0 = new Point(50, 50);
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
            throw new NotImplementedException();
        }
    }
}
