using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    public abstract class Nation : INation
    {
        
        public bool hasTree, hasWaterSource;



        public Nation()
        {
           
        }

        public abstract void DrawHouse(Graphics g, Point location);

        public abstract void DrawTree(Graphics g, Point location);

        public abstract void DrawWaterResource(Graphics g, Point location);


        
    }
}
