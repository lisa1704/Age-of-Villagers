using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
       Pen pen = new Pen(Color.Black, 3);

        public IGraphicShape GetHouse(Point point)
        {
            throw new NotImplementedException();
        }

        public IGraphicShape GetTrees(Point point)
        {
            throw new NotImplementedException();
        }

        public IGraphicShape GetWaterSources(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
