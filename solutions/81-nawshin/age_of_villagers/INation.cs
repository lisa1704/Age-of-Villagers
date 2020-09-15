using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    public interface INation
    {
        void draw_house(Graphics g,Point pt);
    
        void draw_tree(Graphics g, Point pt);
       
        void draw_watersource(Graphics g, Point pt);

        // void paint_terrian(Panel p);
        //void ClearColor(PaintEventArgs e);
        //void BackColor();

        Color BackColor();
        
    }
}
