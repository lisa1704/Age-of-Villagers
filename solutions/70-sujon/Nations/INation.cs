using System;
using System.Collections.Generic;
using System.Text;

namespace AOV.Nations
{
    interface INation
    {
        void Draw_House(Point location, Graphics gfx, Pen p);
        void Draw_Tree(Point location, Graphics gfx, Pen p);
        void Draw_WaterSource(Point location, Graphics gfx, Pen p);

        string Get_inhabitedVillage();

        void Set_inhabitedVillage(string village);

        string Get_NationName();



    }
}
