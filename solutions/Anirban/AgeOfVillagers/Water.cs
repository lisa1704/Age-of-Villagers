using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    abstract class Water : IVillage_items
    {
        string water_type;

        int height = 12;
        int width = 12;

        public abstract void Draw_water();

        public int grid_height()
        {
            throw new NotImplementedException();
        }

        public int grid_width()
        {
            throw new NotImplementedException();
        }
    }
}
