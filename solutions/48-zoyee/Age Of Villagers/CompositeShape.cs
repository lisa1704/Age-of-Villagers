using System.Collections.Generic;
using System.Drawing;

namespace Age_Of_Villagers
{
    public abstract class CompositeShape : IShape
    {
        protected List<IShape> ShapeComponents = new List<IShape>();


        protected void AddComponent(IShape shape)
        {
            ShapeComponents.Add(shape);
        }

        public void Draw(Graphics g)
        {
            foreach (var component in ShapeComponents)
            {
                component.Draw(g);
            }
        }

    }
}