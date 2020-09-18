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
    public class ArabHouse : House
    {
        public ArabHouse(Point point) : base(point)
        {
        }

        public override CompositeShape getItemShape(Point point)
        {
            return new ArabHouseShape(point);
        }
    }

    public class BangladeshiHouse : House
    {
        public BangladeshiHouse(Point point) : base(point)
        {
        }

        public override CompositeShape getItemShape(Point point)
        {
            return new BangladeshiHouseShape(point);
        }
    }

    public class EgyptianHouse : House
    {
        public EgyptianHouse(Point point) : base(point)
        {
        }

        public override CompositeShape getItemShape(Point point)
        {
            return new EgyptianHouseShape(point);
        }
    }

    public class InuitHuntersHouse : House
    {
        public InuitHuntersHouse(Point point) : base(point)
        {
        }

        public override CompositeShape getItemShape(Point point)
        {
            return new InuitHuntersHouseShape(point);
        }
    }

    
    


}
