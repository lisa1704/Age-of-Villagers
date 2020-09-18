using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Composite : IShape
    {
        protected List<IShape> My_components = new List<IShape>();

        protected void AddComponent(IShape myshape)
        {
            My_components.Add(myshape);
        }
        public void Draw(Graphics g)
        {
            foreach (var c in My_components)
            {
                c.Draw(g);
            }
        }
    }
}
