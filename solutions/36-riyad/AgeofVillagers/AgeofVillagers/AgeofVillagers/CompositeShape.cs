using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class CompositeShape : IShapeItem
    {
        private List<IShapeItem> Components;

        public CompositeShape()
        {
            Components = new List<IShapeItem>();
        }

        public void AddComponents(IShapeItem shapeItem)
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
