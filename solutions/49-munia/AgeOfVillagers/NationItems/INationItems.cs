using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.NationItems
{
    interface INationItems
    {
        void House(Graphics g, Point p);
        void Tree(Graphics g, Point p);
        void Water(Graphics g, Point p);
    }
}
