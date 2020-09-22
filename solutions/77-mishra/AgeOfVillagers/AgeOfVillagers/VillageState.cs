using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class VillageState 
    {
        private string villageName;
       
        public List<Point> houseLoc;
        public List<Point> treeLoc;
        public List<Point> waterLoc;

        public VillageState(String villageName,  List<Point> houseLoc, List<Point> treeLoc, List<Point> waterLoc)
        {
            this.villageName = villageName;
            this.houseLoc = houseLoc;
            this.treeLoc = treeLoc;
            this.waterLoc = waterLoc;
        }
        
    }
}
