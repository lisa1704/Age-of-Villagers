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
        public Nation()
        {
            this.house_width = 50;
            this.house_height = 50;
            this.tree_height = 24;
            this.tree_width = 16;
        }
        public abstract void DrawTree(Graphics g,int x,int y);
       public abstract void DrawHouse(Graphics g,int x,int y);
       public abstract void DrawWaterSource(Graphics g);
       public abstract void SetBackground(Graphics g);
       public abstract void SetWaterSource();
       public abstract string getNationName();

      







    }
}
