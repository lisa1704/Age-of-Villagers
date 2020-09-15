using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
       Pen pen = new Pen(Color.Black, 3);


        public IGraphicShape GetHouse()
        {
            return new BdFarmerHouse();
        }

        public IGraphicShape GetTrees()
        {
            throw new NotImplementedException();
        }

        public IGraphicShape GetWaterSources()
        {
            throw new NotImplementedException();
        }

    }
}
