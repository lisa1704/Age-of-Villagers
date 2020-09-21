using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface INation
    {
        void DrawTree(Graphics graphics, Point point);
        void DrawHouse(Graphics graphics, Point point);
        void DrawWaterSource(Graphics graphics, Point point);
        void SetVillageName(string vName);
        void SetWaterSource();
        Color SetTerrain();
        
    }

    
}
