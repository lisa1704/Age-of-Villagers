﻿using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class House : IVillageItem
    {
        private int height = 16;
        private int width = 16;
        
        public int getHeight() => height;
        public int getWidth() => width;
        public virtual IShape getItemShape(Point point) => new NullShape(point);
    }


    public class ArabHouse : House
    {
        public override IShape getItemShape(Point point) => new ArabHouseShape(point);
    }

    public class BangladeshiHouse : House
    {
        public override IShape getItemShape(Point point) => new BangladeshiHouseShape(point);
    }

    public class EgyptianHouse : House
    {
        public override IShape getItemShape(Point point) => new EgyptianHouseShape(point);
    }

    public class InuitHuntersHouse : House
    {
        public override IShape getItemShape(Point point) => new InuitHuntersHouseShape(point);
    }

}
