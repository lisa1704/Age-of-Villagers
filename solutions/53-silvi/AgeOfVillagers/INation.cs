using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public interface INation
    {
        IShape DrawTree(Point point);
        IShape DrawHouse(Point point);
        IShape DrawWaterSource(Point point);
        Color BackgroundColor();
    }
}
