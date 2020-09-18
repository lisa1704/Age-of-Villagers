using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Age_of_Villagers
{
    abstract class AbstractPainter : IPainter
    {
        protected Panel drawingSpace;
        protected List<House> houses = new List<House>();
        protected List<Tree> trees = new List<Tree>();
        protected List<WaterSource> wSources = new List<WaterSource>();
        public AbstractPainter(Panel panel)
        {
            drawingSpace = panel;
            paintTerrain();
        }
        public void drawVillage()
        {
            drawHouses();
            drawTrees();
            drawWaterSources();
        }

        public void drawHouses()
        {
            foreach (House house in houses)
            {
                drawHouse(house.getX(), house.getY());
            }
        }
        public void drawTrees()
        {
            foreach (Tree tree in trees)
            {
                drawTree(tree.getX(), tree.getY());
            }
        }
        public void drawWaterSources()
        {
            foreach (WaterSource wSource in wSources)
            {
                drawWaterSource(wSource.getX(), wSource.getY());
            }
        }

        public abstract void drawHouse(int x, int y);
        public abstract void drawTree(int x, int y);
        public abstract void drawWaterSource(int x, int y);
        public abstract void paintTerrain();
    }
}
