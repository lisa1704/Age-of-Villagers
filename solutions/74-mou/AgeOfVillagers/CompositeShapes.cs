using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class CompositeShapes : IShapes
    {
        private List<IShapes> listOfShapes = new List<IShapes>();

        public void add_shapes(IShapes shapes)
        {
            listOfShapes.Add(shapes);
        }
        public void DrawShapes(Graphics gr, Pen pen)
        {
            foreach(var sh in listOfShapes)
            {
                sh.DrawShapes(gr, pen);
            }
        }
    }
}
