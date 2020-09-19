using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class CompositeShape : IShape
    {
        protected List<IShape> components = new List<IShape>();
        protected void AddComponent(IShape shape)
        {
            components.Add(shape);
        }
        public void Draw(Graphics graphics)
        {
            foreach(var c in components)
            {
                c.Draw(graphics);
            }
        }
    }
}
