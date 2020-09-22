using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    public interface INation
    {
        object DrawHouse(Graphics g,Point pt);

        object DrawTree(Graphics g, Point pt);

        object DrawWaterSource(Graphics g, Point pt);

        Color BackGroundColor();

    }
}
