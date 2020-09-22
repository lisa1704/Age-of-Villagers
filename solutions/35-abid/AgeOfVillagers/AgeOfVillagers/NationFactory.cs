using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NationFactory
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
                return new ArabBedouins(this.drawingPanel);
            }
            else if (selectedIndex == 2)
            {
                return new EgyptianKings(this.drawingPanel);
            }
            else if (selectedIndex == 3)
            {
                return new InuitHunters(this.drawingPanel);
            }
            else
                return null;
        }
    }
}
