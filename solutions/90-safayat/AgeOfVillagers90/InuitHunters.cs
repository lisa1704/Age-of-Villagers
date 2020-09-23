using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    public class InuitHunters : INation
    {
        public Color BackGroundColor()
        {
            return Color.White;
        }

        public object DrawHouse(Graphics g, Point pt)
        {
            InuitHouse inhouse = new InuitHouse(pt);
            inhouse.Draw(g);
            return inhouse;
        }

        public object DrawTree(Graphics g, Point pt)
        {
            NullVillageItem InuitNulltree = new NullVillageItem();
            InuitNulltree.paint();
            return InuitNulltree;

        }

        public object DrawWaterSource(Graphics g, Point pt)
        {
            NullVillageItem InuitNullws = new NullVillageItem();
            InuitNullws.paint();
            return InuitNullws;
        }

        public object testDrawHouse(Point point)
        {
            return new InuitHouse(point);
        }
    }
}
