using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    interface INation
    {
        String DrawHouse();
        String DrawTree();
        String DrawWaterSource();
        Color DrawTerrain();

    }
}
