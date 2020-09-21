using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class CompositeShape : IComponent
    {
        public List<IComponent> components;

        public CompositeShape()
        {
            components = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void Draw(Graphics g)
        {
            foreach (var component in components)
                component.Draw(g);
        }

        public List<IComponent> getComponents()
        {
            return components;
        }
    }
}
