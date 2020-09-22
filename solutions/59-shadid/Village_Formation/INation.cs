using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village_Formation
{
    public interface INation
    {
        void DrawTree(MouseEventArgs e);

        void DrawHouse(MouseEventArgs e);

        void DrawWaterResource(MouseEventArgs e);

    }
}


