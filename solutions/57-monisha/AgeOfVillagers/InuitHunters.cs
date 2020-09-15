using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.DrawArc;

namespace AgeOfVillagers
{
    class InuitHunters : INations
    {
        Pen p = new Pen(Color.Gray);
        public string DrawHouse(Graphics g, Point pt)
        {
            InuitHouse IglooHouse = new InuitHouse(pt);
            IglooHouse.Paint(g, p);
      /*      ShapeRectangle r = new ShapeRectangle(new Point(pt.X, pt.Y), new Point(pt.X + 10, pt.Y + 20));
            r.Paint(g,p);*/
            //g.DrawLine(p, pt.X, pt.Y, pt.X + 16, pt.X + 16);
            return "Igloo";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            NullTree ntree = new NullTree();
        }

        public void DrawWaterSource(Graphics g, Point MPt)
        {
            NullWater nullWater = new NullWater();
            
        }

        public Color GetTerrainColor()
        {
            return Color.White;
        }
    }
}
