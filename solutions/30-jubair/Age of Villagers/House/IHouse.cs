using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers.House
{
    interface IHouse
    {
        void draw_house(MouseEventArgs e, Graphics graphics, Pen pen);
    }
}
