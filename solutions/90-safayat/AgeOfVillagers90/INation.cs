using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    interface INation
    {
        void DrawHouse(Graphics g,Point pt);

        void DrawTree(Graphics g, Point pt);

        void DrawWaterSource(Graphics g, Point pt);

    }
}
