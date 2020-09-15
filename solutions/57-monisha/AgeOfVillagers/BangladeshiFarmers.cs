using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.DrawArc;

namespace AgeOfVillagers
{
   public class BangladeshiFarmers : INations
    {
        Pen p = new Pen(Color.Black);        
        public string DrawHouse(Graphics g,Point pt)
        {
           /* ShapeRectangle r = new ShapeRectangle(new Point(pt.X, pt.Y), new Point(pt.X + 10, pt.Y+20));
            Triangle tr = new Triangle(new Point(pt.X-5, pt.Y-10), new Point(pt.X, pt.Y),new Point(pt.X+10,pt.Y));*/
           BDHouse house = new BDHouse(new Point(pt.X, pt.Y));
            /*r.Paint(g);
            tr.Paint(g);*/
            house.Paint(g,p);
            //g.DrawLine(p, pt.X, pt.Y, pt.X + 16, pt.X + 16);
            return "KureGhor";
        }
        public string testHouse()
        {
            return "KureGhor";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            BDTree BDtree = new BDTree(pt);
            BDtree.Paint(g, p);
        }
        public void DrawWaterSource(Graphics g, Point MPt)
        {
            BDWaterSource BDWaterSource = new BDWaterSource(MPt);
            BDWaterSource.Paint(g, p);
        }
        public Color GetTerrainColor()
        {
            //DrawPanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            return System.Drawing.Color.LightGreen;
           //throw new NotImplementedException();
        }

    
    }
}
