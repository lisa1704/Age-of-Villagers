using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class VillageState 
    {
        private string villageName;
       
        private List<Point> houseLoc;
        private List<Point> treeLoc;
        private List<Point> waterLoc;

        public VillageState(String villageName,  List<Point> houseLoc, List<Point> treeLoc, List<Point> waterLoc)
        {
            this.villageName = villageName;
            this.houseLoc = houseLoc;
            this.treeLoc = treeLoc;
            this.waterLoc = waterLoc;
        }
        
    }
}
