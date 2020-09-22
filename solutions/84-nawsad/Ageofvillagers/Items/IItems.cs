using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers.Items
{
    interface IItems
    {
        void Draw(Graphics g, Pen p,int x,int y);

    }
}
