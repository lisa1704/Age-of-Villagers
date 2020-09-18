using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.DrawArc;

namespace AgeOfVillagers
{
    class ArabBedouin : INations
    {
        Pen p = new Pen(Color.Black);
        public string DrawHouse(Graphics g, Point pt)
        {
            ArabBedouinHouse ArabHouse = new ArabBedouinHouse(pt);
            ArabHouse.Paint(g, p);
            //g.DrawLine(p, pt.X, pt.Y, pt.X + 16, pt.X + 16);
            return "Stonehouse";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            ArabTree Arabtree = new ArabTree(pt);
            Arabtree.Paint(g, p);
        }

        public void DrawWaterSource(Graphics g, Point MPt)
        {
            NullVillageItem nullWater = new NullVillageItem();
            nullWater.Paint(g,p);
        }

        public Color GetTerrainColor()
        {
            return Color.PaleGoldenrod;
        }
    }
}
