using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;



namespace Age_Of_Villagers
{
    class Village
    {
        string villageName;
        INations nation;
        GraphicsState graphics;

        public string VillageName { get => villageName; set => villageName = value; }

        public GraphicsState Graphics { get => graphics; set => graphics = value; }
        internal INations Nation { get => nation; set => nation = value; }
    }
}
