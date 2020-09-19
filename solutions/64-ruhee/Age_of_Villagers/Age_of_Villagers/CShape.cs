using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Age_of_Villagers
{
    class CShape : IShape
    {
        protected List<IShape> My_components = new List<IShape>();

        protected void AddComponent(IShape myshape)
        {
            My_components.Add(myshape);
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
