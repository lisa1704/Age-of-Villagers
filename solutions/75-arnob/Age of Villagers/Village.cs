using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class Village
    {
        internal static string Text;
        public string village;
        public List<Point> house_point;
        public List<Point> tree_point;
        public List<Point> water_point;
        public Village(string village, List<Point> house_point,
            List<Point> tree_point, List<Point> water_point)
        {
            this.village = village;
            this.house_point = house_point;
            this.tree_point = tree_point;
            this.water_point = water_point;
        }
    }
}

