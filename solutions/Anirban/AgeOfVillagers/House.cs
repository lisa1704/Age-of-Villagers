using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    abstract class House : IVillage_items
    {
        int height = 16;
        int widtth = 16;
        public abstract void createHouse();

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
