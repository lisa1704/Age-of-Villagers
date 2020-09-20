using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        string DrawHouse(Graphics g, Point point);
        string DrawTree(Graphics g, Point point);
        string DrawWaterSource(Graphics g, Point point);
        Color DrawTerrain();
    }
}
