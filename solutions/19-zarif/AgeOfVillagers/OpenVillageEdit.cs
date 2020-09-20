using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class OpenVillageEdit
    {
        private readonly Graphics g;
        private readonly Pen pen;
        private readonly Panel panel;

        public OpenVillageEdit(Graphics g , Pen pen,Panel panel)
        {
            this.g = g;
            this.pen = pen;
            this.panel = panel;
        }
        public void ResetState(VillageState village, string check)
        {
            NationManager manager = new NationManager(check);
           

            foreach (Point pt in village._housePoints)
            {
                manager.getNation(pt).GetHouse().draw(g, pen);
            }
            foreach (Point pt in village._treePoints)
            {
                manager.getNation(pt).GetTrees().draw(g, pen);
            }
            foreach (Point pt in village._WaterScPoints)
            {
                manager.getNation(pt).GetWaterSources().draw(g, pen);
            }

            
        }

    }
}
