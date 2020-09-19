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
        void Draw_House(Graphics g, int x, int y);
        void Draw_Tree(Graphics g, int x, int y);
        void Draw_WaterSource(Graphics g, int x, int y);
        void Paint_Terrain();
    }
}



