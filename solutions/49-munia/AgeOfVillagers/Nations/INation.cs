using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    interface INation
    {
        void DrawHouse(Graphics g, Point p);
        void DrawTree(Graphics g, Point p);
        void drawWater(Graphics g, Point p);
        Color terrainColor();

    }
}
