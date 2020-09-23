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
        Object DrawTree(Graphics g , Point point);
        Object DrawHouse(Point point);
        Object DrawWaterSource(Point point);
        Color BackgroundColor();
    }
}
