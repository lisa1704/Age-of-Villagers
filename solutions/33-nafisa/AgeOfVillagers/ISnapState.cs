using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    interface ISnapState
    {
        
        public void setHouseState(Point point);
        public void setTreeState(Point point);
        public void setWsourceState(Point point);
    }
}
