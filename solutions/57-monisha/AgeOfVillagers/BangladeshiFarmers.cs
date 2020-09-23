using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static AgeOfVillagers.DrawArc;

namespace AgeOfVillagers
{
   public class BangladeshiFarmers : INations
    {
        Pen p = new Pen(Color.Black);   
        string testBdHouse;
        public object DrawHouse(Graphics g,Point pt)
        {
            BangladeshiHouse house = new BangladeshiHouse(new Point(pt.X, pt.Y));
         
            house.Paint(g,p);
            testBdHouse = "BDHouse Constructed";
            //return "KureGhor";
            return house;
        }

        public object testHouse(Point pt)
        {
            return new BangladeshiHouse(new Point(pt.X, pt.Y));
        }
        public object DrawTree(Graphics g, Point pt)
        {
            BangladeshiTree BDtree = new BangladeshiTree(pt);
            BDtree.Paint(g, p);
            return BDtree;
        }

        public object testTree(Point pt)
        {
            return new BangladeshiTree(pt);
        }

        public object DrawWaterSource(Graphics g, Point MPt)
        {
            BangladeshiWaterSource BDWaterSource = new BangladeshiWaterSource(MPt);
            BDWaterSource.Paint(g, p);
            return new BangladeshiWaterSource(MPt);
        }

        public object testWaterSource(Point pt)
        {
            return new BangladeshiWaterSource(pt);
        }

        public Color GetTerrainColor()
        {
            //DrawPanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            return System.Drawing.Color.LightGreen;
        }

    
    }
}
