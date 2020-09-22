﻿using AgeOfVillagers.Shape.CompositeShapes;
using System.Drawing;

namespace AgeOfVillagers
{
    public class WaterResource : IVillageItem
    {
        private readonly Point point;
        public WaterResource(Point point)
        {
            this.point = point;
            getItemShape(point);
        }
        public Point getItemLocation()
        {
            return point;
        }
        public virtual IShape getItemShape(Point point)
        {
            return new NullShape(point);
        }
    }

    public class BangladeshiWaterResource : WaterResource
    {
        public BangladeshiWaterResource(Point point) : base(point)
        {
        }

        public override IShape getItemShape(Point point)
        {
            return new BangladeshiWaterSourceShape(point);
        }
    }

    public class EgyptianWaterResource : WaterResource
    {
        public EgyptianWaterResource(Point point) : base(point)
        {
        }

        public override IShape getItemShape(Point point)
        {
            return new EgyptianWaterSourceShape(point);
        }
    }

    public class NoWaterResource : WaterResource
    {
        public NoWaterResource(Point point) : base(point)
        {
        }

        public override IShape getItemShape(Point point)
        {
            return new NoShape();
        }
    }

}