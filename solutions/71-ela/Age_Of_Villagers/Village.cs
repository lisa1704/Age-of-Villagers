using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;



namespace Age_Of_Villagers
{
    class Village
    {
        string villageName;
        INations nation;
        public List<Point> housePosition;
        public List<Point> treePosition;
        public Village()
        {
            housePosition = new List<Point>();
            treePosition = new List<Point>();
        }


        public string VillageName { get => villageName; set => villageName = value; }

       
        internal INations Nation { get => nation; set => nation = value; }
    }

    public class Point
    {
        public int x, y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;


        }
       
    }
}
