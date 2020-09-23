using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public class OpenItem
    {
        private readonly NationManager nm;
        private readonly MouseEventArgs e;

        public OpenItem(NationManager nm ,MouseEventArgs e, bool radioChecked)
        {
            this.nm = nm;
            this.e = e;
        }

        public void Open()
        {
            nm.DrawTree(e);
        }
    }
}
