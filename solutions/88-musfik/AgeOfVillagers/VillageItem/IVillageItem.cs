using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    interface IVillageItem
    {
        Point getItemLocation();
        CompositeShape getItemShape(Point point);
    }

    public abstract class House : IVillageItem
    {
        private readonly Point point;
        protected House(Point point)
        {
            this.point = point;
            getItemShape(point);
        }
        public Point getItemLocation()
        {
            return point;
        }
        public abstract CompositeShape getItemShape(Point point);
    }

}
