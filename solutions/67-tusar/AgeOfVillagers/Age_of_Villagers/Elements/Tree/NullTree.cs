using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class NullTree : ITree
    {
        public void drawTree(Axes axes, Panel drawingSpace)
        {
            //paint nothing
        }
    }
}
