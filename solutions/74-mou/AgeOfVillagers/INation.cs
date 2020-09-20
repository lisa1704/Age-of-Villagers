using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface INation
    {
        void SetGraphics(Graphics gr);
        void SetPen(Pen pen);
        void SetVillagename(string vname);
        string GetVillagename();
        IShapes DrawTree(Point p);
        IShapes DrawHouse(Point p);
        IShapes DrawWaterSource(Point p);
    }
}
