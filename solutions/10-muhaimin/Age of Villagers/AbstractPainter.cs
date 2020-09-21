using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Age_of_Villagers
{
    public abstract class AbstractPainter : IPainter
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
        public void drawHouse(Axis axes)
        {
            house.drawHouse(axes, drawingSpace);
        }

        public void drawTree(Axis axes)
        {
            tree.drawTree(axes, drawingSpace);
        }
        public void drawWaterSource(Axis axes)
        {
            wSource.drawWaterSource(axes, drawingSpace);
        }
        public void paintTerrain()
        {
            drawingSpace.BackColor = color;
        }
        public IHouse getHouseType()
        {
            return this.house;
        }

        public ITree getTreeType()
        {
            return this.tree;
        }

        public IWaterSource getWSourceType()
        {
            return this.wSource;
        }
    }
}
