﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Tree : IElement
    {
        public int x, y;

        public Tree(int x, int y)
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
