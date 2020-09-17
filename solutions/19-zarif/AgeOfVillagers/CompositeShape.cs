using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public abstract class CompositeShape : IGraphicShape
    {
        private List<IGraphicShape> shapes = new List<IGraphicShape>();

        public void addShape(IGraphicShape shape)
        {
            shapes.Add(shape);
        }
      
            public void draw(Graphics g, Pen pen)
            {
            foreach(var _comp in shapes)
            {
                _comp.draw(g, pen);
            }
        }
    }
}
