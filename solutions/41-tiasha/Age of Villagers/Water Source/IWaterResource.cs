using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public interface IWaterResource
    {
       void Draw(ElementSize sz, Graphics g, Point p);
    }
}
