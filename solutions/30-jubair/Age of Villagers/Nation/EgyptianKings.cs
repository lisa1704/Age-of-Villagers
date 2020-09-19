using Age_of_Villagers.House;
using Age_of_Villagers.Tree;
using Age_of_Villagers.Water_Resource;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    public class EgyptianKings : INation
    {

        string name;

        public EgyptianKings(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }

        public Color getTerrainColor()
        {

            return Color.Yellow;
        }

        public void GetHouse(Graphics graphics, Point _point)
        {

            EgyptianHouse egyptian_house = new EgyptianHouse(new Point(_point.X-8, _point.Y+40), new Point(_point.X - 20, _point.Y+30), new Point(_point.X-2  , _point.Y-10 ), new Point(_point.X + 8, _point.Y+24));
            egyptian_house.Paint(graphics);
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            EgyptianTree egyptian_tree = new EgyptianTree(new Point(_point.X, _point.Y), new Point(_point.X-4, _point.Y-8), new Point(_point.X+4, _point.Y-8), new Point(_point.X-9, _point.Y-15), new Point(_point.X+7, _point.Y-17), new Point(_point.X-13, _point.Y-12), new Point(_point.X-5, _point.Y-17), new Point(_point.X+2, _point.Y-16), new Point(_point.X+13, _point.Y-16));
            egyptian_tree.Paint(graphics);
        }

        public void GetWaterResource(Graphics graphics, Point _point)
        {
           EgyptianWell egyptian_well = new EgyptianWell(new Point(_point.X, _point.Y), new Point(_point.X+12, _point.Y+12));
           egyptian_well.Paint(graphics);
        }
    }
 }

