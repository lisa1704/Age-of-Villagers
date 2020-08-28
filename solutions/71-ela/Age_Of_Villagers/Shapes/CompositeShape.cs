using System.Collections.Generic;
using System.Drawing;

namespace Age_Of_Villagers
{
    public abstract class CompositeShape : IShapes
    {
        private List<IShapes> components;

        protected CompositeShape()
        {
            components = new List<IShapes>();

        }

        protected void AddComponent(IShapes shape)
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

        public Rectangle GetBBox()
        {
            Rectangle r;
            Point topLeft = new Point(99999, 99999);
            Point topRight = new Point(-999999, 99999);
            Point bottomLeft = new Point(999999, -999999);
            Point bottomRight = new Point(-999999, -999999);


            foreach (var c in components)
            {
                r = c.GetBBox();

                if (r.topLeft.X < topLeft.X)
                {
                    topLeft.X = r.topLeft.X;
                    bottomLeft.X = r.topLeft.X;
                }
                if (r.topRight.X > topRight.X)
                {
                    topRight.X = r.topRight.X;
                    bottomRight.X = r.topRight.X;
                }

                if (r.topLeft.Y < topLeft.Y)
                {
                    topLeft.Y = r.topLeft.Y;
                    topRight.Y = r.topLeft.Y;


                }
                if (r.bottomLeft.Y > bottomLeft.Y)
                {
                    bottomLeft.Y = r.bottomLeft.Y;
                    bottomRight.Y = r.bottomLeft.Y;
                }



            }
            Rectangle bbox = new Rectangle(topLeft, topRight, bottomLeft, bottomRight);

            return bbox;


        }


    }



}
