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

        void set_graphics(Graphics gr)
        {
            this.gr = gr;
        }
        void set_pen(Pen pen)
        {
            this.pen = pen;
        }
        void set_villagename(string vname)
        {
            this.vname = vname;
        }
        string get_villagename()
        {
            return vname;
        }
        IShapes draw_house(Point p)
        {
            
        }
        IShapes draw_tree()
        {

        }
        IShapes draw_watercource()
        {

        }
    }
}
