using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_villagers.Shape;

namespace Age_of_villagers.Components
{
    public abstract class VillageComponent : IShape
    {
        private readonly List<IShape> S_Components;

        public VillageComponent()
        {
            S_Components = new List<IShape>();
        }

        public void AddComp(IShape shape)
        {
            S_Components.Add(shape);
        }
        public void draw(Graphics g, Pen p)
        {
            foreach (var component in S_Components)
                component.draw(g, p);
        }

    }
}
