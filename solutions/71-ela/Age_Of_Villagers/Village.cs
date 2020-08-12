using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;



namespace Age_Of_Villagers
{
     public class Village
    {
        public string villageName;
     
        public List<Location> housePosition,waterSoucePosition;
        public List<Location> treePosition;
        public Village()
        {
            housePosition = new List<Location>();
            treePosition = new List<Location>();
            waterSoucePosition = new List<Location>();
        }


        public string VillageName { get => villageName; set => villageName = value; }

       
       

    }
}
