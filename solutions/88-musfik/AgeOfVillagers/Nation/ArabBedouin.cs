using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabBedouin : INation
    {
        private readonly Color color;
        private readonly String nation_name;

        public ArabBedouin()
        {
            color = Color.LightYellow;
            nation_name = "Arab Bedouin";
        }

        public object getHouse(Point point)
        {
            return new ArabBedouinHouse(point);
        }

        public string getNationName()
        {
            return nation_name;
        }

        public Color getTerrainColor()
        {
            return color;
        }

        public object getTree(Point point)
        {
            return new ArabBedouinTree(point);
        }

        public object getWaterResource(Point point)
        {
            return new NullShape(point);
        }
    }
}
