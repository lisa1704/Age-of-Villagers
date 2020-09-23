using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.ArabBedouin;

namespace Age_of_Villagers.Age_of_Villagers
{
    public interface INation
    {
        IShape DrawTree(Graphics g, Point point);
        IShape DrawHouse(Graphics g, Point point);
        IShape DrawWaterSource(Graphics g, Point point);
        Color BackgroundColor();
    }


}
