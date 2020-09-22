using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    abstract class Tree : IVillage_items
    {
        int height = 16;
        int widtth = 24;
        public abstract void createTree();

        public int grid_height()
        {
            return height;
        }

        public int grid_width()
        {
            return widtth;
        }
    }
}
