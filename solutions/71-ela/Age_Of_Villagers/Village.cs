using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;



namespace Age_Of_Villagers
{
    class Village
    {
        public string villageName;
        public string nationName;
        public List<Point> housePosition;
        public List<Point> treePosition;
        public Village()
        {
            housePosition = new List<Point>();
            treePosition = new List<Point>();
        }


        public string VillageName { get => villageName; set => villageName = value; }

       
       
        public string NationName { get => nationName; set => nationName = value; }
    }
}
