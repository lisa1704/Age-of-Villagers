using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public interface IHouse
    {
        void drawHouse(Axes axes, Panel drawingSpace);
    }
}
