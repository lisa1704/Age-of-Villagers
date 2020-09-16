using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    class ArabBedouin : INation
    {
        Pen p = new Pen(Color.Violet);

        public Color BackGroundColor()
        {
            return Color.YellowGreen;
        }

        public void DrawHouse(Graphics g, Point pt)
        {
            ArabBedouinHOuse abhouse = new ArabBedouinHOuse(pt);
            abhouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point pt)
        {
            ArabBedouinTree abtree = new ArabBedouinTree(pt);
            abtree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point pt)
        {
            NullVillageItem abNullws = new NullVillageItem();
            abNullws.paint();
        }


    }
}
