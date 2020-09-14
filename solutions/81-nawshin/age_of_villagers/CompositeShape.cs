using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public abstract class CompositeShape : IShape
    {
        private List<IShape> components;

        protected CompositeShape()
        {
            components = new List<IShape>();
        }

        public void AddComponent(IShape shape)
        {
            components.Add(shape);
        }

        public void draw(Graphics g)
        {
            foreach(var component in components)
            {
                component.draw(g);
            }
        }
    }

}
