using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    public interface IShape
    {
        void draw(Graphics graphics, Pen pen);
    }
}
