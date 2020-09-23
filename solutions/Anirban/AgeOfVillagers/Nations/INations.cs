using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers.Nations
{
    public interface INations
    {
        void Draw_Tree(Graphics g,Point x);
        void Draw_House(Graphics g, Point x);
        void Draw_Water(Graphics g, Point x);

        Color terrain_Color();
    }
}
