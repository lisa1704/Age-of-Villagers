using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    abstract class CompoundShape : IDraw
    {
        public List<IDraw> shapes;

        public CompoundShape()
        {
            shapes = new List<IDraw>();
        }

        public void addShape(IDraw shape)
        {
            shapes.Add(shape);
        }
        public void draw(Graphics g)
        {
            foreach(var shape in shapes)
            {
                shape.draw(g);
            }
        }
    }
}
