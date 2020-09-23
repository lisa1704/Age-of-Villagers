using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ageofvillagers.Nations
{
    class ArabBeduin : INation
    {
        private Graphics g;
        private Pen p;
        public readonly String Name="Arab Beduin";
        public string get_nation()
        {
            return Name;
        }

        public ArabBeduin(Graphics g, Pen p)
        {
            this.g = g;
            this.p = p;
        }

        public void drawHouse(int x, int y)
        {
            Arab_House House = new Arab_House();
            House.Draw(g, p, x, y);
        }

       

        public void drawTree(int x, int y)
        {
            Arab_Tree Tree = new Arab_Tree();
            Tree.Draw(g, p, x, y);

        }

        public void drawWaterSource(int x, int y)
        {
            
        }

        
    }
}
