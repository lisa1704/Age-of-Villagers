using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class SelectNation
    {
        protected Panel panel;
        public SelectNation(Panel panel)
        {
            this.panel = panel;
        }
        public AbstractPainter selectedNationUpdate(int index)
        {
            if (index == 0)
            {
                return new ArabPainter(this.panel);
            }
            else if (index == 1)
            {
                return new BangladeshiPainter(this.panel);
            }
            else if (index == 2)
            {
                return new EgyptianPainter(this.panel);
            }
            else if (index == 3)
            {
                return new InuitPainter(this.panel);
            }

            return null;
        }
    }
}
