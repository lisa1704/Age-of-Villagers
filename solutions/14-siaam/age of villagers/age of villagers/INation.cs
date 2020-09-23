using System;
using System.Drawing;


namespace age_of_villagers
{
    public interface INation
    {
        void drawHouse(Graphics g, Point point);
        void drawTree(Graphics g, Point point);
        Color BgColor();
    }
}
