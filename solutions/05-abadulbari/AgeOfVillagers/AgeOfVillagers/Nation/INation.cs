using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Nation
{
    public interface INation
    {
        string getNationName();
        Color getTerrainColor();
        IShape getHouse(Point p);
    }
}
