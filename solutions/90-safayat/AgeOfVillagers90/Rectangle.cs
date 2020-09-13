using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    class Rectangle : IShapeIItem
    {
        private readonly Point TopLeft;
        private readonly Point BottomRight;
        public Rectangle(Point topLeft, Point BottomRight)
        {
            TopLeft = topLeft;
            BottomRight = BottomRight;
        }

       
        public void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
