using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class EgyptWater : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Circle circle = new Circle(g, pen, point, 50, 50, 0, 360);
            circle.DrawShape();
        }
    }
}
