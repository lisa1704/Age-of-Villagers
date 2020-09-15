using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.DrawArc;

namespace AgeOfVillagers
{
    class EgyptianKings : INations
    {
        Pen p = new Pen(Color.SkyBlue);
        public string DrawHouse(Graphics g, Point pt)
        {
            EgyptianHouse EgyptHouse = new EgyptianHouse(pt);
            EgyptHouse.Paint(g, p);
            //g.DrawLine(p, pt.X, pt.Y, pt.X + 16, pt.X + 16);
            return "Piramid";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            EgyptianTree EgyptTree = new EgyptianTree(pt);
            EgyptTree.Paint(g, p);
        }

        public void DrawWaterSource(Graphics g, Point MPt)
        {
            EgyptianWaterSource EgyptWater = new EgyptianWaterSource(MPt);
            EgyptWater.Paint(g, p);
        }

        public Color GetTerrainColor()
        {
            return Color.Gold;
        }
    }
}
