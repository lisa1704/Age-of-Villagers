using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    public interface IShapes
    {
        void Draw_shapes(Point pt, Graphics g, Pen p);
    }
}
