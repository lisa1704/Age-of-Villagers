using System.Collections.Generic;
using System.Drawing;

namespace AOV
{
    public abstract class CompoundShape : IDraw
    {
        public List<IDraw> shapes;
        public CompoundShape()
        {
            shapes = new List<IDraw>();
        }
        public void AddShape(IDraw shape)
        {
            shapes.Add(shape);
        }
        public void Draw(Graphics g)
        {
            foreach(var shape in shapes)
            {
                shape.Draw(g);
            }
        }
    }
}
