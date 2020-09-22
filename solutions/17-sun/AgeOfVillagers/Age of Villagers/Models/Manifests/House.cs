using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers.Models.Manifests
{
    abstract class House : IShape
    {
        List<Line> LineList = new List<Line>();
        public void Draw(Graphics gfx, Pen p)
        {
            throw new NotImplementedException();
        }
    }
}
