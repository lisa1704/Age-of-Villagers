using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static AgeOfVillagers.DrawArc;
using static AgeOfVillagers.ShapeArc;

namespace AgeOfVillagers
{
    public class BangladeshiHouse : CompositeShape
    {
        public string testBdHouse;
        public BangladeshiHouse(Point MPt)
        {            
            Point tpt1 = new Point(MPt.X + 16, MPt.Y );
            Point tpt2 = new Point(MPt.X + 8, MPt.Y -8);
            Point rpt1 = new Point(tpt1.X , tpt1.Y);
            Point rpt2 = new Point(MPt.X , MPt.Y + 8);

            AddComp(new Triangle(tpt1, tpt2, MPt));
            AddComp(new ShapeRectangle(rpt1, rpt2));
            testBdHouse = "BDHouse Constructed";
        }
        public string CheckHouse()
        {
            return testBdHouse;
        }
    }
    class ArabBedouinHouse : CompositeShape
    {
        public ArabBedouinHouse(Point MPt)
        {
            Point tpt1 = new Point(MPt.X - 6, MPt.Y + 10);
            Point tpt2 = new Point(MPt.X + 6, MPt.Y + 10);
            Point rpt1 = new Point(tpt2.X + 10, tpt2.Y - 4);
            Point rpt2 = new Point(MPt.X + 8, MPt.Y - 6);          

            AddComp(new Triangle(tpt2, tpt1, MPt));
            AddComp(new ShapeRectangle(MPt, rpt1, tpt2, rpt2));        

        }
    }
    class EgyptianHouse : CompositeShape
    {
        public EgyptianHouse(Point MPt)
        {
            Point tpt1 = new Point(MPt.X - 10, MPt.Y + 14);
            Point tpt2 = new Point(MPt.X + 6, MPt.Y + 16);
            Point tpt3 = new Point(tpt2.X + 6, tpt2.Y - 10);            

            AddComp(new Triangle(tpt2, tpt1, MPt));
            AddComp(new Triangle(tpt3, tpt2, MPt));    

        }
    }
    class InuitHouse : CompositeShape
    {
        public InuitHouse(Point MPt)
        {           
            /*Point Lpt1 = new Point(MPt.X - 45, MPt.Y + 10);
            Point Lpt2 = new Point(MPt.X + 52, MPt.Y + 10);
            Point Opt1 = new Point(MPt.X - 8, MPt.Y -5);*/
            Point Lpt1 = new Point(MPt.X - 6, MPt.Y + 10);
            Point Lpt2 = new Point(MPt.X + 10, MPt.Y + 10);
            Point Opt1 = new Point(MPt.X -1, MPt.Y + 7 );

           /* AddComp(new Line(Lpt1, Lpt2));
           *//* AddComp(new ShapeArc(Opt1.X, Opt1.Y, topPt2.X - Opt1.X, topPt2.Y - Opt1.Y, 0, -180.0F));
            AddComp(new ShapeArc(MPt.X, MPt.Y, topPt4.X - MPt.X, topPt4.Y - MPt.Y, 0, -180.0F));*//*
            AddComp(new ShapeArc(Opt1.X, Opt1.Y, 27, 29, 0, -180.0F));
            AddComp(new ShapeArc(Lpt1.X, Lpt1.Y-45, 98, 90, 0, -180.0F));*/
            AddComp(new Line(Lpt1, Lpt2));
            AddComp(new ShapeArc(Opt1.X, Opt1.Y, 6, 4, 0, -180.0F));
            AddComp(new ShapeArc(Lpt1.X, Lpt1.Y - 8, 16, 14, 0, -180.0F));
        }
    }
}
