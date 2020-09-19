using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.DrawArc;

namespace AgeOfVillagers
{
    public class InuitHunters : INations
    {
        Pen p = new Pen(Color.Black);
        public string DrawHouse(Graphics g, Point pt)
        {
            InuitHouse IglooHouse = new InuitHouse(pt);
            IglooHouse.Paint(g, p);
            
            return "Igloo";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            NullVillageItem ntree = new NullVillageItem();
            ntree.Paint(g, p);
        }

        public void DrawWaterSource(Graphics g, Point MPt)
        {
            NullVillageItem nullWater = new NullVillageItem();
            nullWater.Paint(g, p);
        }

        public Color GetTerrainColor()
        {
            return Color.White;
        }
    }
}
