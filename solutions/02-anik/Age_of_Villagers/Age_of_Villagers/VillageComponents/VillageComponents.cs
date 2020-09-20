using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.VillageComponents
{
    
       
        public abstract class VillageComponents : IShape
        {
            private readonly List<IShape> Components;
            public VillageComponents()
            {
            Components = new List<IShape>();
            }
            public void Draw(Graphics g, Pen p)
            {
                foreach (IShape Component in Components )
                {
                    Component.Draw(g, p);
                }
            }

        }
    }

