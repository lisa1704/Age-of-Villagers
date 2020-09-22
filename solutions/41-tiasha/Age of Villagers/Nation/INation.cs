using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
   public interface INation
    {
       
        void DrawWaterResource(Graphics g, Point location);
        void BackgoundColor(Graphics g);
    }
}
