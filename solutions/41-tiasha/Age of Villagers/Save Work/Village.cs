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
        public string villageName;
        public List<Point> housePosition, treePosition, waterSourcePosition;

        public Village()
        {
            housePosition = new List<Point>();
            treePosition = new List<Point>();
            waterSourcePosition = new List<Point>();
        }

        public string getName()
        {
            return villageName;
        }

        public void setName(string name)
        {
            villageName = name;
        }
    }
}
