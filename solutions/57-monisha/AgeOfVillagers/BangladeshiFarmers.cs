﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.Arc;

namespace AgeOfVillagers
{
   public class BangladeshiFarmers : INations
    {
        Pen p = new Pen(Color.Green);
        public string DrawHouse(Graphics g,Point pt)
        {
           /* ShapeRectangle r = new ShapeRectangle(new Point(pt.X, pt.Y), new Point(pt.X + 10, pt.Y+20));
            Triangle tr = new Triangle(new Point(pt.X-5, pt.Y-10), new Point(pt.X, pt.Y),new Point(pt.X+10,pt.Y));*/
           BDHouse house = new BDHouse(new Point(pt.X, pt.Y), new Point(pt.X-50, pt.Y*5), new Point(pt.X +50, pt.Y*10));
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

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
