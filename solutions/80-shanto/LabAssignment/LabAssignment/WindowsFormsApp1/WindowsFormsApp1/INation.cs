using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public interface INation
    {
        void DrawHouse(MouseEventArgs e);
        void DrawTree(MouseEventArgs e);
        void DrawWaterSource(MouseEventArgs e);
        //string villageName();
        Color drawcolor();
    }




}
