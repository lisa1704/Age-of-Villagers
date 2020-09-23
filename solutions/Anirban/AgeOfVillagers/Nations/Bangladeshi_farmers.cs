using System;
using System.Collections.Generic;
using System.Drawing;
using AgeOfVillagers.Shapes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class Bangladeshi_farmers : INations
    {

        Color bg_color = Color.Green;

        public void Draw_House(Point e)
        {
            
        }

        public void Draw_Tree(Point e)
        {
            throw new NotImplementedException();
        }

        public void Draw_Water(Point e)
        {
            throw new NotImplementedException();
        }

        public Color terrain_Color()
        {
            return bg_color;
        }
    }
}
