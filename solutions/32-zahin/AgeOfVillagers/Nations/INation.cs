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
        void DrawHouse(Graphics g, Point point);
        void DrawTree(Graphics g, Point point);
        void DrawWaterSource(Graphics g, Point point);
        Color DrawTerrain();
    }
}
