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
            /*Rectangle rec = new Rectangle(new Point(pt.X, pt.Y), new Point(pt.X + 15, pt.Y + 25));
            TAgle tri = new TAgle(new Point(pt.X - 5, pt.Y + 10), new Point(pt.X, pt.Y), new Point(pt.X + 15, pt.Y));*/
            BangladeshiFarmerHouse bdhouse = new BangladeshiFarmerHouse(new Point(pt.X, pt.Y),new Point(pt.X-50,pt.Y*5),new Point(pt.X + 100,pt.Y*10));
            /*rec.Draw(g);
            tri.Draw(g);*/
            bdhouse.Draw(g);
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
