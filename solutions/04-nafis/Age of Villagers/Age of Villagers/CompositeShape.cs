using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    public abstract class CompositeShape : IShape
    {
        private List<IShape> ShapeStack = new List<IShape>();

        public void ShapePush(IShape shape)
        {
            ShapeStack.Add(shape);
        }
        public void draw(Graphics graphics, Pen pen)
        {
            foreach( var shape in ShapeStack)
            {
                shape.draw(graphics, pen);
            }
        }
    }
}
