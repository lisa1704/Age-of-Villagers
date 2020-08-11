using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public abstract class Nation
    {
        public int house_width ;
        public int house_height;
        public int tree_width;
        public  int tree_height;
        Pen pen;

        public Nation()
        {
            this.house_width = 16;
            this.house_height = 16;
            this.tree_height = 24;
            this.tree_width = 16;
            this.pen = new Pen(Color.Black);
        }
        public abstract void DrawTree(Graphics g,int x,int y);
       public abstract void DrawHouse(Graphics g,int x,int y);
       public abstract void DrawWaterSource(Graphics g,int x, int y);
       public abstract Color SetBackground();
        public abstract Size SetWaterSourceSize(int width, int height);
  

      







    }
}
