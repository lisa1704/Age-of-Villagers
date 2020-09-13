using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    class BangladeshiFarmers : INation
    {
        Pen p = new Pen(Color.Pink);
        public void DrawHouse(Graphics g,Point pt)
        {
            Rectangle rec = new Rectangle(new Point(pt.X, pt.Y), new Point(pt.X + 15, pt.Y + 25));
            TAgle tri = new TAgle(new Point(pt.X - 5, pt.Y + 10), new Point(pt.X, pt.Y), new Point(pt.X + 15, pt.Y));
            rec.Draw(g);
            tri.Draw(g);
        }

        public void DrawTree()
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
