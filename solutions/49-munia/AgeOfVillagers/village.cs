using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers 
{
    class Village : INation
    {
   
        private String villageName;
    
      public Village(String name)
        {
            villageName = name;
            
        }
        public void DrawHouse()
        {
            throw new NotImplementedException();
        }

        public void DrawTree()
        {
            throw new NotImplementedException();
        }

        public void drawWater()
        {
            throw new NotImplementedException();
        }

        public void terrainColor()
        {
            throw new NotImplementedException();
        }
    }
}
