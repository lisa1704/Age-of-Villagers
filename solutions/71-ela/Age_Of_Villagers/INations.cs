using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    abstract class INations
    {
        public static int house_width =16;
        public static int house_height=16;
        private static int tree_width=16;
        private static int tree_height =24;

        

    


        public abstract void DrawTree(Graphics g,int x,int y);
        public abstract void DrawHouse(Graphics g,int x,int y);
        public abstract void DrawWaterSource(Graphics g);
        public abstract void SetBackground(Graphics g); 
        public abstract void SetWaterSource();

      







    }
}
