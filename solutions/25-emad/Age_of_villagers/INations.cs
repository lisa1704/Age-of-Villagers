using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Age_of_villagers
{
    public interface INations
    {
        String DrawTree(Graphics graphics, Point point);
        String DrawHouse(Graphics graphics, Point point);
        String DrawWaterSource(Graphics graphics, Point point);
        Color DrawBackground();

    }
}
