using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Village
    {
        public string village;
        public List<Point> treePoints;
        public List<Point> housePoints;
        public List<Point> riverPoints;
        public Village(string village, List<Point> tree, List<Point> house, List<Point> river)
        {
            this.village = village;
            this.treePoints = tree;
            this.housePoints = house;
            this.riverPoints = river;
        }
    }
}
