using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class VillageState
    {
        public string name { get; set; }
        public List<Point> h_locations { get; set; }
        public List<Point> t_locations { get; set; }
        public List<Point> w_locations { get; set; }
    }
}
