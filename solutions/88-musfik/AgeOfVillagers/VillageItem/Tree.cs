﻿using AgeOfVillagers.Shape.CompositeShapes;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Tree : IVillageItem
    {
        private readonly Point point;
        public Tree(Point point)
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

    public class ArabTree : Tree
    {
        public ArabTree(Point point) : base(point)
        {
        }

        public override IShape getItemShape(Point point)
        {
            return new ArabTreeShape(point);
        }
    }

    public class BangladeshiTree : Tree
    {
        public BangladeshiTree(Point point) : base(point)
        {
        }

        public override IShape getItemShape(Point point)
        {
            return new BangladeshiTreeShape(point);
        }
    }

    public class EgyptianTree : Tree
    {
        public EgyptianTree(Point point) : base(point)
        {
        }

        public override IShape getItemShape(Point point)
        {
            return new EgyptianTreeShape(point);
        }
    }
    
    public class NoTree : Tree
    {
        public NoTree(Point point) : base(point)
        {
        }

        public override IShape getItemShape(Point point)
        {
            return new NoShape();
        }
    }

}