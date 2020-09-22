using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class SelectNation
    {
        protected Panel panel;
        public SelectNation(Panel panel)
        {
            this.panel = panel;
        }
        public AbstractNation NationIndex(int index)
        {
            if (index == 0)
                return new BangladeshiFarmers(this.panel);
            else if (index == 1)
                return new ArabBedouin(this.panel);
            else if (index == 2)
                return new EgyptianKings(this.panel);
            else if (index == 3)
                return new InuitHunters(this.panel);
            return null;
        }
    }
}
