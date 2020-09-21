using age_of_villagers.shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.villageitem
{
    public abstract class villageitem : Ishape
    {
        private readonly List<Ishape> items;
        public villageitem()
        {
            items = new List<Ishape>();
        }

        public void Additem(Ishape shape)
        {
            items.Add(shape);

        }
        public void draw(Graphics g, Pen p)
        {
            foreach (Ishape item in items)
            {
                item.draw(g, p);
            }
        }

    }
  }
