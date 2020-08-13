using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public abstract class Nation
    {
        public ItemSize houseSize, treeSize;
       
        Pen pen;

        public Nation()
        {
            this.houseSize = new ItemSize(16,16);
            this.treeSize = new ItemSize(16,24);
            this.pen = new Pen(Color.Black);
        }
        public abstract void DrawTree(Graphics g,Point location);
       public abstract void DrawHouse(Graphics g,Point location);
       public abstract void DrawWaterSource(Graphics g,Point location);
       public abstract void SetBackground(Graphics);
       
  

      







    }
}
