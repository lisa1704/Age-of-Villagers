using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public interface INation
    {
        void DrawTree(Graphics graphics, Point point);
        void DrawHouse(Graphics graphics, Point point);
        void DrawWaterSource(Graphics graphics, Point point);
        void SetVillageName(string vName);
        string GetVillageName();
        Color SetTerrain();
        
    }

    
}
