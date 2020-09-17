using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public interface INation
    {
        IShape DrawHouse();
        IShape DrawTree();
        IShape DrawWaterSource();

    }
}
