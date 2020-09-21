using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Age_of_Villagers
{
    public struct village
    {
        public string name;
        public List<Point> tree_points;
        public List<Point> house_points;
        public List<Point> river_points;

        public bool Equals(village villa)
        {
            return name == villa.name &&
                tree_points.SequenceEqual(villa.tree_points) && 
                house_points.SequenceEqual(villa.house_points) && 
                river_points.SequenceEqual(villa.house_points);
        }
    };
}
