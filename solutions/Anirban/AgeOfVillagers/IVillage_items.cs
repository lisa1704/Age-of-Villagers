using System;
using System.Collections.Generic;
using AgeOfVillagers.Shapes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface IVillage_Item
    {
        void Draw_item(Graphics g, Point p);
    }
}
