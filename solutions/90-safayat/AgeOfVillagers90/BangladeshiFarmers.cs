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
            BangladeshiFarmerHouse bdhouse = new BangladeshiFarmerHouse(pt);
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
            return Color.ForestGreen;
        }
    }
}
