using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Shape
{
    public abstract class CompositeShape : IShape
    {
        private  List<IShape> _components ;

        protected CompositeShape()
        {
            _components = new List<IShape>();
        }

       protected void AddComponent(IShape shape )
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
