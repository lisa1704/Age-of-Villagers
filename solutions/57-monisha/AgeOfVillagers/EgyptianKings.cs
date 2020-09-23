using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static AgeOfVillagers.DrawArc;

namespace AgeOfVillagers
{
    public class EgyptianKings : INations
    {
        Pen p = new Pen(Color.Black);
        public object DrawHouse(Graphics g, Point pt)
        {
            EgyptianHouse EgyptHouse = new EgyptianHouse(pt);
            EgyptHouse.Paint(g, p);
            //return "Piramid";
            return EgyptHouse;
        }
        public object testHouse(Point pt)
        {
            return new EgyptianHouse(pt);
        }

        public object DrawTree(Graphics g, Point pt)
        {
            EgyptianTree EgyptTree = new EgyptianTree(pt);
            EgyptTree.Paint(g, p);
            return EgyptTree;
        }

        public object DrawWaterSource(Graphics g, Point MPt)
        {
            EgyptianWaterSource EgyptWater = new EgyptianWaterSource(MPt);
            EgyptWater.Paint(g, p);
            return EgyptWater;
        }

        public Color GetTerrainColor()
        {
            return Color.Yellow;
        }
      
    }
}
