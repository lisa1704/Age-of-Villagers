using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class CompositeShape : IShape
    {
        protected List<IShape> components = new List<IShape>();
        protected void AddComponent(IShape shape)
        {
            components.Add(shape);
        }
        public void Draw(Graphics graphics, Pen pen)
        {
            foreach(var c in components)
            {
                c.Draw(graphics, pen);
            }
        }
    }
}
