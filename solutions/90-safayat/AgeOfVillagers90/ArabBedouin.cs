using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    public class ArabBedouin : INation
    {
        public Color BackGroundColor()
        {
            return Color.LightYellow;
        }

        public object DrawHouse(Graphics g, Point pt)
        {
            ArabBedouinHOuse abhouse = new ArabBedouinHOuse(pt);
            abhouse.Draw(g);
            return abhouse;
        }

        public object DrawTree(Graphics g, Point pt)
        {
            ArabBedouinTree abtree = new ArabBedouinTree(pt);
            abtree.Draw(g);
            return abtree;
        }

        public object DrawWaterSource(Graphics g, Point pt)
        {
            NullVillageItem abNullws = new NullVillageItem();
            abNullws.paint();
            return abNullws;
        }

        public object TestDrawHouse(Point point)
        {
            return new ArabBedouinHOuse(point);
        }

        public object TestDrawTree(Point point)
        {
            return new ArabBedouinTree(point);
        }

    }
}
