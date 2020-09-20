using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    public interface INations
    {
        void Draw_Tree();
        void Draw_House();
        void Draw_Water();

        void terrain_Color();
    }
}
