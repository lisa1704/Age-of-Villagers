using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public interface INation
    {
        void draw_house(Graphics g,Point pt);
        //string draw_house();
        void draw_tree(Graphics g, Point pt);
        //string draw_tree();
        void draw_watersource(Graphics g, Point pt);
        //string draw_waterSource();
    }
}
