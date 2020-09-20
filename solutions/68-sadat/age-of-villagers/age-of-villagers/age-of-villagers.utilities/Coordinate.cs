using System;
using System.Collections.Generic;
using System.Text;

namespace age_of_villagers.age_of_villagers.utilities
{
    class Coordinate
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; }
        public int Y { get; }
    }
}
