using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class NullNation : INations
    {
        Pen p = new Pen(Color.Black);
        public object DrawHouse(Graphics g, Point pt)
        {
            NullVillageItem nHouse = new NullVillageItem(pt);
            //return "No Nation";
            return nHouse;
        }

        public object DrawTree(Graphics g, Point pt)
        {
            NullVillageItem ntree = new NullVillageItem(pt);
            ntree.Paint(g, p);
            return ntree;            
        }

        public object DrawWaterSource(Graphics g, Point MPt)
        {
            NullVillageItem nWater = new NullVillageItem(MPt);
            nWater.Paint(g, p);
            return nWater;
        }

        public Color GetTerrainColor()
        {
            return Color.MintCream;
        }
    }
}
