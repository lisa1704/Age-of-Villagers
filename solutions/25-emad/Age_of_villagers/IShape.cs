using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Age_of_villagers
{
    public interface IShape
    {
         void Draw(Graphics g, Pen pen);
       
    }
}