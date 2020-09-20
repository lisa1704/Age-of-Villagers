using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface INation
    {
        void set_graphics(Graphics gr);
        void set_pen(Pen pen);
        void set_villagename(string vname);
        string get_villagename();
        IShapes draw_house(Point p);
        IShapes draw_tree(Point p);
        IShapes draw_watersource(Point p);
    }
}
