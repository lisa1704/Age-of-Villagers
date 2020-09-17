using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
   public interface IGraphicShape
    {
        void draw(Graphics g,Pen pen);
    }
}
