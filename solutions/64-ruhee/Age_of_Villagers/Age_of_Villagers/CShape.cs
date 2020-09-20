using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Age_of_Villagers
{
    public abstract class CShape : IShape
    {
        protected List<IShape> My_components = new List<IShape>();

        protected void AddComponent(IShape shape)
        {
            My_components.Add(shape);
        }
        public void Draw(Graphics g)
        {
            foreach (var component in My_components)
            {
                component.Draw(g);
            }
        }

    }
}
