using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    class BangladeshiTree : IVillageItem
    {
    public void Draw(Point e, Graphics g, Pen p)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x - 3, y, x + 3, y);
            g.DrawLine(p, x + 3, y, x + 3, y + 50);
            g.DrawLine(p, x + 3, y + 50, x - 3, y + 50);
            g.DrawLine(p, x - 3, y, x - 3, y + 50);
            g.DrawArc(p, x - 40, y - 50, 80, 80, 0, 360);
        }
    }
    
}