using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeOfVillagers.Data_Objects;

namespace AgeOfVillagers.Nations
{
    public abstract class Nation : INation
    {
        
        public bool hasTree, hasWaterSource;
        public ElementSize houseSize, treeSize;

        public Nation()
        {
            this.houseSize = new ElementSize(16,16);
            this.treeSize = new ElementSize(24,16);
        }

        public abstract void BackgoundColor(Graphics g);
       
        public abstract void DrawHouse(Graphics g, Point location);

        public abstract void DrawTree(Graphics g, Point location);

        public abstract void DrawWaterResource(Graphics g, Point location);


        
    }
}
