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
        void Draw_Tree();
        void Draw_House();
        void Draw_Water();

        Color terrain_Color();
    }
}
