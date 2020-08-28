using System;
using System.Collections.Generic;
using System.Drawing;

using System.Linq;
using System.Text;



namespace Age_Of_Villagers
{
     public class Village
    {
        public string villageName;
        
     
        public List<Point> housePosition,waterSoucePosition;
        public List<Point> treePosition;
        public Village()
        {
            housePosition = new List<Point>();
            treePosition = new List<Point>();
            waterSoucePosition = new List<Point>();
        }


        public string VillageName { get => villageName; set => villageName = value; }

       
       

    }
}
