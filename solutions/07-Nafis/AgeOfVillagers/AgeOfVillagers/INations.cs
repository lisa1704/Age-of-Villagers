using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public interface INations
    {
        
        void DrawTree(int x, int y, Graphics g);
        void DrawHouse(int x, int y, Graphics g);
        void DrawWater(int x, int y, Graphics g);
        Color SetColor();

    }
}
