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
        public abstract void DrawTree(Graphics g,int x,int y);
       public abstract void DrawHouse(Graphics g,int x,int y);
       public abstract void DrawWaterSource(Graphics g,int x, int y);
       public abstract Color SetBackground();
        public abstract Size SetWaterSourceSize(int width, int height);
  

      







    }
}
