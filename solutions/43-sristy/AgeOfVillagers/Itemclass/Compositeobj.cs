using System.Collections.Generic;
using System.Drawing;

namespace Age_of_villagers
{
    public abstract class Compositeobj: IObject
    {
        private List<IObject> components;
        public Compositeobj()
        {
            components = new List<IObject>();
        }
        public void AddComponent(IObject obj)
        {
            components.Add(obj);
        }

        public void paint(Pen p, Graphics g)
        {
            foreach(var comp in components)
            {
                comp.paint(p,g);
            }
        }
    }
}
