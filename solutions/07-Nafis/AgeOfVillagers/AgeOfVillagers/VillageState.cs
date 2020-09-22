using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class VillageState
    {
        
        public string Name { get; set; }
        public string nation { get; set; }
        public List<Point> H_locations { get; set; }
        public List<Point> T_locations { get; set; }
        public List<Point> W_locations { get; set; }

        
    }
}
