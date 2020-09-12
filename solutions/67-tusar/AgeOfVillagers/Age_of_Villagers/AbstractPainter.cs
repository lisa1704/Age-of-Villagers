using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    abstract class AbstractPainter : IPainter
    {
        protected Panel drawingSpace;
        protected IHouse house;
        protected ITree tree;
        protected IWaterSource wSource;
        protected Color color;
        public AbstractPainter(Panel panel)
        {
            drawingSpace = panel;
        }
        public  void drawHouse(Axes axes)
        {
            house.drawHouse(axes, drawingSpace);
        }

        public  void drawTree(Axes axes)
        {
            tree.drawTree(axes, drawingSpace);
        }

        public  void drawWaterSource(Axes axes)
        {
            wSource.drawWaterSource(axes, drawingSpace);
        }

        public  void paintTerrain()
        {
            drawingSpace.BackColor = color;
        }
    }
}
