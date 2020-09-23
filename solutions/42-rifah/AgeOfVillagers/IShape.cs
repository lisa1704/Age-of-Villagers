using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public interface IShape
    {
        void Draw(Pen p, Graphics g);
    }
}
