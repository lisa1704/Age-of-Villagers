﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.DrawArc;
using static AgeOfVillagers.ShapeArc;

namespace AgeOfVillagers
{
    public class BDHouse : CompositeShape
    {
        public BDHouse(Point top, Point topLeft, Point bottomRight)
        {
            AddComp(new ShapeRectangle(topLeft, bottomRight));
            AddComp(new Triangle(top, topLeft, new Point(bottomRight.X, topLeft.Y)));
        }

    }
    class ArabBedouinHouse : CompositeShape
    {
        public ArabBedouinHouse(Point MPt)
        {
            Point tpt1 = new Point(MPt.X - 24, MPt.Y + 50);
            Point tpt2 = new Point(MPt.X + 24, MPt.Y + 50);
            Point rpt1 = new Point(tpt2.X+25, tpt2.Y -15);
            Point rpt2 = new Point(MPt.X + 25, MPt.Y - 15);          

            AddComp(new Triangle(tpt2, tpt1, MPt));
            AddComp(new Line(MPt, rpt2));
            AddComp(new Line(tpt2, rpt1));
            AddComp(new Line(rpt2, rpt1));

        }
    }
    class EgyptianHouse : CompositeShape
    {
        public EgyptianHouse(Point MPt)
        {
            Point tpt1 = new Point(MPt.X - 24, MPt.Y + 50);
            Point tpt2 = new Point(MPt.X + 16, MPt.Y + 50);
            Point tpt3 = new Point(tpt2.X + 15, tpt2.Y - 25);
            Point tpt4 = new Point(MPt.X + 25, MPt.Y - 15);

            AddComp(new Triangle(tpt2, tpt1, MPt));
            AddComp(new Triangle(tpt3, tpt2, MPt));    

        }
    }
    class InuitHouse : CompositeShape
    {
        public InuitHouse(Point MPt)
        {
            Point Lpt1 = new Point(MPt.X - 45, MPt.Y + 10);
            Point Lpt2 = new Point(MPt.X + 50, MPt.Y +10);
            Point Opt1 = new Point(MPt.X - 40, MPt.Y + -40);
          
            Point topPt2 = new Point(MPt.X + 50, MPt.Y + 55);
            Point topPt4 = new Point(MPt.X + 20, MPt.Y + 20);
            AddComp(new Line(Lpt1, Lpt2));
            //AddComp(new DrawArc(tpt1.X, tpt1.Y + 40, tpt2.X - tpt1.X, tpt2.Y - tpt1.Y, 0, 360));
            //AddComp(new ShapeHalfCircle(MPt, topPt));
            AddComp(new ShapeHalfCircle(Opt1, new Point(topPt2.X, (int)(topPt2.Y))));
            AddComp(new ShapeHalfCircle(MPt, new Point(topPt4.X, (int)(topPt4.Y))));

        }
    }
}
