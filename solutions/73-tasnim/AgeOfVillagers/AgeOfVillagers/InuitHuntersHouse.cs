using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class InuitHuntersHouse : AbstractShape
    {
        public InuitHuntersHouse(Point Iniatialpoint)
        {
            addShape(new Line((new Point(Iniatialpoint.X + 16, Iniatialpoint.Y + 8)), (new Point(Iniatialpoint.X, Iniatialpoint.Y + 8))));
            addShape(new Arc(Iniatialpoint.X, Iniatialpoint.Y, 16F, 16F, 0, -180.0F));
            addShape(new Arc(Iniatialpoint.X + 4, Iniatialpoint.Y + 4, 8F, 8F, 0, -180.0F));
        }
    }
}
