using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface IShape
    {
        void draw(Graphics g);
    }
    public class line : IShape

    {
        private readonly Point point1;
        private readonly Point point2;
        public line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;

        }
        public void draw(Graphics g)

        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, point1, point2);
         
        }
    




    }
}
