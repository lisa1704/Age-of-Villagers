using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Triangle
    {
        Graphics graphics;
        Pen pen = new Pen(Color.Black);

        public Triangle(Graphics g)
        {
            graphics = g;

        }

        public void Draw()
        {
            graphics.DrawLine(pen, 20, 100, 300, 100);
            graphics.DrawLine(pen, 20, 100, 400, 150);
            graphics.DrawLine(pen, 300, 100, 400, 150);

        }
    }
}
