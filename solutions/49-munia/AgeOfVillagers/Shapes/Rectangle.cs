using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Rectangle
    {
        Graphics graphics;
        Pen pen = new Pen(Color.Black);

        public Rectangle(Graphics g)
        {
            graphics = g;
        }

        public void Draw()
        {
            graphics.DrawLine(pen, 20, 100, 40, 100); //a //b
            graphics.DrawLine(pen, 20, 170, 40, 150); //c //d
            graphics.DrawLine(pen, 20, 100, 20, 170); //a //c
            graphics.DrawLine(pen, 40, 100, 40, 150); //b //d

        }
    }
}
