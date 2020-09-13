using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class Shape : IShape
    {
        private readonly List<IShape> components;
        
        protected Shape()
        {
            components = new List<IShape>();
        }

        protected void AddComponent(IShape shape)
        {
            components.Add(shape);
        }

        public void Draw(Graphics g, Pen p)
        {
            foreach (IShape item in components)
            {
                item.Draw(g, p);
            }
        }
    }
}
