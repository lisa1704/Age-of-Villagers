using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Tree : IElement
    {
        private int x, y;

        public Tree(int x, int y)
        {
            this.x = x;
            this.y = y;
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
