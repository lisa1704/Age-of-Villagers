using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public interface INation
    {
        String getName();
        Colour getTerrainColour();
        void GetTree(Graphics graphics, Point _point);
        void GetHouse(Graphics graphics, Point _point);
        void GetWaterSource(Graphics graphics, Point _point);
    }
}
