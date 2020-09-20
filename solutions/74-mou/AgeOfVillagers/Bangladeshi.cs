using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Bangladeshi : INation
    {
        private string vname;
        private Graphics gr;
        private Pen pen;

        public void SetGraphics(Graphics gr)
        {
            this.gr = gr;
        }
        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }
        public void SetVillagename(string vname)
        {
            this.vname = vname;
        }
        public string GetVillagename()
        {
            return vname;
        }
        public IShapes DrawHouse(Point p)
        {
            return new BangladeshiHouse(p);
        }
        public IShapes DrawTree(Point p)
        {
            return new BangladeshiTree(p);

        }

        public IShapes DrawWaterSource(Point p)
        {
            return new BangladeshiWaterSource(p);

        }
    }
}
