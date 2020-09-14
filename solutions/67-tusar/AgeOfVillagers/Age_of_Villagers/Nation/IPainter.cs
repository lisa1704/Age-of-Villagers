using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    interface IPainter
    {
        void drawHouse(Axes axes);
        void drawTree(Axes axes);
        void drawWaterSource(Axes axes);
        void paintTerrain();
    }
}
