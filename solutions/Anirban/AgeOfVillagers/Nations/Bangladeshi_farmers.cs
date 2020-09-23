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

        public void Draw_House(Graphics g, Point e)
        {
            BDF_House _House = new BDF_House();
            _House.Draw_item(g, e);
        }

        public void Draw_Tree(Graphics g, Point e)
        {
            BDF_Tree _Tree = new BDF_Tree();
            _Tree.Draw_item(g, e);
        }

        public void Draw_Water(Graphics g, Point e)
        {
            throw new NotImplementedException();
        }

        public Color terrain_Color()
        {
            return bg_color;
        }
    }
}
