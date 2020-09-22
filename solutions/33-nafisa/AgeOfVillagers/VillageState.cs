using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public struct VillageState  
    {
        public String villagename;
        public String nationname;
        public List<Point> Houses;
        public List<Point> Trees;
        public List<Point> Watersources;

    }
}
