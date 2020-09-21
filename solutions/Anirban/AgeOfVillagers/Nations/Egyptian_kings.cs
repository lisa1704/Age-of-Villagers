using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class Egyptian_kings : INations
    {

        string nation_type = "E";
        Color bg_color = Color.Yellow;
        public void Draw_House()
        {
            throw new NotImplementedException();
        }

        public void Draw_Tree()
        {
            throw new NotImplementedException();
        }

        public void Draw_Water()
        {
            throw new NotImplementedException();
        }

        public Color terrain_Color()
        {
            return bg_color;
        }
    }
}
