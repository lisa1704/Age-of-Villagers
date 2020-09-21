using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers.Items
{
    public interface IItem
    {
        void Draw(Graphics g, Point point);
    }
}
