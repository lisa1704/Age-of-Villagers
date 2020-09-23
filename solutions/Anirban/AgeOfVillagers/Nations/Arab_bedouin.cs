using System;
using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers.Nations
{
    class Arab_bedouin : INations
    {


        Color bg_color = Color.Orange;
        public void Draw_House(Graphics g, Point x)
        {
            throw new NotImplementedException();
        }

        public void Draw_Tree(Graphics g, Point x)
        {
            throw new NotImplementedException();
        }

        public void Draw_Water(Graphics g, Point x)
        {
            throw new NotImplementedException();
        }

        public Color terrain_Color()
        {
            return bg_color;
        }

    }
}
