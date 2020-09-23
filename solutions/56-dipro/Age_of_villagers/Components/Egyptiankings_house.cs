using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Age_of_villagers.Shape;


namespace Age_of_villagers.Components
{
    class Egyptiankings_house : VillageComponent
    {
        private readonly Point top, mid_Left, mid_Right, bottom_Left, bottom_Right;

        public Egyptiankings_house (Point point)
        {
            top = point;
            mid_Left = new Point(top.X - 10, top.Y + 20);
            mid_Right = new Point(top.X + 10, top.Y + 20);
            bottom_Left = new Point(top.X - 10, top.Y + 40);
            bottom_Right = new Point(top.X + 10, top.Y + 40);
      
        }
    }
}
