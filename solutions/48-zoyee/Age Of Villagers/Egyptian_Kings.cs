using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class Egyptian_Kings : INation
    {
        Pen p = new Pen(Color.Purple);

        public Color BackGroundColor()
        {
            return Color.Yellow;
        }

        public void Draw_House(Graphics g, Point point)
        {
            EgyptianKings_House ek_h = new EgyptianKings_House(point);
            ek_h.Draw(g);
        }

        public void Draw_Tree(Graphics g, Point point)
        {
            EgyptianKings_Tree ek_t = new EgyptianKings_Tree(point);
            ek_t.Draw(g);
        }

        public void Draw_WaterSource(Graphics g, Point point)
        {
            EgyptianKings_WaterSource ek_ws = new EgyptianKings_WaterSource(point);
            ek_ws.Draw(g);
        }
    }
}