using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class NationFactory
    {
        private Panel drawingPanel;

        public NationFactory(Panel drawingPanel)
        {
            this.drawingPanel = drawingPanel;
        }

        public INation nationUpdate(int selectedIndex)
        {
            if (selectedIndex == 0)
            {
                return new BangladeshiFarmers(this.drawingPanel);
            }
            else if (selectedIndex == 1)
            {
                return new ArabBedouins();
            }
            else if (selectedIndex == 2)
            {
                return new EgyptianKings();
            }
            else if (selectedIndex == 3)
            {
                return new InuitHunters();
            }
            else
                return null;
        }
    }
}
