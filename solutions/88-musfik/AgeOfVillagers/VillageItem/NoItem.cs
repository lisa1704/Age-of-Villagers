using AgeOfVillagers.Shape.CompositeShapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.VillageItem
{
    public class NoItem : IVillageItem
    {
        public int getHeight() => 0;
        public int getWidth() => 0;
        public IShape getItemShape(Point point) => new NoShape();

    }
}
