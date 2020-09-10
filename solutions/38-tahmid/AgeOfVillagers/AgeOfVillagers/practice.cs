using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class practice
    {
        internal void setName(System.Windows.Forms.Label village_name)
        {
            
            village_name.Text = "woo";

        }

        internal void setObj(object sender)
        {
            
        }

        internal void setPanel(Panel drawing_panel)
        {
            drawing_panel.Invalidate();
        }
    }
}
