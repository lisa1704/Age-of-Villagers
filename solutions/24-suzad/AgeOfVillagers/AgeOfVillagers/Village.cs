using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Village
    {
        public string nation;
        public string village;
        public List<Point> treePoints;
        public List<Point> housePoints;
        public List<Point> riverPoints;
        public Village(string nation, string village, List<Point> tree, List<Point> house, List<Point> river)
        {
            this.nation = nation;
            this.village = village;
            this.treePoints = tree;
            this.housePoints = house;
            this.riverPoints = river;
        }
    }
}
