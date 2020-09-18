using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class Nations
    {
        private string Nationtype;
        private Panel Drawingpanel;


        public Nations(string Nationtype, Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
            this.Nationtype = Nationtype;
        }
        public void getNation()
        {
        }

    }
}
