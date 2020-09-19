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
        string testBdHouse;
        public string DrawHouse(Graphics g,Point pt)
        {
            BangladeshiHouse house = new BangladeshiHouse(new Point(pt.X, pt.Y));
         
            house.Paint(g,p);
            testBdHouse = "BDHouse Constructed";
            return "KureGhor";
        }
        public string testHouse()
        {
            return "BDHouse Constructed";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            BangladeshiTree BDtree = new BangladeshiTree(pt);
            BDtree.Paint(g, p);
        }
        public void DrawWaterSource(Graphics g, Point MPt)
        {
            BangladeshiWaterSource BDWaterSource = new BangladeshiWaterSource(MPt);
            BDWaterSource.Paint(g, p);
        }
        public Color GetTerrainColor()
        {
            //DrawPanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            return System.Drawing.Color.LightGreen;
        }

    
    }
}
