using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    interface INation
    {
        void DrawTree();
        void DrawHouse();
        void DrawWaterSource();
        void SetWaterSource();
        void SetTerrain();
    }
}
