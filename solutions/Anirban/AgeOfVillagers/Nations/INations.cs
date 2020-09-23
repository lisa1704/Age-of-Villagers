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
        void Draw_Tree(Point x);
        void Draw_House(Point x);
        void Draw_Water(Point x);

        Color terrain_Color();
    }
}
