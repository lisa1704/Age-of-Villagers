using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public abstract class CompositeShaping : IShape
    {
        private List<IShape> _components;

        protected CompositeShaping()
        {
            _components = new List<IShape>();
        }

        protected void AddComponent(IShape shape)
        {
            _components.Add(shape);
        }
        public void Paint(Graphics graphics)
        {
            foreach (var component in _components)
            {
                component.Paint(graphics);
            }
        }
    }
}
