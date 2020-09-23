using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public interface INation
    {
        void draw_house();
        void draw_tree();
        void draw_watersource();
        void draw_house(Graphics g, Point pt);
    }
}
