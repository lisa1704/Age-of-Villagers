using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public interface INation
    {
        public void SetGraphics(Graphics gr);
        public void SetPen(Pen pen);
        public void SetVillagename(string vname);
        public string GetVillagename();
        public IShapes DrawTree(Point p);
        public IShapes DrawHouse(Point p);
        public IShapes DrawWaterSource(Point p);
    }
}
