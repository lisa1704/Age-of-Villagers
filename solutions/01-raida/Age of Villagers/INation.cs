using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public interface INation
    {

        void set_villagename(string name);
        void set_graphics(Graphics g);
        IShape draw_tree(Point p);
        IShape draw_house(Point p);
        void draw_river(Point P);
        string get_villagename();
        List<Point> get_tree();
        List<Point> get_house();
        List<Point> get_river();

        Color set_background();

    }
    
}
