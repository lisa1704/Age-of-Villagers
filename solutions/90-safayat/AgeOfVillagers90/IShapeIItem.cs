using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    public interface IShapeIItem
    {
        void Draw(Graphics g);
    }

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
