using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    interface INation
    {

        void set_villagename(string name);
        void set_pen(Pen pen);
        void set_graphics(Graphics g);
        void draw_tree(Point p);
        void draw_house(Point p);
        void draw_river(Point P);
    }
    
}
