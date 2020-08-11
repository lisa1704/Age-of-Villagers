using System;
using System.Drawing;

namespace Age_Of_Villagers
{
    class Rectangle : IShapes
    {

        public void Draw(Graphics g, int x, int y,  int height, int width, int rotate)
        {
            Pen p = new Pen(Color.Black);


            g.DrawLine(p, x, y, x + width-rotate, y - rotate);
            g.DrawLine(p, x, y, x - rotate , y-height);
            g.DrawLine(p, x - rotate, y - height, x - rotate + width - rotate, y - rotate - height);
            g.DrawLine(p, x - rotate + width - rotate, y - rotate - height, x + width - rotate, y - rotate);



        }
         
        public Rectangle shape()
        {
            throw new NotImplementedException();
        }
    }
}
