using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    public class BdHouse : VillageItem
    {
        private readonly Point _clicked;

        public BdHouse(Point clicked)
        {
            _clicked = clicked;
            villageItemShape = new BdHouseShape(new Point(_clicked.X,_clicked.Y),new Point(_clicked.X - 8, _clicked.Y + 8), new Point(_clicked.X + 8, _clicked.Y + 8), new Point(_clicked.X - 8, _clicked.Y), new Point(_clicked.X + 8, _clicked.Y + 16));
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
