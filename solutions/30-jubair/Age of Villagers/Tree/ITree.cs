using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Age_of_Villagers.Tree
{
    interface ITree
    {
        void draw_tree(MouseEventArgs e, Graphics graphics, Pen pen);

    }
}
