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

        public object DrawHouse(Graphics g,Point pt)
        {
            BangladeshiFarmerHouse bdhouse = new BangladeshiFarmerHouse(pt);
            bdhouse.Draw(g);
            return bdhouse;
        }

        public object DrawTree(Graphics g, Point pt)
        {
            BangladeshFarmersTree bdtree = new BangladeshFarmersTree(pt);
            bdtree.Draw(g);
            return bdtree;
        }

        public object DrawWaterSource(Graphics g, Point pt)
        {
            BangladeshiFarmersWaterSource bdws = new BangladeshiFarmersWaterSource(pt);
            bdws.Draw(g);
            return bdws;
        }

        public string BangladeshiFarmerTest()
        {
            return "Bangladeshi";
        }

        public Color BackGroundColor()
        {
            return Color.ForestGreen;
        }

        public object testDrawHouse(Point point)
        {
            return new BangladeshiFarmerHouse(point);
        }

        public object testDrawTree(Point point)
        {
            return new BangladeshiFarmerHouse(point);
        }


        public object testDrawWaterSource(Point point)
        {
            return new BangladeshiFarmerHouse(point);
        }
    }
}
