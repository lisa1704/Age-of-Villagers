﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Shapes
{
    public abstract class ComposeShape : IShape
    {
        private List<IShape> shapeComponent;

        public ComposeShape()
        {
            shapeComponent = new List<IShape>();
        }

        public void AddShape(IShape shape)
        {
            shapeComponent.Add(shape);
        }

        public void Draw(Graphics g, Pen p)
        {
            foreach(IShape item in shapeComponent)
            {
                item.Draw(g, p);
            }
        }
    }
}