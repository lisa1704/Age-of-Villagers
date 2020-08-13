using System.Collections.Generic;
using System.Drawing;

namespace Age_Of_Villagers
{
    public abstract class CompositeShape : IShapes
    {
        private List<IShapes> components;

        protected CompositeShape()
        {
            components = new List<IShapes>();

        }

        protected void AddComponent( IShapes shape)
        {
            components.Add(shape);

        }
        public void Draw(Graphics g)
        {
            foreach (var c in components)
            {
                c.Draw(g);

            }
        }

        public Rectangle GetBBox()
        {
            throw new System.NotImplementedException();
        }

       
    }



}
