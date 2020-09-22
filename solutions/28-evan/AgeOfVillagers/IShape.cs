using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    interface IShape
    {
        void Draw();
        void DrawShape(Graphics g, Pen p);
    }
}
