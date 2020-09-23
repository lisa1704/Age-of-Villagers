using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
   public abstract class CompositeShape : IShape
    {
        private List<IShape> ShapeComponents;

        protected CompositeShape()
        {
            ShapeComponents = new List<IShape>();
        }

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
