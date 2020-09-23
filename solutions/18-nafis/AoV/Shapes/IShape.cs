using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Shapes
{
    public interface IShape
    {
        void Draw(Graphics g, Pen p);
    }
}
