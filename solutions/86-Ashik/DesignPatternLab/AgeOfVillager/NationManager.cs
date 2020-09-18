using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class NationManager
    {
        private readonly string myNation;
        private readonly NationFactory nationFactory;

        public NationManager(string myNation, NationFactory nationFactory)
        {
            this.myNation = myNation;
            this.nationFactory = nationFactory;
        }

        public void Draw(MouseEventArgs e)
        {
            INation nation = nationFactory.GetNation(myNation);
            nation.drawTree(e);
        }
    }
}
