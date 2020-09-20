using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Age_of_Villagers
{
    public interface INation
    {
        void DrawTree(Graphics g, Point point);
        void DrawHouse(Graphics g, Point point);
        void DrawWaterSource(Graphics g, Point point);
        Color BackgroundColor();
    }
}
