using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_villagers
{
    public interface IObject
    {
        void paint(Pen p,Graphics g);
    }

    public class obj_line: IObject
    {
        private Point p1, p2;
        public obj_line(Point p1,Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void paint(Pen p, Graphics g)
        {
            g.DrawLine(p, p1, p2);
        }
    }

    public class obj_arc : IObject
    {
        private Point p1;
        private int x1, x2, r1, r2;
        public obj_arc(Point p1,int x1,int x2, int r1, int r2 )
        {
            this.p1 = p1;
            this.x1 = x1;
            this.x2 = x2;
            this.r1 = r1;
            this.r2 = r2;
        }

        public void paint(Pen p, Graphics g)
        {
            g.DrawArc(p, p1.X-25, p1.Y-25, x1, x2, r1, r2);
        }
    }

    public class null_obj : IObject
    {
        public void paint(Pen p, Graphics g)
        {
            
        }
    }

    public abstract class Compositeobj: IObject
    {
        private List<IObject> components;
        public Compositeobj()
        {
            components = new List<IObject>();
        }
        public void AddComponent(IObject obj)
        {
            components.Add(obj);
        }

        public void paint(Pen p, Graphics g)
        {
            foreach(var comp in components)
            {
                comp.paint(p,g);
            }
        }
    }

    public class obj_triangle : Compositeobj
    {
        public obj_triangle(Point lptop, Point rptop, Point mptop)
        {
            AddComponent(new obj_line(lptop, rptop));
            AddComponent(new obj_line(lptop, mptop));
            AddComponent(new obj_line(rptop, mptop));
        }
    }

    public class obj_rectangle : Compositeobj
    {
        public obj_rectangle(Point lptop, Point rptop, Point lpbottom, Point rpbottom)
        {
            AddComponent(new obj_line(lptop, rptop));
            AddComponent(new obj_line(lptop, lpbottom));
            AddComponent(new obj_line(rptop, rpbottom));
            AddComponent(new obj_line(lpbottom, rpbottom));
        }
    }
}
