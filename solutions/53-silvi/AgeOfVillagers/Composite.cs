using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public abstract class Composite : IShape
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
