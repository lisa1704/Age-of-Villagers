using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class AbstractShape : IShape
    {
        public List<IShape> combinedShape;
        public AbstractShape()
        {
            combinedShape = new List<IShape>();
        }
        public void addShape(IShape shape)
        {
            combinedShape.Add(shape);
        }
        public void Draw_Shape(Graphics g)
        {
            foreach (var shapes in combinedShape)
            {
                Console.WriteLine("Draw shape working");
                shapes.Draw_Shape(g);
            }
        }
    }
}
