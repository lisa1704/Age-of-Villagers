using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.shape
{
    interface Ishape
    {
        void Draw(Graphics g, int x, int y, int height, int width);

    }
}
