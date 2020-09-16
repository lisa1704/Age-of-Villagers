using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers90
{
    public abstract class CompositeShape : IShapeIItem
    {
        private List<IShapeIItem> ShapeComponents;

        protected CompositeShape()
        {
            ShapeComponents = new List<IShapeIItem>();
        }

        protected void AddComponent(IShapeIItem shape)
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
