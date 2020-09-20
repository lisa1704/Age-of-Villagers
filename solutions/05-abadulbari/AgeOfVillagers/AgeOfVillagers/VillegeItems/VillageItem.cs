using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.VillegeItems
{
    public abstract class VillageItem : IShape
    {
        private readonly List<IShape> items;
        public VillageItem()
        {
            items = new List<IShape>();
        }

        public void addItem(IShape shape)
        {
            items.Add(shape);
        }
        public void draw(Graphics g, Pen p)
        {
            foreach (IShape item in items)
            {
                item.draw(g, p);
            }
        }
        
    }
}
