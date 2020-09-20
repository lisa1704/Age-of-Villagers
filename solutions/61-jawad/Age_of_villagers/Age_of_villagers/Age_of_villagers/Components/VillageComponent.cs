using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_villagers.Shapes;

namespace Age_of_villagers.Components
{
    public abstract class VillageComponent : IShape
    {
        private readonly List<IShape> SComponents;

        public VillageComponent()
        {
            SComponents = new List<IShape>();
        }

        public void AddComp(IShape shape)
        {
            SComponents.Add(shape);
        }
        public void draw(Graphics g, Pen p)
        {
            foreach (var component in SComponents)
                component.draw(g, p);
        }

    }
}
