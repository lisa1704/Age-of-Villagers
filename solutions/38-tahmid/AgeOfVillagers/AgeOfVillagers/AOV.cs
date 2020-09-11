using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class AOV : Games
    {
        public void createVillage(Panel drawing_panel, System.Windows.Forms.Label village_name)
        {
            village_name.Text = "Katakhali";
            drawing_panel.Invalidate();
        }
    }
}
