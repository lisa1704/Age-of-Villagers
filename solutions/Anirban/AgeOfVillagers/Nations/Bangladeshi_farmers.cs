using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class Bangladeshi_farmers : INations
    {

        Color bg_color = Color.Green;

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
