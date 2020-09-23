using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class Inuit_hunters : INations
    {

        Color bg_color = Color.White;
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
