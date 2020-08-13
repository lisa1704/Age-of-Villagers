using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public interface IShapes
    {
        void Draw(Graphics g);
        Rectangle1 GetBBox();
    }

    public class Line : IShapes
    {
        Point point1, point2;

        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, point1, point2);
        }

       

        public Rectangle1 GetBBox()
        {
            throw new System.NotImplementedException();
        }
    }
    public class Rectangle1 : CompositeShape
    {

        
      
                                                                 

        public Rectangle1(Point topLeft,Point topRight, Point bottomLeft, Point bottomRight)
        {
           


          
            AddComponent(new Line(topLeft,topRight));
            AddComponent(new Line(topLeft,bottomLeft));
            AddComponent(new Line(bottomLeft,bottomRight));
            AddComponent(new Line(bottomRight,topRight));

        }

        
    }

    public class Arc1 : IShapes
    {
        public int x ,y, width, height, startAngle, sweepAngle;




        public Arc1(int x, int y, int width,int height,int startAngle,int sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;

        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
        }

        public Rectangle1 GetBBox()
        {
            throw new System.NotImplementedException();
        }
    }


    public class Triangle1 : CompositeShape
    {
 


        public Triangle1(Point top, Point baseLeft,Point baseRight)
        {
           



            AddComponent(new Line(top, baseRight));
            AddComponent(new Line(top, baseLeft));
            AddComponent(new Line(baseRight, baseLeft));
        

        }


    }

    public class BangladeshiFarmersHouse : CompositeShape
    {



        public BangladeshiFarmersHouse(Point top, Point baseTopLeft, Point baseBottomRight)
        {

            var baseTopRight = new Point(baseBottomRight.X,baseTopLeft.Y);
            var baseBottomLeft = new Point(baseTopLeft.X, baseBottomRight.Y);
            AddComponent(new Triangle1(top, baseTopLeft, baseTopRight));
            AddComponent(new Rectangle1(baseTopLeft,baseTopRight,baseBottomLeft, baseBottomRight));
       

        }

    }

    public class BangladeshiFarmersTree : CompositeShape
    {



        public BangladeshiFarmersTree(Point top, Point baseTopLeft, Point baseBottomRight,int treeWidth,int treeHeight)
        {

            var baseTopRight = new Point(baseBottomRight.X, baseTopLeft.Y);
            var baseBottomLeft = new Point(baseTopLeft.X, baseBottomRight.Y);
            AddComponent(new Arc1(top.X,top.Y,treeWidth,16,0,360));
            AddComponent(new Rectangle1(baseTopLeft, baseTopRight, baseBottomLeft, baseBottomRight));


        
           


        }

    }
    public class EgyptianKingsHouse: CompositeShape
    {



        public EgyptianKingsHouse(Point top,Point bottomleft, Point bottomMid, Point bottomRight)
        {

           

            AddComponent(new Triangle1(top,bottomleft,bottomMid ));
            AddComponent(new Triangle1(top, bottomRight, bottomMid));


        }

    }

    
    public class EgyptianKingsTreePartSymmetric : CompositeShape
    {



        public EgyptianKingsTreePartSymmetric(Point bottom, Point mid, int leafHeight, int leafWidth)
        {

            var firstLeaf = new Point(mid.X - leafWidth, mid.Y - leafHeight);
            var midLeaf = new Point(mid.X, mid.Y - leafHeight);
            var lastLeaf = new Point(mid.X + leafWidth, mid.Y - leafHeight);



            AddComponent(new Line(bottom, mid));
            AddComponent(new Line(mid, firstLeaf));
            AddComponent(new Line(mid, midLeaf));
            AddComponent(new Line(mid, lastLeaf));




        }

    }
    public class EgyptianKingsTree : CompositeShape
    {



        public EgyptianKingsTree(Point midLeft, Point midRight, Point bottom, int leafHeight, int leafWidth)
        { 
            



            AddComponent(new EgyptianKingsTreePartSymmetric(bottom,midRight,leafHeight,leafWidth));
            AddComponent(new EgyptianKingsTreePartSymmetric(bottom, midLeft, leafHeight, leafWidth));
        



        }

    }





    public class ArabBeduinHouse : CompositeShape
    {



        public ArabBeduinHouse(Point topLeft, Point bottomleft, Point bottomMid, Point bottomRight,Point topRight)
        {



            AddComponent(new Triangle1(topLeft, bottomleft, bottomMid));
            AddComponent(new Rectangle1(topLeft,topRight,bottomMid, bottomRight));


        }

    }
    public class InuitHuntersHouse : CompositeShape
    {



        public InuitHuntersHouse(Point topLeft, Point bottomleft, Point bottomMid, Point bottomRight, Point topRight)
        {



            AddComponent(new Triangle1(topLeft, bottomleft, bottomMid));
            AddComponent(new Rectangle1(topLeft, topRight, bottomMid, bottomRight));


        }

    }

    public abstract class CompositeShape : IShapes
    {
        private List<IShapes> components;

        protected CompositeShape()
        {
            components = new List<IShapes>();

        }

        protected void AddComponent( IShapes shape)
        {
            components.Add(shape);

        }
        public void Draw(Graphics g)
        {
            foreach (var c in components)
            {
                c.Draw(g);

            }
        }

        public Rectangle1 GetBBox()
        {
            throw new System.NotImplementedException();
        }

       
    }



}
