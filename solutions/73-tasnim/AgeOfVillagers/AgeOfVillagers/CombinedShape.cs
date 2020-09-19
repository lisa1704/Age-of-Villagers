using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class CombinedShape : IShape
    {
        public List<IShape> shapeCombination;
        public CombinedShape()
        {
            shapeCombination = new List<IShape>();
        }
        public void addShape(IShape shape)
        {
            shapeCombination.Add(shape);
        }
        public void Draw_Shape(Graphics g)
        {
            foreach (var shapes in shapeCombination)
            {
                shapes.Draw_Shape(g);
            }
        }
    }
}
