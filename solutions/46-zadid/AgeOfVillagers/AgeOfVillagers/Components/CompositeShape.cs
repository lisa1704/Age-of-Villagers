using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers.Components
{
    public class CompositeShape:IComponent
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
    }
}
