using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shapes
{
    public interface IShape
    {
        void draw(Graphics g, Pen p);
    }
}
