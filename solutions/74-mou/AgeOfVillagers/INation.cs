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
        void draw_house(Point p);
        void draw_tree(Point p);
        void draw_watersource(Point p);
    }
}
