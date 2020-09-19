using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers
{
    interface INation
    {
        void Draw_House(Graphics g, Point p);
        void Draw_Tree(Graphics g, Point p );
        void Draw_WaterSource(Graphics g, Point p);
        Color GetColor();
    }
}



