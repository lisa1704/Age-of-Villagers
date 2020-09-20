using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public interface IVillageState
    {
        public void setHouseState(Point p);
        public void setTreeState(Point p);
        public void setwaterState(Point p);

    }
}
