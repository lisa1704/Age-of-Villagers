using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    public class BangladeshiFarmers : INation
    {
        Pen p = new Pen(Color.Pink);
        public void DrawHouse(Graphics g,Point pt)
        {
            /*Rectangle rec = new Rectangle(new Point(pt.X, pt.Y), new Point(pt.X + 15, pt.Y + 25));
            TAgle tri = new TAgle(new Point(pt.X - 5, pt.Y + 10), new Point(pt.X, pt.Y), new Point(pt.X + 15, pt.Y));*/
            BangladeshiFarmerHouse bdhouse = new BangladeshiFarmerHouse(new Point(pt.X, pt.Y),new Point(pt.X-70,pt.Y+40),new Point(pt.X + 70,pt.Y+120));
            /*rec.Draw(g);
            tri.Draw(g);*/
            bdhouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point pt)
        {
            BangladeshFarmersTree bdtree = new BangladeshFarmersTree(pt);
            bdtree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point pt)
        {
            BangladeshiFarmersWaterSource bdws = new BangladeshiFarmersWaterSource(pt);
            bdws.Draw(g);
        }

        public string BangladeshiFarmerTest()
        {
            return "Bangladeshi";
        }

        public Color BackGroundColor()
        {
            throw new NotImplementedException();
        }
    }
}
