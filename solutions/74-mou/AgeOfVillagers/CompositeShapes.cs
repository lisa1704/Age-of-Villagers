﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class CompositeShapes : IShapes
    {
        protected List<IShapes> listOfShapes;

        public CompositeShapes()
        {
            listOfShapes = new List<IShapes>();

        }

        protected void add_shapes(IShapes shapes)
        {
            listOfShapes.Add(shapes);
        }
        public void DrawShapes(Graphics gr)
        {
            foreach(var sh in listOfShapes)
            {
                sh.DrawShapes(gr);
            }
        }
    }
}
