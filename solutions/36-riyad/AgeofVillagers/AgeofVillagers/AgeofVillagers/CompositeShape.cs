using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class CompositeShape : IShape
    {
        private List<IShape> Components;

        public CompositeShape()
        {
            Components = new List<IShape>();
        }

        public void AddComponents(IShape shapeItem)
        {
            Components.Add(shapeItem);
        }

        public void Paint(Graphics g, Pen p)
        {
            foreach (var component in Components)
                component.Paint(g, p);
        }
    }
}
