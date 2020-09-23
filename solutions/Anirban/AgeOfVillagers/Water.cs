using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Water : IVillage_Item
    {
        string water_type;

        int height = 12;
        int width = 12;

        public void Draw_item(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void Draw_water()
        {

        }

        
    }
}
