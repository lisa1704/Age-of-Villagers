﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Bangladeshi_Farmer
{
    class BDfarmer_Tree
    {
        public BDfarmer_Tree(Point point, Point point1, Point point2)
        {
    }

        public BDfarmer_Tree(Point mainPoint, Point bottomRight, Point topPoint, Point topLeft)
        {
            AddComponent(new Rectangle(topLeft, bottomRight));
            AddComponent(new EllipseShape(mainPoint, topPoint));
        }
    }
