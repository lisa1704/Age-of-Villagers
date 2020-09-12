using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class WaterSource : IHouse
    {
        public int x, y;
        public WaterSource(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public int getX()
        {
            return y;
        }

        public int getY()
        {
            return x;
        }

        public void setLocation()
        {
            throw new NotImplementedException();
        }
    }
}
