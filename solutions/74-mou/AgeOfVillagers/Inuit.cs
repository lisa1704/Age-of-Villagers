using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Inuit : INation
    {
        private string vname;
        private Graphics gr;
        private Pen pen;
        void SetGraphics(Graphics gr)
        {
            this.gr = gr;
        }
        void SetPen(Pen pen)
        {
            this.pen = pen;
        }
        void SetVillagename(string vname)
        {
            this.vname = vname;
        }
        string GetVillagename()
        {
            return vname;
        }
        IShapes DrawHouse(Point p)
        {
            
        }
        IShapes DrawTree(Point p)
        {
            

        }

        IShapes DrawWaterSource(Point p)
        {

        }
    }
}
