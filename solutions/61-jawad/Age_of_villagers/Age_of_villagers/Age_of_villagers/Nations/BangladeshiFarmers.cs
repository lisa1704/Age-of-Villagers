using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Age_of_villagers.Nations
{
    class BangladeshiFarmers : INation
    {
        Pen p = new Pen(Color.Black);
        string testBdHouse;
        public object DrawHouse(Graphics g, Point pt)
        {
            BangladeshiHouse house = new BangladeshiHouse(new Point(pt.X, pt.Y));

            house.Paint(g, p);
            testBdHouse = "BDHouse Constructed";
            //return "KureGhor";
            return house;
        }
        public string testHouse()
        {
            return "BDHouse Constructed";
        }
        public object DrawTree(Graphics g, Point pt)
        {
            BangladeshiTree BDtree = new BangladeshiTree(pt);
            BDtree.Paint(g, p);
            return BDtree;
        }
    }
}
