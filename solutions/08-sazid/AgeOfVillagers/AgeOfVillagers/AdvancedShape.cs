using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public abstract class AdvancedShape : IShape
    {
        List<IShape> shapeElements;

        public AdvancedShape()
        {
            shapeElements = new List<IShape>();
        }

        public void addShape(IShape shape)
        {
            shapeElements.Add(shape);
        }
        public void draw(Graphics g)
        {
            foreach(var shapes in shapeElements)
            {
                shapes.draw(g);
            }
        }
    }
}
